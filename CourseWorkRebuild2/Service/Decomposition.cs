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
        private List<Double> listOfTopLineAValues = new List<Double>();
        private List<Double> forecastTopLineAValue = new List<Double>();
        private List<Double> listOfAValues = new List<Double>();
        private List<Double> listOfBottomLineAValues = new List<Double>();
        private List<Double> forecastBottomLineAValue = new List<Double>();
        private List<Double> forecastAValue = new List<Double>();
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
            listOfBottomLineAValues = calculations.CalculateAValues(bottomLineTable, listOfBottomLineMValues);
            listOfTopLineMValues = calculations.CalculateMValues(topLineTable);
            listOfTopLineAValues = calculations.CalculateAValues(topLineTable, listOfTopLineMValues);
            forecastTopLineMValue = calculations.GetForecastValue(listOfTopLineMValues, Alpha);
            forecastBottomLineMValue = calculations.GetForecastValue(listOfBottomLineMValues, Alpha);
            forecastTopLineAValue = calculations.GetForecastValue(listOfTopLineAValues, Alpha);
            forecastBottomLineAValue = calculations.GetForecastValue(listOfBottomLineAValues, Alpha);
            listOfMValues = calculations.CalculateMValues(elevatorTable, mark);
            listOfAValues = calculations.CalculateAValues(elevatorTable, listOfMValues, mark);
            forecastMValue = calculations.GetForecastValue(listOfMValues, Alpha);
            forecastAValue = calculations.GetForecastValue(listOfAValues, Alpha);

            result.Add(listOfBottomLineMValues); //0
            result.Add(forecastBottomLineMValue); //1
            result.Add(listOfMValues); //2
            result.Add(forecastMValue); //3
            result.Add(listOfTopLineMValues); //4
            result.Add(forecastTopLineMValue); //5

            result.Add(listOfBottomLineAValues); //6
            result.Add(forecastBottomLineAValue); //7
            result.Add(listOfAValues); //8
            result.Add(forecastAValue); //9
            result.Add(listOfTopLineAValues); //10
            result.Add(forecastTopLineAValue); //11

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
            listOfBottomLineAValues = calculations.CalculateAValues(bottomLineTable, listOfBottomLineMValues);
            listOfTopLineMValues = calculations.CalculateMValues(topLineTable);
            listOfTopLineAValues = calculations.CalculateAValues(topLineTable, listOfTopLineMValues);
            forecastTopLineMValue = calculations.GetForecastValue(listOfTopLineMValues, Alpha);
            forecastTopLineAValue = calculations.GetForecastValue(listOfTopLineAValues, Alpha);
            forecastBottomLineMValue = calculations.GetForecastValue(listOfBottomLineMValues, Alpha);
            forecastBottomLineAValue = calculations.GetForecastValue(listOfBottomLineAValues, Alpha);
            listOfMValues = calculations.CalculateMValues(elevatorTable);
            listOfAValues = calculations.CalculateAValues(elevatorTable, listOfMValues);
            forecastMValue = calculations.GetForecastValue(listOfMValues, Alpha);
            forecastAValue = calculations.GetForecastValue(listOfAValues, Alpha);

            result.Add(listOfBottomLineMValues);
            result.Add(forecastBottomLineMValue);
            result.Add(listOfMValues);
            result.Add(forecastMValue);
            result.Add(listOfTopLineMValues);
            result.Add(forecastTopLineMValue);

            result.Add(listOfBottomLineAValues);
            result.Add(forecastBottomLineAValue);
            result.Add(listOfAValues);
            result.Add(forecastAValue);
            result.Add(listOfTopLineAValues);
            result.Add(forecastTopLineAValue);

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

        public void FillPhaseCoordinatesTable(DataGridView elevationTable, List<List<Double>> Values, DataGridView table)
        {

            table.Columns.Clear();

            for (int i = 0; i < 13; i++)
            {
                table.Columns.Add(new DataGridViewTextBoxColumn());
            }

            table.Columns[0].Name = "Эпоха";
            table.Columns[1].Name = "Исходное М";
            table.Columns[2].Name = "Верхнее М";
            table.Columns[3].Name = "Нижнее М";
            table.Columns[4].Name = "Исходное Альфа";
            table.Columns[5].Name = "Верхнее Альфа";
            table.Columns[6].Name = "Нижнее Альфа";
            table.Columns[7].Name = "Сглаженное M";
            table.Columns[8].Name = "Сглаженное М верхнее";
            table.Columns[9].Name = "Сглаженное М нижнее";
            table.Columns[10].Name = "Сглаженное Альфа";
            table.Columns[11].Name = "Сглаженное Aльфа верхнее";
            table.Columns[12].Name = "Сглаженное Aльфа нижнее";

            for (int i = 0; i < elevationTable.Rows.Count - 1; i++)
            {
                table.Rows.Add();
                table.Rows[i].Cells[0].Value = elevationTable.Rows[i].Cells[0].Value;
                table.Rows[i].Cells[1].Value = Values[2][i];
                table.Rows[i].Cells[2].Value = Values[4][i];
                table.Rows[i].Cells[3].Value = Values[0][i];
                table.Rows[i].Cells[4].Value = Values[8][i];
                table.Rows[i].Cells[5].Value = Values[10][i];
                table.Rows[i].Cells[6].Value = Values[6][i];
            }
            table.Rows.Add();
            int lastIndex = table.Rows.GetLastRow(0x0);
            table.Rows[lastIndex - 1].Cells[0].Value = Convert.ToDouble(elevationTable.Rows[lastIndex - 2].Cells[0].Value) + 1;

            for (int i = 0; i < elevationTable.Rows.Count; i++)
            {
                table.Rows[i].Cells[7].Value = Values[3][i];
                table.Rows[i].Cells[8].Value = Values[5][i];
                table.Rows[i].Cells[9].Value = Values[1][i];
                table.Rows[i].Cells[10].Value = Values[9][i];
                table.Rows[i].Cells[11].Value = Values[11][i];
                table.Rows[i].Cells[12].Value = Values[7][i];
            }

        }
    }

}
