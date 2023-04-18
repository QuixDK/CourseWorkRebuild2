using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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

        public List<ListBox> SecondLevel(DataGridView elevatorTable, List<String> values, List<ListBox> lists, List<List<String>> marks, ComboBox chooseBlock)
        {
            foreach (ListBox listBox in lists)
            {
                listBox.Items.Clear();
            }
            List<String> mark = new List<String>();
            mark = marks[0];
            if (chooseBlock.SelectedIndex == 0)
            {
                mark = marks[0];
            }
            else if (chooseBlock.SelectedIndex == 1)
            {
                mark = marks[1];
            }
            else if (chooseBlock.SelectedIndex == 2)
            {
                mark = marks[2];
            }
            else if (chooseBlock.SelectedIndex == 3)
            {
                mark = marks[3];
            }
            else if (chooseBlock.SelectedIndex == 4)
            {
                mark = marks[4];
            }
            Calculations calculations = new Calculations();
            Double T = Convert.ToDouble(values[2]);
            Double Alpha = Convert.ToDouble(values[3]);
            DataGridView bottomLineTable = calculations.calculateBottomLineToSecondLevel(elevatorTable, mark, T);
            DataGridView topLineTable = calculations.calculateTopLineToSecondLevel(elevatorTable, mark, T);
            listOfBottomLineMValues = calculations.calculateLineMValues(bottomLineTable);
            listOfBottomLineMValues.Remove(listOfBottomLineMValues.Last());
            listOfTopLineMValues = calculations.calculateLineMValues(topLineTable);
            listOfTopLineMValues.Remove(listOfTopLineMValues.Last());
            forecastTopLineMValue = calculations.getForecastValue(listOfTopLineMValues, Alpha);
            forecastBottomLineMValue = calculations.getForecastValue(listOfBottomLineMValues, Alpha);
            listOfMValues = calculations.calculateMValuesForSecondLevel(elevatorTable, mark);
            listOfMValues.Remove(listOfMValues.Last());
            forecastMValue = calculations.getForecastValue(listOfMValues, Alpha);

            return fillListBoxes(lists);
        }

        public List<ListBox> FirstLevel(DataGridView elevatorTable, DataTable dataTable, List<String> values, List<ListBox> lists)
        {
            foreach (ListBox listBox in lists)
            {
                listBox.Items.Clear();
            }
            Calculations calculations = new Calculations();
            Double T = Convert.ToDouble(values[2]);
            Double Alpha = Convert.ToDouble(values[3]);
            DataGridView bottomLineTable = calculations.calculateBottomLine(dataTable, T, elevatorTable);
            DataGridView topLineTable = calculations.calculateTopLine(dataTable, T, elevatorTable);
            listOfBottomLineMValues = calculations.calculateLineMValues(bottomLineTable);
            listOfTopLineMValues = calculations.calculateLineMValues(topLineTable);
            forecastTopLineMValue = calculations.getForecastValue(listOfTopLineMValues, Alpha);
            forecastBottomLineMValue = calculations.getForecastValue(listOfBottomLineMValues, Alpha);
            listOfMValues = calculations.calculateMValues(elevatorTable);
            listOfMValues.Remove(listOfMValues.Last());
            forecastMValue = calculations.getForecastValue(listOfMValues, Alpha);

            return fillListBoxes(lists);
        }

        public DataGridView ClearTable(DataGridView dataTable)
        {
            dataTable.Columns.Clear();
            dataTable.Rows.Clear();
            return dataTable;
        }
        
        public DataGridView FillTable(DataGridView dataTable, List<ListBox> lists, DataGridView elevatorTable)
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
            for (int i = 0; i < elevatorTable.RowCount; i++)
            {
                dataTable.Rows.Add();
                dataTable.Rows[i].Cells[0].Value = elevatorTable.Rows[i].Cells[0].Value;
                forecastIndex = i + 1;
            }
            dataTable.Rows[forecastIndex-1].Cells[0].Value = Convert.ToDouble(elevatorTable.Rows[forecastIndex-2].Cells[0].Value) + 1;
            //Заполняем таблицу из листбоксов
            int counter = 0;
            for (int i = 0; i < lists.Count-1; i++)
            {
                
                foreach (Double s in lists[i].Items)
                {
                    dataTable.Rows[counter].Cells[i+1].Value = s;
                    dataTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    counter++;
                }
                counter = 0;
            }
            foreach (String s in lists[5].Items)
            {
                dataTable.Rows[counter].Cells[6].Value = s;
                counter++;
            }
            return dataTable;
        }
        
        private List<ListBox> fillListBoxes(List<ListBox> lists)
        {
            foreach (Double value in listOfBottomLineMValues)
            {
                lists[0].Items.Add(value);
            }
            foreach (Double value in listOfTopLineMValues)
            {
                lists[2].Items.Add(value);
            }
            foreach (Double value in listOfMValues)
            {
                lists[1].Items.Add(value);
            }

            lists[0].Items.Add(forecastBottomLineMValue.Last());
            lists[1].Items.Add(forecastMValue.Last());
            lists[2].Items.Add(forecastTopLineMValue.Last());
            for (int i = 0; i < lists[0].Items.Count; i++)
            {
                lists[3].Items.Add(Math.Abs(Convert.ToDouble(lists[0].Items[i]) - Convert.ToDouble(lists[2].Items[i])));
            }
            for (int i = 0; i < lists[1].Items.Count; i++)
            {
                lists[4].Items.Add(Math.Abs(Convert.ToDouble(lists[1].Items[i]) - Convert.ToDouble(lists[1].Items[0])));
            }
            for (int i = 0; i < lists[4].Items.Count; i++)
            {
                if (Convert.ToDouble(lists[4].Items[i]) < (Convert.ToDouble(lists[3].Items[i]) / 2))
                {
                    lists[5].Items.Add("В пределе");
                }
                else if (Convert.ToDouble(lists[4].Items[i]) == (Convert.ToDouble(lists[3].Items[i]) / 2))
                {
                    lists[5].Items.Add("Точка бифуркации");
                }
                else lists[5].Items.Add("Выход за границу");
            }
            return lists;
        }
    }

}
