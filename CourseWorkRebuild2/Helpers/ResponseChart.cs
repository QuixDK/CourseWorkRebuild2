using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CourseWorkRebuild2
{
    public partial class ResponseChart : Form
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
        private int decompositionLevel = 0;
        private List<String> mark;
        public ResponseChart(DataGridView elevatorTable, DataTable dataTable, List<string> values, int decompositionLevel)
        {
            InitializeComponent();
            this.elevatorTable = elevatorTable;
            this.dataTable = dataTable;
            this.values = values;
            this.decompositionLevel = decompositionLevel;
        }
        public ResponseChart(DataGridView elevatorTable, DataTable dataTable, List<string> values, int decompositionLevel, List<String> mark)
        {
            InitializeComponent();
            this.elevatorTable = elevatorTable;
            this.dataTable = dataTable;
            this.values = values;
            this.decompositionLevel = decompositionLevel;
            this.mark = mark;
        }
        private void forecastResponseFunctionSelectBox_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Прогнозное значение";
            if (functionDiagrams.Series.IndexOf(serieName) != -1) chartDiagramService.RemoveLine(functionDiagrams, serieName);
            else chartDiagramService.AddForecastValue(serieName, forecastMValue, forecastAValue, functionDiagrams);
        }
        private void responseFunctionSelectBox_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Функция отклика";
            if (functionDiagrams.Series.IndexOf(serieName) != -1) chartDiagramService.RemoveLine(functionDiagrams, serieName);
            else chartDiagramService.AddMALine(listOfMValues, listOfAValues, functionDiagrams, serieName);
        }

        private void bottomLineSelectBox_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Нижняя граница";
            if (functionDiagrams.Series.IndexOf(serieName) != -1) chartDiagramService.RemoveLine(functionDiagrams, serieName);
            else chartDiagramService.AddMALine(listOfBottomLineMValues, listOfBottomLineAValues, functionDiagrams, serieName);
        }
        private void forecastBottomValues_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Прогнозное значение для нижней границы";
            if (functionDiagrams.Series.IndexOf(serieName) != -1) chartDiagramService.RemoveLine(functionDiagrams, serieName);
            else chartDiagramService.AddForecastValue(serieName, forecastBottomLineMValue, forecastBottomLineAValue, functionDiagrams);
        }
        private void forecastTopValues_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Прогнозное значение для верхней границы";
            if (functionDiagrams.Series.IndexOf(serieName) != -1) chartDiagramService.RemoveLine(functionDiagrams, serieName);
            else chartDiagramService.AddForecastValue(serieName, forecastTopLineMValue, forecastTopLineAValue, functionDiagrams);
        }

        private void topLineSelectBox_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Верхняя граница";
            if (functionDiagrams.Series.IndexOf(serieName) != -1) chartDiagramService.RemoveLine(functionDiagrams, serieName);
            else chartDiagramService.AddMALine(listOfTopLineMValues, listOfTopLineAValues, functionDiagrams, serieName);
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            if (values.Count == 0)
            {
                return;
            }
            if (decompositionLevel == 1)
            {
                Double T = Convert.ToDouble(values[2]);
                Double Alpha = Convert.ToDouble(values[3]);
                DataGridView bottomLineTable = calculations.CalculateBottomOrTopLineTable(dataTable, T, elevatorTable, "-");
                DataGridView topLineTable = calculations.CalculateBottomOrTopLineTable(dataTable, T, elevatorTable, "+");
                listOfBottomLineMValues = calculations.CalculateMValues(bottomLineTable);
                listOfBottomLineAValues = calculations.CalculateAValues(bottomLineTable, listOfBottomLineMValues);
                listOfTopLineMValues = calculations.CalculateMValues(topLineTable);
                listOfTopLineAValues = calculations.CalculateAValues(topLineTable, listOfTopLineMValues);
                forecastTopLineMValue = calculations.GetForecastValue(listOfTopLineMValues, Alpha);
                forecastBottomLineMValue = calculations.GetForecastValue(listOfBottomLineMValues, Alpha);
                forecastTopLineAValue = calculations.GetForecastValue(listOfTopLineAValues, Alpha);
                forecastBottomLineAValue = calculations.GetForecastValue(listOfBottomLineAValues, Alpha);
                listOfMValues = calculations.CalculateMValues(elevatorTable);
                listOfAValues = calculations.CalculateAValues(elevatorTable, listOfMValues);
                forecastMValue = calculations.GetForecastValue(listOfMValues, Alpha);
                forecastAValue = calculations.GetForecastValue(listOfAValues, Alpha);
            }
            else if (decompositionLevel == 2)
            {
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
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
