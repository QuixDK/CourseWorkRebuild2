﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkRebuild2.Helpers
{
    public partial class ExpSmoothChart : Form
    {
        private ChartDiagramService chartDiagramService = new ChartDiagramService();
        private Calculations calculations = new Calculations();
        private List<Double> MValues = new List<Double>();
        private List<Double> AValues = new List<Double>();
        private List<Double> smoothMValues = new List<Double>();
        private List<Double> smoothAValues = new List<Double>();
        private List<Int32> epochList = new List<Int32>();
        private DataGridView elevatorTable;
        private DataTable dataTable;
        private List<String> values;
        private List<String> mark;
        private int a = 0;
        
        public ExpSmoothChart(DataGridView elevatorTable, DataTable dataTable, List<string> values, int a)
        {
            InitializeComponent();
            this.elevatorTable = elevatorTable;
            this.dataTable = dataTable;
            this.values = values;
            this.a = a;
        }
        public ExpSmoothChart(DataGridView elevatorTable, DataTable dataTable, List<string> values, int a, List<String> mark)
        {
            InitializeComponent();
            this.elevatorTable = elevatorTable;
            this.dataTable = dataTable;
            this.values = values;
            this.a = a;
            this.mark = mark;
        }

        private void MChart_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Длина вектора М (реальное)";
            if (expSmooth.Series.IndexOf(serieName) != -1) chartDiagramService.removeLine(expSmooth, serieName);
            else chartDiagramService.AddExpSmoothLine(serieName, epochList, MValues, expSmooth);

            String serieName2 = "Длина вектора М (сглаженное)";
            if (expSmooth.Series.IndexOf(serieName2) != -1) chartDiagramService.removeLine(expSmooth, serieName2);
            else chartDiagramService.AddExpSmoothLine(serieName2, epochList, smoothMValues, expSmooth);
        }

        private void alphaChart_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Угол а (реальное)";
            if (expSmooth.Series.IndexOf(serieName) != -1) chartDiagramService.removeLine(expSmooth, serieName);
            else chartDiagramService.AddExpSmoothLine(serieName, epochList, AValues, expSmooth);

            String serieName2 = "Угол а (сглаженное)";
            if (expSmooth.Series.IndexOf(serieName2) != -1) chartDiagramService.removeLine(expSmooth, serieName2);
            else chartDiagramService.AddExpSmoothLine(serieName2, epochList, smoothAValues, expSmooth);
        }

        private void ExpSmoothChart_Load(object sender, EventArgs e)
        {
            if (values.Count == 0)
            {
                return;
            }
            int forecastIndex = 0;
            for (int i = 0; i < elevatorTable.Rows.Count-1; i++)
            {
                epochList.Add(Convert.ToInt32(elevatorTable.Rows[i].Cells[0].Value));
                forecastIndex = i;
            }
            epochList.Add(Convert.ToInt32(elevatorTable.Rows[forecastIndex].Cells[0].Value) + 1);
            if (a == 1)
            {
                Double T = Convert.ToDouble(values[2]);
                Double Alpha = Convert.ToDouble(values[3]);
                MValues = calculations.calculateMValues(elevatorTable);
                AValues = calculations.calculateAValuesForChart(elevatorTable, MValues);
                MValues.Remove(MValues.Last());
                AValues.Remove(AValues.Last());
                smoothMValues = calculations.getForecastValue(MValues, Alpha);
                smoothAValues = calculations.getForecastValue(AValues, Alpha);
            }
            else if (a == 2)
            {
                Double T = Convert.ToDouble(values[2]);
                Double Alpha = Convert.ToDouble(values[3]);
                MValues = calculations.calculateMValuesForSecondLevel(elevatorTable, mark);
                AValues = calculations.calculateAValuesForSecondLevel(elevatorTable, MValues, mark);
                MValues.Remove(MValues.Last());
                smoothMValues = calculations.getForecastValue(MValues, Alpha);
                AValues.Remove(AValues.Last());
                smoothAValues = calculations.getForecastValue(AValues, Alpha);
            }
        }
    }
}