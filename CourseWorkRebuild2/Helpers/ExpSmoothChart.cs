using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkRebuild2.Helpers
{
    public partial class ExpSmoothChart : Form
    {
        private ChartDiagramService chartDiagramService = new ChartDiagramService();
        private Calculations calculations = new Calculations();
        private List<Double> MValues = new List<Double>();
        private List<Double> AValues = new List<Double>();
        private List<Double> smoothMValues = new List<Double>();
        private List<Double> smoothAValues = new List<Double>();
        private List<Double> epochList = new List<Double>();
        private DataGridView elevatorTable;
        private DataTable dataTable;
        private List<String> values;
        private List<String> mark;
        private int a = 0;
        
        public ExpSmoothChart(DataGridView elevatorTable, DataTable dataTable, List<string> values, int a)
        {
            InitializeComponent();
            this.elevatorTable = elevatorTable;
            this.dataTable = dataTable;
            this.values = values;
            this.a = a;
        }
        public ExpSmoothChart(DataGridView elevatorTable, DataTable dataTable, List<string> values, int a, List<String> mark)
        {
            InitializeComponent();
            this.elevatorTable = elevatorTable;
            this.dataTable = dataTable;
            this.values = values;
            this.a = a;
            this.mark = mark;
        }

        private void MChart_CheckedChanged(object sender, EventArgs e)
        {

            String serieName2 = "Длина вектора М (сглаженное)";
            if (expSmooth.Series.IndexOf(serieName2) != -1) chartDiagramService.RemoveLine(expSmooth, serieName2);
            else chartDiagramService.AddXYLine(serieName2, epochList, smoothMValues, expSmooth);

            String serieName = "Длина вектора М (реальное)";
            if (expSmooth.Series.IndexOf(serieName) != -1) chartDiagramService.RemoveLine(expSmooth, serieName);
            else chartDiagramService.AddXYLine(serieName, epochList, MValues, expSmooth);

            applySettings(sender, e);
        }

        private void alphaChart_CheckedChanged(object sender, EventArgs e)
        {

            String serieName2 = "Угол а (сглаженное)";
            if (expSmooth.Series.IndexOf(serieName2) != -1) chartDiagramService.RemoveLine(expSmooth, serieName2);
            else chartDiagramService.AddXYLine(serieName2, epochList, smoothAValues, expSmooth);

            String serieName = "Угол а (реальное)";
            if (expSmooth.Series.IndexOf(serieName) != -1) chartDiagramService.RemoveLine(expSmooth, serieName);
            else chartDiagramService.AddXYLine(serieName, epochList, AValues, expSmooth);     

            applySettings(sender, e);
        }

        private void ExpSmoothChart_Load(object sender, EventArgs e)
        {
            setDefaultValuesInSettings();
            if (values.Count == 0)
            {
                return;
            }
            int forecastIndex = 0;
            for (int i = 0; i < elevatorTable.Rows.Count-1; i++)
            {
                epochList.Add(Convert.ToInt32(elevatorTable.Rows[i].Cells[0].Value));
                forecastIndex = i;
            }
            epochList.Add(Convert.ToInt32(elevatorTable.Rows[forecastIndex].Cells[0].Value) + 1);
            if (a == 1)
            {
                Double T = Convert.ToDouble(values[2]);
                Double Alpha = Convert.ToDouble(values[3]);
                MValues = calculations.CalculateMValues(elevatorTable);
                AValues = calculations.CalculateAValues(elevatorTable, MValues);
                smoothMValues = calculations.GetForecastValue(MValues, Alpha);
                smoothAValues = calculations.GetForecastValue(AValues, Alpha);
            }
            else if (a == 2)
            {
                Double T = Convert.ToDouble(values[2]);
                Double Alpha = Convert.ToDouble(values[3]);
                MValues = calculations.CalculateMValues(elevatorTable, mark);
                AValues = calculations.CalculateAValues(elevatorTable, MValues, mark);
                smoothMValues = calculations.GetForecastValue(MValues, Alpha);
                smoothAValues = calculations.GetForecastValue(AValues, Alpha);
            }
        }

        private void setDefaultValuesInSettings()
        {
            chartTypeComboBox.Items.Clear();
            chartTypeComboBox.Items.Add("Линия");
            chartTypeComboBox.SelectedItem = "Линия";
            chartTypeComboBox.Items.Add("Сплайн");
            chartTypeComboBox.Items.Add("Точечная");
            
            markerSizeComboBox.Items.Clear();
            markerSizeComboBox.Items.Add("По умолчанию");
            markerSizeComboBox.SelectedItem = "По умолчанию";
            markerSizeComboBox.Items.Add("6");
            markerSizeComboBox.Items.Add("8");
            markerSizeComboBox.Items.Add("9");
            markerSizeComboBox.Items.Add("10");
            markerSizeComboBox.Items.Add("11");
            markerSizeComboBox.Items.Add("12");
            markerSizeComboBox.Items.Add("14");
            markerSizeComboBox.Items.Add("16");
            markerSizeComboBox.Items.Add("18");
            markerSizeComboBox.Items.Add("20");

            markerTypeComboBox.Items.Clear();
            markerTypeComboBox.Items.Add("Круг");
            markerTypeComboBox.SelectedItem = "Круг";
            markerTypeComboBox.Items.Add("Квадрат");
            markerTypeComboBox.Items.Add("Треугольник");
        }

        private void chartTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChartUserSettings chartUserSettings = new ChartUserSettings();
            chartUserSettings.SetChartType(expSmooth, chartTypeComboBox);
        }

        private void markerSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChartUserSettings chartUserSettings = new ChartUserSettings();
            chartUserSettings.SetChartMarkerSize(expSmooth, markerSizeComboBox);
        }

        private void markerTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChartUserSettings chartUserSettings = new ChartUserSettings();
            chartUserSettings.SetChartMarkerType(expSmooth, markerTypeComboBox);
        }

        private void labelsOnMarksCheckBox_Click(object sender, EventArgs e)
        {
            ChartUserSettings chartUserSettings = new ChartUserSettings();
            chartUserSettings.SetChartLabelsOnMarks(expSmooth, labelsOnMarksCheckBox);
        }
        private void applySettings(object sender, EventArgs e)
        {
            chartTypeComboBox_SelectedIndexChanged(sender, e);
            markerSizeComboBox_SelectedIndexChanged(sender, e);
            markerTypeComboBox_SelectedIndexChanged(sender, e);
            labelsOnMarksCheckBox_Click(sender, e);
        }

 
    }
}
