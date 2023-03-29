﻿using CourseWorkRebuild2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class ChartDiagramService
{
    Calculations calculations = new Calculations();

    public System.Windows.Forms.DataVisualization.Charting.Chart addLine(List<Double> listOfMValues, List<Double> listOfAValues, System.Windows.Forms.DataVisualization.Charting.Chart functionDiagrams, String serieName, ListBox listBox, ListBox listBox2)
    {
        functionDiagrams.ChartAreas[0].AxisX.Title = "M";
        functionDiagrams.ChartAreas[0].AxisY.Title = "Alpha";
        functionDiagrams.ChartAreas[0].AxisX.Maximum = listOfMValues.Max();
        functionDiagrams.ChartAreas[0].AxisX.Minimum = listOfMValues.Min();
        functionDiagrams.ChartAreas[0].AxisY.Maximum = listOfAValues.Max();
        functionDiagrams.ChartAreas[0].AxisY.Minimum = listOfAValues.Min();

        functionDiagrams.Series.Add(serieName);
        functionDiagrams.Series[serieName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        for (int i = 0; i < listOfMValues.Count; i++)
        {
            functionDiagrams.Series[serieName].Points.AddXY(listOfMValues[i], listOfAValues[i]);
        }

        addValuesToListBox(listOfMValues, listOfAValues, listBox, listBox2);

        return functionDiagrams;
    }

    public System.Windows.Forms.DataVisualization.Charting.Chart addforecastFunction(String serieName, List<Double> listOfMValues, List<Double> listOfAlphaValues, System.Windows.Forms.DataVisualization.Charting.Chart functionDiagrams, ListBox listBox, ListBox listBox2)
    {

        functionDiagrams.Series.Add(serieName);
        functionDiagrams.Series[serieName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
        functionDiagrams.Series[serieName].Points.AddXY(listOfMValues.Last(), listOfAlphaValues.Last());

        addValuesToListBox(listOfMValues, listOfAlphaValues, listBox, listBox2);

        return functionDiagrams;
    }
    public System.Windows.Forms.DataVisualization.Charting.Chart removeLine(System.Windows.Forms.DataVisualization.Charting.Chart functionDiagrams, String serieName)
    {
        functionDiagrams.Series[serieName].Points.Clear();
        functionDiagrams.Series.Remove(functionDiagrams.Series[serieName]);
        return functionDiagrams;
    }

    private void addValuesToListBox(List<Double> listOfMValues, List<Double> listOfAValues, ListBox listBox, ListBox listBox2)
    {
        listBox.Items.Clear();
        listBox2.Items.Clear();
        foreach (Double value in listOfMValues)
        {
            listBox.Items.Add(value);
        }
        foreach (Double value in listOfAValues)
        {
            listBox2.Items.Add(value);
        }
    }

}