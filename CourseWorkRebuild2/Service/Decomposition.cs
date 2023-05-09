using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Collections;

namespace CourseWorkRebuild2
{
    internal class Decomposition
    {
        private List<Double> listOfMValues = new List<Double>();
        private List<Double> listOfBottomLineMValues = new List<Double>();
        private List<Double> listOfTopLineMValues = new List<Double>();
        private List<Double> forecastTopLineMValue = new List<Double>();
        private List<Double> forecastBottomLineMValue = new List<Double>();
        private List<Double> forecastMValue = new List<Double>();
        Calculations calculations = new Calculations();

        public void ThirdLevelFillDistanceTable(DataGridView distanceBetweenMarks, List<List<String>> marks, ComboBox chooseBlock, DataGridView initialTable, DataGridView marksExcess, ListBox strongConnectionsListBox, String T)
        {
            strongConnectionsListBox.Items.Clear();
            distanceBetweenMarks.Columns.Clear();
            distanceBetweenMarks.Rows.Clear();
            marksExcess.Columns.Clear();
            marksExcess.Rows.Clear();
            int index = 1;
            distanceBetweenMarks.Columns.Add(new DataGridViewTextBoxColumn());
            distanceBetweenMarks.Columns[0].Name = "Эпоха";
            marksExcess.Columns.Add(new DataGridViewTextBoxColumn());
            marksExcess.Columns[0].Name = "Эпоха";
            for (int i = 0; i < marks[chooseBlock.SelectedIndex].Count; i++)
            {
                for (int j = 1; j < marks[chooseBlock.SelectedIndex].Count + 1; j++)
                {
                    if (i == (j - 1))
                    {
                        continue;
                    }
                    if ((j > i) | (j == marks[chooseBlock.SelectedIndex].Count & i == marks[chooseBlock.SelectedIndex].Count - 1))
                    {
                        marksExcess.Columns.Add(new DataGridViewTextBoxColumn());
                        distanceBetweenMarks.Columns.Add(new DataGridViewTextBoxColumn());
                        marksExcess.Columns[index].Name = marks[chooseBlock.SelectedIndex][i] + "-" + marks[chooseBlock.SelectedIndex][j - 1];
                        distanceBetweenMarks.Columns[index].Name = marks[chooseBlock.SelectedIndex][i] + "-" + marks[chooseBlock.SelectedIndex][j - 1];
                        index++;
                    }
                }
            }
            for (int i = 0; i < initialTable.Rows.Count - 1; i++)
            {
                distanceBetweenMarks.Rows.Add();
                distanceBetweenMarks.Rows[i].Cells[0].Value = initialTable.Rows[i].Cells[0].Value;
                marksExcess.Rows.Add();
                marksExcess.Rows[i].Cells[0].Value = initialTable.Rows[i].Cells[0].Value;
            }
            for (int i = 0; i < distanceBetweenMarks.Rows.Count - 1; i++)
            {
                for (int j = 1; j < distanceBetweenMarks.Columns.Count; j++)
                {
                    String columnName = distanceBetweenMarks.Columns[j].Name;
                    string[] indexes = columnName.Split('-');
                    string firstIndex = indexes[0];
                    string secondIndex = indexes[1];
                    distanceBetweenMarks.Rows[i].Cells[j].Value = Math.Abs(Convert.ToDouble(initialTable.Rows[i].Cells[initialTable.Columns[firstIndex].Index].Value) - Convert.ToDouble(initialTable.Rows[i].Cells[initialTable.Columns[secondIndex].Index].Value));
                }
            }
            for (int i = 1; i < marksExcess.Columns.Count; i++)
            {
                for (int j = 0; j < marksExcess.Rows.Count - 1; j++)
                {
                    marksExcess.Rows[j].Cells[i].Value = Math.Abs(Convert.ToDouble(distanceBetweenMarks.Rows[0].Cells[i].Value) - Convert.ToDouble(distanceBetweenMarks.Rows[j].Cells[i].Value));
                }
            }
            bool flag = true;
            for (int i = 1; i < marksExcess.Columns.Count; i++)
            {
                for (int j = 0; j < marksExcess.Rows.Count - 1; j++)
                {
                    if (Convert.ToDouble(marksExcess.Rows[j].Cells[i].Value) >= (Convert.ToDouble(T) + 0.007d))
                    {
                        flag = false; break;
                    }
                }
                if (flag == true)
                {
                    strongConnectionsListBox.Items.Add(marksExcess.Columns[i].Name);
                }
                flag = true;
            }


        }
        public void FourthLevelChartAddLine(String mark, DataGridView elevatorTable, List<String> values, Chart fourthLevelChart)
        {
            ChartDiagramService chartDiagramService = new ChartDiagramService();
            List<Double> listOfEpoch = new List<Double>();
            List<Double> listOfMarkValues = new List<Double>();
            List<Double> listOfSmoothValues = new List<Double>();
            for (int i = 0; i < elevatorTable.Rows.Count - 1; i++)
            {
                listOfEpoch.Add(Convert.ToInt32(elevatorTable.Rows[i].Cells[0].Value));
            }
            for (int i = 0; i < elevatorTable.Rows.Count - 1; i++)
            {
                listOfMarkValues.Add(Convert.ToDouble(elevatorTable.Rows[i].Cells[mark].Value));
            }
            listOfSmoothValues = calculations.GetForecastValue(listOfMarkValues, Convert.ToDouble(values[3]));
            chartDiagramService.AddXYLine(mark, listOfEpoch, listOfMarkValues, fourthLevelChart);
            String forecastMark = "Прогноз " + mark;
            listOfEpoch.Add(listOfEpoch.Last() + 1);
            chartDiagramService.AddForecastValue(forecastMark, listOfEpoch, listOfSmoothValues, fourthLevelChart);

        }
        public void FourthLevelChartRemoveLine(String mark, Chart fourthLevelChart)
        {
            ChartDiagramService chartDiagramService = new ChartDiagramService();
            String forecastMark = "Прогноз " + mark;
            chartDiagramService.RemoveLine(fourthLevelChart, mark);
            chartDiagramService.RemoveLine(fourthLevelChart, forecastMark);
        }

