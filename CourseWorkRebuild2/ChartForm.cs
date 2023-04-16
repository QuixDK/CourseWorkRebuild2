using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CourseWorkRebuild2
{
    public partial class ChartForm : Form
    {
        ChartDiagramService chartDiagramService = new ChartDiagramService();
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
        private DataGridView elevatorTable;
        Calculations calculations = new Calculations();
        private DataTable dataTable;
        private List<String> values;
        public ChartForm(DataGridView elevatorTable, DataTable dataTable, List<string> values)
        {
            InitializeComponent();
            this.elevatorTable = elevatorTable;
            this.dataTable = dataTable;
            this.values = values;
        }
        private void forecastResponseFunctionSelectBox_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Прогнозное значение";
            if (functionDiagrams.Series.IndexOf(serieName) != -1) chartDiagramService.removeLine(functionDiagrams, serieName);
            else chartDiagramService.addforecastFunction(serieName, forecastMValue, forecastAValue, functionDiagrams);
        }
        private void responseFunctionSelectBox_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Функция отклика";
            if (functionDiagrams.Series.IndexOf(serieName) != -1) chartDiagramService.removeLine(functionDiagrams, serieName);
            else chartDiagramService.addLine(listOfMValues, listOfAValues, functionDiagrams, serieName);
        }

        private void bottomLineSelectBox_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Нижняя граница";
            if (functionDiagrams.Series.IndexOf(serieName) != -1) chartDiagramService.removeLine(functionDiagrams, serieName);
            else chartDiagramService.addLine(listOfBottomLineMValues, listOfBottomLineAValues, functionDiagrams, serieName);
        }
        private void forecastBottomValues_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Прогнозное значение для нижней границы";
            if (functionDiagrams.Series.IndexOf(serieName) != -1) chartDiagramService.removeLine(functionDiagrams, serieName);
            else chartDiagramService.addforecastFunction(serieName, forecastBottomLineMValue, forecastBottomLineAValue, functionDiagrams);
        }
        private void forecastTopValues_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Прогнозное значение для верхней границы";
            if (functionDiagrams.Series.IndexOf(serieName) != -1) chartDiagramService.removeLine(functionDiagrams, serieName);
            else chartDiagramService.addforecastFunction(serieName, forecastTopLineMValue, forecastTopLineAValue, functionDiagrams);
        }

        private void topLineSelectBox_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Верхняя граница";
            if (functionDiagrams.Series.IndexOf(serieName) != -1) chartDiagramService.removeLine(functionDiagrams, serieName);
            else chartDiagramService.addLine(listOfTopLineMValues, listOfTopLineAValues, functionDiagrams, serieName);
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            if (values.Count == 0)
            {
                return;
            }
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
            forecastTopLineAValue = calculations.getForecastValue(listOfTopLineAValues, Alpha);
            forecastBottomLineAValue = calculations.getForecastValue(listOfBottomLineAValues, Alpha);
            listOfMValues = calculations.calculateMValues(elevatorTable);
            listOfAValues = calculations.calculateAValuesForChart(elevatorTable, listOfMValues);
            listOfMValues.Remove(listOfMValues.Last());
            listOfAValues.Remove(listOfAValues.Last());
            forecastMValue = calculations.getForecastValue(listOfMValues, Alpha);
            forecastAValue = calculations.getForecastValue(listOfAValues, Alpha);
        }


    }
}
