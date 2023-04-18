using CourseWorkRebuild2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

public class ChartDiagramService
{
    Calculations calculations = new Calculations();

    public Chart AddExpSmoothLine(String serieName, List<Int32> listOfXValues, List<Double> listOfYValues, Chart chart)
    {
        chart.ChartAreas[0].AxisX.Title = "Эпоха";
        chart.ChartAreas[0].AxisY.Title = "Значение";
        string serieName2 = serieName + "2";
        chart.Series.Add(serieName2);
        chart.Series.Add(serieName);
        chart.Series[serieName2].ChartType = SeriesChartType.Line;
        chart.Series[serieName2].IsVisibleInLegend = false;
        chart.Series[serieName].ChartType = SeriesChartType.Point;
        chart.Series[serieName].ToolTip = "X = #VALX, Y = #VALY";
        chart.Series[serieName].MarkerSize = 5;
        for (int i = 0; i < listOfYValues.Count; i++)
        {
            chart.Series[serieName2].Points.AddXY(listOfXValues[i], listOfYValues[i]);
            chart.Series[serieName].Points.AddXY(listOfXValues[i], listOfYValues[i]);

        }
        return chart;
    }

    public Chart addLine(List<Double> listOfMValues, List<Double> listOfAValues, Chart functionDiagrams, String serieName)
    {
        functionDiagrams.ChartAreas[0].AxisX.Title = "M";
        functionDiagrams.ChartAreas[0].AxisY.Title = "Alpha";
        string serieName2 = serieName + "2";
        functionDiagrams.Series.Add(serieName2);
        functionDiagrams.Series.Add(serieName);
        functionDiagrams.Series[serieName2].ChartType = SeriesChartType.Line;
        functionDiagrams.Series[serieName2].IsVisibleInLegend = false;
        functionDiagrams.Series[serieName].ChartType = SeriesChartType.Point;
        functionDiagrams.Series[serieName].ToolTip = "X = #VALX, Y = #VALY";
        functionDiagrams.Series[serieName].MarkerSize = 10;
        for (int i = 0; i < listOfMValues.Count; i++)
        {
            functionDiagrams.Series[serieName2].Points.AddXY(listOfMValues[i], listOfAValues[i]);
            functionDiagrams.Series[serieName].Points.AddXY(listOfMValues[i], listOfAValues[i]);
            
        }

        return functionDiagrams;
    }

    public Chart addforecastFunction(String serieName, List<Double> listOfMValues, List<Double> listOfAlphaValues, Chart functionDiagrams)
    {

        functionDiagrams.Series.Add(serieName);
        functionDiagrams.Series[serieName].ChartType = SeriesChartType.Point;
        functionDiagrams.Series[serieName].MarkerSize = 10;
        functionDiagrams.Series[serieName].Points.AddXY(listOfMValues.Last(), listOfAlphaValues.Last());
        functionDiagrams.Series[serieName].ToolTip = "X = #VALX, Y = #VALY";

        return functionDiagrams;
    }
    public Chart removeLine(Chart functionDiagrams, String serieName)
    {

        string serieName2 = serieName + "2";;
        foreach (Series serie in functionDiagrams.Series)
        {
            if (serie.Name == serieName2)
            {
                functionDiagrams.Series[serieName2].Points.Clear();
                functionDiagrams.Series.Remove(functionDiagrams.Series[serieName2]);
                break;
            }
        }
        functionDiagrams.Series[serieName].Points.Clear();
        functionDiagrams.Series.Remove(functionDiagrams.Series[serieName]);
        return functionDiagrams;
    }

}