        public List<List<Double>> SecondLevel(DataGridView elevatorTable, List<String> values, List<List<String>> marks, ComboBox chooseBlock)
        {
            List<List<Double>> result = new List<List<Double>>();

            List<String> mark = new List<String>();

            mark = marks[0];

            if (chooseBlock.SelectedItem != null)
            {
                mark = marks[chooseBlock.SelectedIndex];
            }
            
            Double T = Convert.ToDouble(values[2]);
            Double Alpha = Convert.ToDouble(values[3]);
            DataGridView bottomLineTable = calculations.CalculateBottomOrTopLineTableToSecondLevel(elevatorTable, mark, T, "-");
            DataGridView topLineTable = calculations.CalculateBottomOrTopLineTableToSecondLevel(elevatorTable, mark, T, "+");
            listOfBottomLineMValues = calculations.CalculateMValues(bottomLineTable);
            listOfTopLineMValues = calculations.CalculateMValues(topLineTable);
            forecastTopLineMValue = calculations.GetForecastValue(listOfTopLineMValues, Alpha);
            forecastBottomLineMValue = calculations.GetForecastValue(listOfBottomLineMValues, Alpha);
            listOfMValues = calculations.CalculateMValues(elevatorTable, mark);
            forecastMValue = calculations.GetForecastValue(listOfMValues, Alpha);

            result.Add(listOfBottomLineMValues);
            result.Add(forecastBottomLineMValue);
            result.Add(listOfMValues);
            result.Add(forecastMValue);
            result.Add(listOfTopLineMValues);
            result.Add(forecastTopLineMValue);

            return result;
        }

        public List<List<Double>> FirstLevel(DataGridView elevatorTable, DataTable dataTable, List<String> values)
        {
            List<List<Double>> result = new List<List<Double>>();  

            Double T = Convert.ToDouble(values[2]);
            Double Alpha = Convert.ToDouble(values[3]);
            DataGridView bottomLineTable = calculations.CalculateBottomOrTopLineTable(dataTable, T, elevatorTable, "-");
            DataGridView topLineTable = calculations.CalculateBottomOrTopLineTable(dataTable, T, elevatorTable, "+");
            listOfBottomLineMValues = calculations.CalculateMValues(bottomLineTable);
            listOfTopLineMValues = calculations.CalculateMValues(topLineTable);
            forecastTopLineMValue = calculations.GetForecastValue(listOfTopLineMValues, Alpha);
            forecastBottomLineMValue = calculations.GetForecastValue(listOfBottomLineMValues, Alpha);
            listOfMValues = calculations.CalculateMValues(elevatorTable);
            forecastMValue = calculations.GetForecastValue(listOfMValues, Alpha);

            result.Add(listOfBottomLineMValues);
            result.Add(forecastBottomLineMValue);
            result.Add(listOfMValues);
            result.Add(forecastMValue);
            result.Add(listOfTopLineMValues);
            result.Add(forecastTopLineMValue);

            return result;
        }

