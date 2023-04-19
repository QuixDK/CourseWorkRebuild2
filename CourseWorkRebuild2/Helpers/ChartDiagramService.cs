using CourseWorkRebuild2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Drawing;

public class ChartDiagramService
{
    Calculations calculations = new Calculations();

    public Chart AddXYLine(String serieName, List<Double> listOfXValues, List<Double> listOfYValues, Chart chart)
    {
        chart.ChartAreas[0].AxisX.Title = "Эпоха";
        chart.ChartAreas[0].AxisY.Title = "Значение";
        chart.ChartAreas[0].AxisY.Maximum = listOfYValues.Max();
        chart.ChartAreas[0].AxisY.Minimum = listOfYValues.Min();
        chart.Series.Add(serieName);
        chart.Series[serieName].MarkerStyle = MarkerStyle.Circle; // стиль маркера точки данных
        chart.Series[serieName].MarkerSize = 6;
        chart.Series[serieName].MarkerColor = chart.Series[serieName].Color;
        chart.Series[serieName].ChartType = SeriesChartType.Line;
        chart.Series[serieName].ToolTip = "X = #VALX, Y = #VALY";

        for (int i = 0; i < listOfYValues.Count; i++)
        {
            chart.Series[serieName].Points.AddXY(listOfXValues[i], listOfYValues[i]);

        }
        return chart;
    }

    public Chart AddMALine(List<Double> listOfMValues, List<Double> listOfAValues, Chart functionDiagrams, String serieName)
    {
        functionDiagrams.ChartAreas[0].AxisX.Title = "M";
        functionDiagrams.ChartAreas[0].AxisY.Title = "Alpha";
        functionDiagrams.Series.Add(serieName);
        functionDiagrams.Series[serieName].MarkerStyle = MarkerStyle.Circle; // стиль маркера точки данных
        functionDiagrams.Series[serieName].MarkerSize = 10;
        functionDiagrams.Series[serieName].MarkerColor = functionDiagrams.Series[serieName].Color;
        functionDiagrams.Series[serieName].ChartType = SeriesChartType.Line;
        functionDiagrams.Series[serieName].ToolTip = "X = #VALX, Y = #VALY";
        for (int i = 0; i < listOfMValues.Count; i++)
        {
            
            functionDiagrams.Series[serieName].Points.AddXY(listOfMValues[i], listOfAValues[i]);
            
        }

        return functionDiagrams;
    }

    public Chart AddForecastValue(String serieName, List<Double> listOfXValues, List<Double> listOfYValues, Chart functionDiagrams)
    {

        functionDiagrams.Series.Add(serieName);
        functionDiagrams.Series[serieName].ChartType = SeriesChartType.Point;
        functionDiagrams.Series[serieName].MarkerStyle = MarkerStyle.Circle;
        functionDiagrams.Series[serieName].MarkerSize = 10;
        functionDiagrams.Series[serieName].Points.AddXY(listOfXValues.Last(), listOfYValues.Last());
        functionDiagrams.Series[serieName].ToolTip = "X = #VALX, Y = #VALY";

        return functionDiagrams;
    }
    public Chart RemoveLine(Chart functionDiagrams, String serieName)
    {
        functionDiagrams.Series[serieName].Points.Clear();
        functionDiagrams.Series.Remove(functionDiagrams.Series[serieName]);
        return functionDiagrams;
    }

}