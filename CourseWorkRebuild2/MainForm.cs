using CourseWorkRebuild;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkRebuild2
{
    public partial class MainForm : Form
    {
        private List<String> values = new List<String>();
        private DataTable dataTable = new DataTable();
        private System.Data.SQLite.SQLiteConnection sqlConnection;
        private Repository repository;
        private int activeForms = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void reDrawMainForm()
        {

            
            if (values[0] != null & values[0] != "")
            {
                epochCountBox.Items.Clear();
                repository = new Repository(values[0]);
                sqlConnection = repository.GetDbConnection();
                elevatorTable = repository.ShowTable(dataTable, elevatorTable);
                for (int row = 0; row < elevatorTable.Rows.Count-1; row++)
                {
                    epochCountBox.Items.Add(elevatorTable.Rows[row].Cells[0].Value);
                }
                epochCountBox.SelectedIndex = 0;
            }
            else
            {
                elevatorTable.Rows.Clear();
                elevatorTable.Columns.Clear();
            }
            if (values[1] != null & values[1] != "")
            {
                objectPicture.Load(values[1]);
                objectPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                
            }
            else
            {
                objectPicture.Image = null;
            }
            if (values[2] != null & values[2] != "")
            {
                valueOfTLabel.Text = "T: " + values[2];

            }
            else
            {
                valueOfTLabel.Text = "";
            }
            if (values[3] != null & values[3] != "")
            {
                valueOfALabel.Text = "A: " + values[3];

            }
            else
            {
                valueOfALabel.Text = "";
            }
            if (values[6] != null & values[6] != "")
            {
                this.Text = values[6];
            }
            else { this.Text = ""; }
            
            
        }


        private void addNewRow_Click(object sender, EventArgs e)
        {
            elevatorTable.Rows.Add();
            Double delta = 0;
            Double averageDelta = 0;
            Double newCellValue = 0;
            int newRow = elevatorTable.RowCount-1;
            Random random = new Random();
            elevatorTable.Rows[newRow - 1].Cells[0].Value = Convert.ToInt32(elevatorTable.Rows[newRow - 2].Cells[0].Value) + 1;
            repository.AddNewRow(Convert.ToDouble(elevatorTable.Rows[newRow - 1].Cells[0].Value));
            for (int i = 1; i < elevatorTable.Columns.Count; i++)
            {

                for (int j = 0; j < elevatorTable.Rows.Count - 1; j++)
                {
                    if (Convert.ToDouble(elevatorTable.Rows[j + 1].Cells[i].Value) != 0)
                    {
                        delta = Math.Abs(Convert.ToDouble(elevatorTable.Rows[j].Cells[i].Value) - Convert.ToDouble(elevatorTable.Rows[j + 1].Cells[i].Value));
                    }

                    averageDelta += delta;
                    delta = 0;
                }

                averageDelta /= elevatorTable.Rows.Count;
                newCellValue = random.NextDouble() * (averageDelta - (-averageDelta)) + averageDelta;
                elevatorTable.Rows[newRow - 1].Cells[i].Value = Math.Round(newCellValue + Convert.ToDouble(elevatorTable.Rows[newRow - 2].Cells[i].Value), 4);
                repository.AddNewValuesInRow(i, newRow - 1, Convert.ToDouble(elevatorTable.Rows[newRow - 1].Cells[i].Value));
                averageDelta = 0;
            }
            reDrawMainForm();

        }

        private void elevatorTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int currentColumn = e.ColumnIndex;
            int currentRow = e.RowIndex;
            Double newValue = Convert.ToDouble(elevatorTable.Rows[currentRow].Cells[currentColumn].Value);
            elevatorTable = repository.UpdateValue(elevatorTable, currentColumn, currentRow, newValue);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (activeForms > 0)
            {
                NewProjectForm newProjectForm = new NewProjectForm();
                newProjectForm.ShowDialog();
            }
            else
            {
                OpenProject openProject = new OpenProject();
                values = openProject.Open();
                reDrawMainForm();
                activeForms++;
            }
            
        }

        private void openRarButton_Click(object sender, EventArgs e)
        {
            OpenProject openProject = new OpenProject();
            values = openProject.UnzipRar();
            reDrawMainForm();
        }

        private void closeAllButton_Click(object sender, EventArgs e)
        {
            for (int value = 0; value < values.Count; value++)
            {
                values[value] = "";
            }
            activeForms--;
            reDrawMainForm();
        }

        private void deleteEpochButton_Click(object sender, EventArgs e)
        {
            if (epochCountBox.SelectedIndex != null)
            {
                repository.DeleteRow(epochCountBox.Text);
                elevatorTable.Rows.RemoveAt(epochCountBox.SelectedIndex -1 );
            }
            reDrawMainForm();
        }

        private void deleteLastEpoch_Click(object sender, EventArgs e)
        {  
            repository.DeleteRow((elevatorTable.Rows.Count - 2).ToString());
            elevatorTable.Rows.RemoveAt(elevatorTable.Rows.Count-2);
        }

        private void changeTValueButton_Click(object sender, EventArgs e)
        {
            ChangeValueForm changeValueForm = new ChangeValueForm();
            changeValueForm.ShowDialog();
        }

        private void changeAValueButton_Click(object sender, EventArgs e)
        {
            ChangeValueForm changeValueForm = new ChangeValueForm();
            changeValueForm.ShowDialog();
        }
    }
}