        public DataGridView ClearTable(DataGridView dataTable)
        {
            dataTable.Columns.Clear();
            dataTable.Rows.Clear();
            return dataTable;
        }

        public DataGridView FillTable(DataGridView dataTable, List<List<Double>> values, DataGridView table)
        {
            dataTable.Rows.Clear();
            dataTable.Columns.Clear();

            //Добавляем столбики
            dataTable.Columns.Add(new DataGridViewTextBoxColumn());
            dataTable.Columns.Add(new DataGridViewTextBoxColumn());
            dataTable.Columns.Add(new DataGridViewTextBoxColumn());
            dataTable.Columns.Add(new DataGridViewTextBoxColumn());
            dataTable.Columns.Add(new DataGridViewTextBoxColumn());
            dataTable.Columns.Add(new DataGridViewTextBoxColumn());
            dataTable.Columns.Add(new DataGridViewTextBoxColumn());
            dataTable.Columns[0].Name = "Эпоха";
            dataTable.Columns[1].Name = "М(нижнее)";
            dataTable.Columns[2].Name = "М";
            dataTable.Columns[3].Name = "М(верхнее)";
            dataTable.Columns[4].Name = "2E";
            dataTable.Columns[5].Name = "L";
            dataTable.Columns[6].Name = "Состояние";

            int forecastIndex = 0;
            //Записываем эпохи
            for (int i = 0; i < table.RowCount; i++)
            {
                dataTable.Rows.Add();
                dataTable.Rows[i].Cells[0].Value = table.Rows[i].Cells[0].Value;
                forecastIndex = i + 1;
            }
            dataTable.Rows[forecastIndex - 1].Cells[0].Value = Convert.ToDouble(table.Rows[forecastIndex - 2].Cells[0].Value) + 1;
            //Заполняем таблицу значениями M(низ) + прогноз
            for (int i = 0; i < values[0].Count; i++)
            {
                dataTable.Rows[i].Cells[1].Value = values[0][i];

            }
            dataTable.Rows[table.Rows.Count - 1].Cells[1].Value = values[1].Last();
            //Заполняем таблицу значениями M(вверх) + прогноз
            for (int i = 0; i < values[4].Count; i++)
            {
                dataTable.Rows[i].Cells[3].Value = values[4][i];

            }
            dataTable.Rows[table.Rows.Count - 1].Cells[3].Value = values[5].Last();
            //Заполняем таблицу значениями M(исходное) + прогноз
            for (int i = 0; i < values[2].Count; i++)
            {
                dataTable.Rows[i].Cells[2].Value = values[2][i];

            }
            dataTable.Rows[table.Rows.Count - 1].Cells[2].Value = values[3].Last();
            //Считаем значение 2Е (по модулю (М(верх) - М(низ)))
            for (int i = 0; i < dataTable.Rows.Count - 1; i++)
            {
                dataTable.Rows[i].Cells[4].Value = Math.Abs(Convert.ToDouble(dataTable.Rows[i].Cells[1].Value) - Convert.ToDouble(dataTable.Rows[i].Cells[3].Value));
            }
            //Считаем L (по модулю (M(0) - M(i)))
            for (int i = 0; i < dataTable.Rows.Count - 1; i++)
            {
                dataTable.Rows[i].Cells[5].Value = Math.Abs(Convert.ToDouble(dataTable.Rows[0].Cells[2].Value) - Convert.ToDouble(dataTable.Rows[i].Cells[2].Value));
            }
            //Считаем есть ли выход за границу
            for (int i = 0; i < dataTable.Rows.Count - 1; i++)
            {
                if (Convert.ToDouble(dataTable.Rows[i].Cells[5].Value) < Convert.ToDouble(dataTable.Rows[i].Cells[4].Value) / 2)
                {
                    dataTable.Rows[i].Cells[6].Value = "В пределе";
                }
                else dataTable.Rows[i].Cells[6].Value = "Выход за границу";
            }
            return dataTable;
        }


    }

}
