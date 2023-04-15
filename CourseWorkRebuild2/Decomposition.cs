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
        private List<Double> listOfAValues = new List<Double>();
        private List<Double> listOfBottomLineMValues = new List<Double>();
        private List<Double> listOfBottomLineAValues = new List<Double>();
        private List<Double> listOfTopLineMValues = new List<Double>();
        private List<Double> listOfTopLineAValues = new List<Double>();
        private List<Double> forecastTopLineMValue = new List<Double>();
        private List<Double> forecastBottomLineMValue = new List<Double>();
        private List<Double> forecastTopLineAValue = new List<Double>();
        private List<Double> forecastBottomLineAValue = new List<Double>();
        private List<Double> forecastMValue = new List<Double>();
        private List<Double> forecastAValue = new List<Double>();

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
            listOfBottomLineAValues = calculations.calculateLineAValues(bottomLineTable, listOfBottomLineMValues);
            listOfTopLineMValues = calculations.calculateLineMValues(topLineTable);
            listOfTopLineAValues = calculations.calculateLineAValues(topLineTable, listOfTopLineMValues);
            forecastTopLineMValue = calculations.getForecastValue(listOfTopLineMValues, Alpha);
            forecastBottomLineMValue = calculations.getForecastValue(listOfBottomLineMValues, Alpha);
            forecastTopLineAValue = calculations.getForecastValue(listOfTopLineMValues, Alpha);
            forecastBottomLineAValue = calculations.getForecastValue(listOfBottomLineMValues, Alpha);
            listOfMValues = calculations.calculateMValues(elevatorTable);
            listOfAValues = calculations.calculateAValues(elevatorTable, listOfMValues);
            listOfMValues.Remove(listOfMValues.Last());
            forecastMValue = calculations.getForecastValue(listOfMValues, Alpha);
            forecastAValue = calculations.getForecastValue(listOfAValues, Alpha);

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
        
        public DataGridView DrawTable(DataGridView dataTable, List<ListBox> lists, Int32 epochCount)
        {
            dataTable.Rows.Clear();
            dataTable.Columns.Clear();

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
            for (int i = 0; i < epochCount; i++)
            {
                dataTable.Rows.Add();
                dataTable.Rows[i].Cells[0].Value = i;
            }
            int counter = 0;
            foreach (Double s in lists[0].Items)
            {    
                dataTable.Rows[counter].Cells[1].Value = s;
                counter++; 
            }
            counter = 0;
            foreach (Double s in lists[1].Items)
            {
                dataTable.Rows[counter].Cells[2].Value = s;
                counter++;
            }
            counter = 0;
            foreach (Double s in lists[2].Items)
            {
                dataTable.Rows[counter].Cells[3].Value = s;
                counter++;
            }
            counter = 0;
            foreach (Double s in lists[3].Items)
            {
                dataTable.Rows[counter].Cells[4].Value = s;
                counter++;
            }
            counter = 0;
            foreach (Double s in lists[4].Items)
            {
                dataTable.Rows[counter].Cells[5].Value = s;
                counter++;
            }
            counter = 0;
            foreach (String s in lists[5].Items)
            {
                dataTable.Rows[counter].Cells[6].Value = s;
                counter++;
            }
            for (int column = 0; column < dataTable.Columns.Count; column++)
            {
                dataTable.Columns[column].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            return dataTable;
        }
    }

}
