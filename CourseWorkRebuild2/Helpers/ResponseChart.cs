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
        private DataGridView elevatorTable;
        Calculations calculations = new Calculations();
        private DataTable dataTable;
        private List<String> data;
        private int decompositionLevel = 0;
        private List<String> mark;
        private List<List<Double>> values;
        public ResponseChart(DataGridView elevatorTable, DataTable dataTable, List<string> data, List<List<Double>> values)
        {
            InitializeComponent();
            this.elevatorTable = elevatorTable;
            this.dataTable = dataTable;
            this.data = data;
            this.values = values;
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
            
        }
    }
}
