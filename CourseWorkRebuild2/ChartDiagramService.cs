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
        functionDiagrams.ChartAreas[0].AxisX.Maximum = listOfMValues.Max();
        functionDiagrams.ChartAreas[0].AxisX.Minimum = listOfMValues.Min();
        functionDiagrams.ChartAreas[0].AxisY.Maximum = listOfAValues.Max();
        functionDiagrams.ChartAreas[0].AxisY.Minimum = listOfAValues.Min();

        functionDiagrams.Series.Add(serieName);
        functionDiagrams.Series[serieName].ChartType = SeriesChartType.Line;
        for (int i = 0; i < listOfMValues.Count; i++)
        {
            functionDiagrams.Series[serieName].Points.AddXY(listOfMValues[i], listOfAValues[i]);
        }

        return functionDiagrams;
    }

    public Chart addforecastFunction(String serieName, List<Double> listOfMValues, List<Double> listOfAlphaValues, Chart functionDiagrams)
    {

        functionDiagrams.Series.Add(serieName);
        functionDiagrams.Series[serieName].ChartType = SeriesChartType.Point;
        functionDiagrams.Series[serieName].Points.AddXY(listOfMValues.Last(), listOfAlphaValues.Last());

        return functionDiagrams;
    }
    public Chart removeLine(Chart functionDiagrams, String serieName)
    {
        functionDiagrams.Series[serieName].Points.Clear();
        functionDiagrams.Series.Remove(functionDiagrams.Series[serieName]);
        return functionDiagrams;
    }

}