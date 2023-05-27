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
        private List<List<Double>> values;
        private DataGridView elevatorTable;

        public ResponseChart(List<List<Double>> values, DataGridView elevatorTable)
        {
            InitializeComponent();
            this.values = values;
            this.elevatorTable = elevatorTable;
        }

        private void forecastResponseFunctionSelectBox_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Прогнозное значение";
            if (functionDiagrams.Series.IndexOf(serieName) != -1) chartDiagramService.RemoveLine(functionDiagrams, serieName);
            else chartDiagramService.AddForecastValue(serieName, values[3], values[9], functionDiagrams, elevatorTable);
        }
        private void responseFunctionSelectBox_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Функция отклика";
            if (functionDiagrams.Series.IndexOf(serieName) != -1) chartDiagramService.RemoveLine(functionDiagrams, serieName);
            else chartDiagramService.AddMALine(values[2], values[8], functionDiagrams, serieName, elevatorTable);
        }

        private void bottomLineSelectBox_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Нижняя граница";
            if (functionDiagrams.Series.IndexOf(serieName) != -1) chartDiagramService.RemoveLine(functionDiagrams, serieName);
            else chartDiagramService.AddMALine(values[0], values[6], functionDiagrams, serieName, elevatorTable);
        }
        private void forecastBottomValues_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Прогнозное значение для нижней границы";
            if (functionDiagrams.Series.IndexOf(serieName) != -1) chartDiagramService.RemoveLine(functionDiagrams, serieName);
            else chartDiagramService.AddForecastValue(serieName, values[1], values[7], functionDiagrams, elevatorTable);
        }
        private void forecastTopValues_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Прогнозное значение для верхней границы";
            if (functionDiagrams.Series.IndexOf(serieName) != -1) chartDiagramService.RemoveLine(functionDiagrams, serieName);
            else chartDiagramService.AddForecastValue(serieName, values[5], values[11], functionDiagrams, elevatorTable);
        }

        private void topLineSelectBox_CheckedChanged(object sender, EventArgs e)
        {
            String serieName = "Верхняя граница";
            if (functionDiagrams.Series.IndexOf(serieName) != -1) chartDiagramService.RemoveLine(functionDiagrams, serieName);
            else chartDiagramService.AddMALine(values[4], values[10], functionDiagrams, serieName, elevatorTable);
        }
    }
}
