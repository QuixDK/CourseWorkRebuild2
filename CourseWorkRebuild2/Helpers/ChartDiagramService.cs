using CourseWorkRebuild2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Drawing;

public class ChartDiagramService
{

    public Chart AddXYLine(String serieName, List<Double> listOfXValues, List<Double> listOfYValues, Chart chart)
    {

        chart.ChartAreas[0].AxisX.Title = "Эпоха";
        chart.ChartAreas[0].AxisY.Title = "Значение";
        
        chart.Series.Add(serieName);

        chart.ChartAreas[0].AxisY.IsStartedFromZero = false;
        
        chart.Series[serieName].MarkerStyle = MarkerStyle.Circle;
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

    public Chart AddMALine(List<Double> listOfMValues, List<Double> listOfAValues, Chart chart, String serieName)
    {
        chart.ChartAreas[0].AxisX.Title = "M";
        chart.ChartAreas[0].AxisY.Title = "Alpha";
        chart.Series.Add(serieName);
        chart.Series[serieName].MarkerStyle = MarkerStyle.Circle; // стиль маркера точки данных
        chart.Series[serieName].MarkerSize = 10;
        chart.Series[serieName].MarkerColor = chart.Series[serieName].Color;
        chart.Series[serieName].ChartType = SeriesChartType.Line;
        chart.Series[serieName].ToolTip = "X = #VALX, Y = #VALY";
        
        for (int i = 0; i < listOfMValues.Count; i++)
        {
            
            chart.Series[serieName].Points.AddXY(listOfMValues[i], listOfAValues[i]);
            chart.Series[serieName].Points[i].Label = i.ToString();
        }

        return chart;
    }

    public Chart AddForecastValue(String serieName, List<Double> listOfXValues, List<Double> listOfYValues, Chart chart)
    {

        chart.Series.Add(serieName);
        chart.Series[serieName].ChartType = SeriesChartType.Point;
        chart.Series[serieName].MarkerStyle = MarkerStyle.Circle;
        chart.Series[serieName].MarkerSize = 10;
        chart.Series[serieName].Points.AddXY(listOfXValues.Last(), listOfYValues.Last());
        chart.Series[serieName].ToolTip = "X = #VALX, Y = #VALY";

        return chart;
    }
    public Chart RemoveLine(Chart chart, String serieName)
    {
        chart.Series[serieName].Points.Clear();
        chart.Series.Remove(chart.Series[serieName]);
        return chart;
    }

}