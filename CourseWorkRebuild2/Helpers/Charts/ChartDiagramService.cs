using CourseWorkRebuild2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Drawing;

public class ChartDiagramService
{

    public Chart AddXYLine(String serieName, List<Double> listOfXValues, List<Double> listOfYValues, Chart chart, DataGridView elevatorTable)
    {


        chart.ChartAreas[0].AxisX.Title = "Эпоха";
        
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
            chart.Series[serieName].Points[i].Label = listOfXValues[i].ToString() ;

        }
        return chart;
    }

    public Chart AddMALine(List<Double> listOfMValues, List<Double> listOfAValues, Chart chart, String serieName, DataGridView elevatorTable)
    {
        chart.ChartAreas[0].AxisX.Title = "M, м";
        chart.ChartAreas[0].AxisY.Title = "Alpha, °";
        chart.ChartAreas[0].AxisY.IsStartedFromZero = false;
        chart.Series.Add(serieName);
        chart.Series[serieName].MarkerStyle = MarkerStyle.Circle; // стиль маркера точки данных
        chart.Series[serieName].MarkerSize = 10;
        chart.Series[serieName].MarkerColor = chart.Series[serieName].Color;
        chart.Series[serieName].ChartType = SeriesChartType.Line;
        chart.Series[serieName].ToolTip = "X = #VALX, Y = #VALY";
        
        for (int i = 0; i < listOfMValues.Count; i++)
        {
            
            chart.Series[serieName].Points.AddXY(listOfMValues[i], listOfAValues[i]);
            chart.Series[serieName].Points[i].Label = elevatorTable.Rows[i].Cells[0].Value.ToString();
        }

        return chart;
    }

    public Chart AddForecastValue(String serieName, List<Double> listOfXValues, List<Double> listOfYValues, Chart chart, DataGridView elevatorTable)
    {

        chart.Series.Add(serieName);
        chart.ChartAreas[0].AxisY.IsStartedFromZero = false;
        chart.Series[serieName].ChartType = SeriesChartType.Point;
        chart.Series[serieName].MarkerStyle = MarkerStyle.Circle;
        chart.Series[serieName].MarkerSize = 10;
        chart.Series[serieName].Points.AddXY(listOfXValues.Last(), listOfYValues.Last());
        chart.Series[serieName].Points.Last().Label = (Convert.ToInt32(elevatorTable.Rows[elevatorTable.RowCount-2].Cells[0].Value) + 1).ToString();
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