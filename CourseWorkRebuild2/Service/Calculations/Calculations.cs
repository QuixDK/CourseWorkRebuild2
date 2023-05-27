using CourseWorkRebuild;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CourseWorkRebuild2
{
    internal class Calculations
    {

        public DataGridView CalculateBottomOrTopLineTableToSecondLevel(DataGridView elevatorTable,List<String> marks, Double T, String arithmeticSign)
        {
            DataGridView Table = new DataGridView();
            for (int i = 0; i < marks.Count; i++)
            {
                Table.Columns.Add(new DataGridViewTextBoxColumn());
                Table.Columns[i].Name = marks[i];
            }

            for (int i = 0; i < elevatorTable.Rows.Count; i++)
            {
                
                Table.Rows.Add();
                foreach (DataGridViewColumn col in elevatorTable.Columns)
                {
                    if (marks.Contains(col.Name))
                    {
                        if (arithmeticSign.Equals("-"))
                        {
                            Table.Rows[i].Cells[col.Name].Value = Convert.ToDouble(elevatorTable.Rows[i].Cells[col.Name].Value) - T;
                        }
                        else if (arithmeticSign.Equals("+"))
                        {
                            Table.Rows[i].Cells[col.Name].Value = Convert.ToDouble(elevatorTable.Rows[i].Cells[col.Name].Value) + T;
                        }
                        
                    }   
                }
            }
            return Table;
        }
        public DataGridView AddNewValuesInRow(DataGridView elevatorTable, Repository repository, int epochCount)
        {
            Double delta = 0;
            Double averageDelta = 0;
            Double newCellValue = 0;
            int newRow = elevatorTable.RowCount - 1;
            Random random = new Random();
            for (int i = 1; i < elevatorTable.Columns.Count; i++)
            {

                for (int j = 0; j < elevatorTable.Rows.Count - 1; j++)
                {
                    if (Convert.ToDouble(elevatorTable.Rows[j + 1].Cells[i].Value) != 0)
                    {
                        delta = Math.Abs(Convert.ToDouble(elevatorTable.Rows[j].Cells[i].Value) - Convert.ToDouble(elevatorTable.Rows[j + 1].Cells[i].Value));
                    }

                    averageDelta += delta;
                    delta = 0;
                }

                averageDelta /= elevatorTable.Rows.Count - 1;
                newCellValue = random.NextDouble() * (averageDelta - (-averageDelta)) + averageDelta;
                elevatorTable.Rows[newRow].Cells[i].Value = Math.Round(newCellValue + Convert.ToDouble(elevatorTable.Rows[newRow - 1].Cells[i].Value), 4);
                repository.AddNewValuesInRow(i, epochCount, Convert.ToDouble(elevatorTable.Rows[newRow].Cells[i].Value));
                averageDelta = 0;
            }
            
            elevatorTable.Rows.Add();
            return elevatorTable;
        }

        public List<Double> CalculateMValues(DataGridView elevatorTable, List<String> marks)
        {
            Double M = 0;

            List<Double> values = new List<Double>();

            List<Double> listOfMValues = new List<Double>();

            for (int i = 0; i < elevatorTable.RowCount-1; i++)
            {
                foreach (DataGridViewColumn col in elevatorTable.Columns)
                {
                    if (marks.Contains(col.Name))
                    {
                        values.Add(Convert.ToDouble(elevatorTable.Rows[i].Cells[col.Name].Value));
                        
                    }
                    
                }    
                foreach (double c in values)
                {
                    M += (c * c);
                }
                listOfMValues.Add(Math.Sqrt(M));
                M = 0;
                values.Clear();

            }
            return listOfMValues;

        }

        public List<Double> CalculateMValues(DataGridView elevatorTable)
        {
            Double M = 0;
            List<Double> values = new List<Double>();
            List<Double> listOfMValues = new List<Double>();
            int rightEdge = 0;
            int leftEdge = 0;

            if (elevatorTable.Columns[0].Name.Equals("Эпоха"))
            {
                rightEdge = elevatorTable.RowCount - 1;
                leftEdge = 1;
            }
            else rightEdge = elevatorTable.RowCount - 2;

            for (int i = 0; i < rightEdge; i++)
            {

                for (int j = leftEdge; j < elevatorTable.ColumnCount; j++)
                {
                    values.Add(Convert.ToDouble(elevatorTable.Rows[i].Cells[j].Value));
                }
                foreach (double c in values)
                {
                    M += (c * c);
                }
                listOfMValues.Add(Math.Sqrt(M));
                M = 0;
                values.Clear();
            }
       
            return listOfMValues;

        }

        public List<Double> CalculateAValues(DataGridView elevatorTable, List<Double> listOfMValues, List<String> marks)
        {
            Double calculateAcos = 0;
            Double calculateDegree = 0;
            Double summPr = 0;
            Double firstValue = 0;
            Double secondValue = 0;
            List<Double> listOfAlphaValues = new List<Double>();
            listOfAlphaValues.Add(0);

            for (int i = 0; i < elevatorTable.Rows.Count - 2; i++)
            {
                summPr = 0;
                foreach (DataGridViewColumn col in elevatorTable.Columns)
                {
                    if (marks.Contains(col.Name))
                    {
                        firstValue = Convert.ToDouble(elevatorTable.Rows[0].Cells[col.Name].Value);
                        secondValue = Convert.ToDouble(elevatorTable.Rows[i + 1].Cells[col.Name].Value);
                        summPr += firstValue * secondValue;

                    }
                }
                summPr /= listOfMValues[0];
                summPr /= listOfMValues[i + 1];
                summPr = Math.Round(summPr, 13);
                calculateAcos = Math.Acos(summPr);
                listOfAlphaValues.Add(calculateAcos * 180 / Math.PI);

            }
            return listOfAlphaValues;

        }
        public List<Double> CalculateAValues(DataGridView elevatorTable, List<Double> listOfMValues)
        {
            Double calculateAcos = 0;
            Double calculateDegree = 0;
            Double summPr = 0;
            Double firstValue = 0;
            Double secondValue = 0;
            List<Double> listOfAlphaValues = new List<Double>();
            listOfAlphaValues.Add(0);
            int rightEdge = 0;
            int leftEdge = 0;

            if (elevatorTable.Columns[0].Name.Equals("Эпоха"))
            {
                leftEdge = 1;
                rightEdge = elevatorTable.RowCount - 2;
            }
            else rightEdge = elevatorTable.RowCount - 3;

            for (int i = 0; i < rightEdge; i++)
            {
                summPr = 0;

                for (int j = leftEdge; j < elevatorTable.ColumnCount; j++)
                {
                    firstValue = Convert.ToDouble(elevatorTable.Rows[0].Cells[j].Value);
                    secondValue = Convert.ToDouble(elevatorTable.Rows[i + 1].Cells[j].Value);
                    summPr += firstValue * secondValue;
                }
                
                summPr /= listOfMValues[0];
                summPr /= listOfMValues[i+1];
                summPr = Math.Round(summPr, 13);
                calculateAcos = Math.Acos(summPr);
                listOfAlphaValues.Add(calculateAcos * 180 / Math.PI);

            }
            return listOfAlphaValues;

        }

        public List<Double> GetForecastValue(List<Double> listOfValues, Double a)
        {
            List<Double> forecastValues = new List<Double>();
            Double averageSumm = 0;
            Double value = 0;

            if (listOfValues[0] == 0)
            {
                for (int i = 1; i < listOfValues.Count; i++)
                {
                    averageSumm += listOfValues[i];
                }
                averageSumm /= listOfValues.Count - 1;
                value = a * listOfValues[0] + (1 - a) * averageSumm;
                forecastValues.Add(value);
            }
            else
            {
                value = a * listOfValues[0] + (1 - a) * listOfValues.Average();
                forecastValues.Add(value);
            }

            for (int i = 1; i < listOfValues.Count; i++)
            {
                value = a * listOfValues[i] + (1 - a) * forecastValues[i - 1];
                forecastValues.Add(value);
            }

            value = a * forecastValues.Average() + (1 - a) * forecastValues.Last();
            forecastValues.Add(value);

            return forecastValues;
        }

        public DataGridView CalculateBottomOrTopLineTable(DataTable dataTable, Double T, DataGridView elevatorTable, String arithmeticSign)
        {
            DataGridView Table = fillNewTable(dataTable);

            for (int i = 0; i < elevatorTable.Rows.Count; i++)
            {
                for (int j = 1; j < elevatorTable.ColumnCount; j++)
                {
                    if (arithmeticSign.Equals("-"))
                    {
                        Table.Rows[i].Cells[j].Value = Convert.ToDouble(elevatorTable.Rows[i].Cells[j].Value) - T;
                    }
                    else if (arithmeticSign.Equals("+"))
                    {
                        Table.Rows[i].Cells[j].Value = Convert.ToDouble(elevatorTable.Rows[i].Cells[j].Value) + T;
                    }
                    
                }
            }
            return Table;
        }

        private DataGridView fillNewTable(DataTable dataTable)
        {
            DataGridView newTable = new DataGridView();
            for (int column = 0; column < dataTable.Columns.Count; column++)
            {
                String ColName = dataTable.Columns[column].ColumnName;
                newTable.Columns.Add(ColName, ColName);
                newTable.Columns[column].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                newTable.Rows.Add(dataTable.Rows[row].ItemArray);
            }
            return newTable;
        }


    }
}