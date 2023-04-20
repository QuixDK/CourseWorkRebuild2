using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWorkRebuild2.Helpers
{
    internal class ChartUserSettings
    {

        public void SetChartType(Chart chart, System.Windows.Forms.ComboBox comboBox)
        {
            if (chart.Series.Count > 0)
            {
                foreach (Series serie in chart.Series)
                {
                    if (comboBox.SelectedItem.Equals("Линия"))
                    {
                        serie.ChartType = SeriesChartType.Line;
                    }
                    else if (comboBox.SelectedItem.Equals("Сплайн"))
                    {
                        serie.ChartType = SeriesChartType.Spline;
                    }
                    else serie.ChartType = SeriesChartType.Point;
                }
            }
        }

        public void SetChartMarkerSize(Chart chart, System.Windows.Forms.ComboBox comboBox)
        {
            if (chart.Series.Count > 0)
            {
                foreach (Series serie in chart.Series)
                {
                    if (comboBox.SelectedItem.Equals("По умолчанию"))
                    {
                        serie.MarkerSize = 6;
                    }
                    else serie.MarkerSize = Convert.ToInt32(comboBox.SelectedItem);
                }
            }
        }

        public void SetChartMarkerType(Chart chart, System.Windows.Forms.ComboBox comboBox)
        {
            if (chart.Series.Count > 0)
            {
                foreach (Series serie in chart.Series)
                {
                    if (comboBox.SelectedItem.Equals("Круг"))
                    {
                        serie.MarkerStyle = MarkerStyle.Circle;
                    }
                    else if (comboBox.SelectedItem.Equals("Квадрат"))
                    {
                        serie.MarkerStyle = MarkerStyle.Square;
                    }
                    else serie.MarkerStyle = MarkerStyle.Triangle;
                }
            }
        }
        public void SetChartLabelsOnMarks(Chart chart, CheckBox checkBox)
        {
            if (chart.Series.Count > 0)
            {
                foreach (Series serie in chart.Series)
                {
                    if (checkBox.Checked)
                    {
                        serie.IsValueShownAsLabel = true;
                    }
                    else serie.IsValueShownAsLabel = false;
                }
            }
        }
    }
}
