using CourseWorkRebuild2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

public class ChartDiagramService
{
    Calculations calculations = new Calculations();

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