using CourseWorkRebuild;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CourseWorkRebuild2
{
    public partial class NewProjectForm : Form
    {
        private List<String> values = new List<String>();
        private Repository repository;
        private SQLiteConnection sqlConnection;
        private DataTable dataTable = new DataTable();
        private Calculations calculations = new Calculations();
        private int a = 0;
        private int epochCount = 0;
        public NewProjectForm()
        {
            InitializeComponent();
        }

        public void SetParameter(int a)
        {
            this.a = a;
        }
        private void initEpochCount()
        {
            if (epochCount == 0)
            {
                epochCount = Convert.ToInt32(elevatorTable.Rows[(elevatorTable.Rows.Count - 2)].Cells[0].Value) + 1;
            }
        }

        private void reDrawCurrentForm()
        {

            if (values.Count == 0)
            {
                return;
            }
            reDrawElevatorTable();
            initEpochCount();
            if (values[1] != null & values[1] != "")
            {
                objectPicture.Load(values[1]);
                objectPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                this.closeButton.Enabled = true;
            }
            else
            {
                objectPicture.Image = null;
            }
            if (values[2] != null & values[2] != "")
            {
                valueOfTLabel.Text = "T: " + values[2];
                this.changeTValue.Enabled = true;
                this.closeButton.Enabled = true;
            }
            else
            {
                valueOfTLabel.Text = "";
                this.changeTValue.Enabled = false;
            }
            if (values[3] != null & values[3] != "")
            {
                valueOfALabel.Text = "A: " + values[3];
                this.changeAValue.Enabled = true;
                this.closeButton.Enabled = true;
            }
            else
            {
                valueOfALabel.Text = "";
                this.changeAValue.Enabled = false;
            }
            if (values[6] != null & values[6] != "")
            {
                this.Text = values[6];
                this.closeButton.Enabled = true;
            }
            else { this.Text = ""; }
        }

        private void reDrawElevatorTable()
        {
            if (values[0] != null & values[0] != "")
            {
                epochCountBox.Items.Clear();
                repository = new Repository(values[0]);
                sqlConnection = repository.GetDbConnection();
                elevatorTable = repository.ShowTable(dataTable, elevatorTable);
                for (int row = 0; row < elevatorTable.Rows.Count - 1; row++)
                {
                    epochCountBox.Items.Add(elevatorTable.Rows[row].Cells[0].Value);
                }
                epochCountBox.SelectedIndex = 0;
                enableTableButtons();
            }
            else
            {
                elevatorTable.Rows.Clear();
                elevatorTable.Columns.Clear();
                disableTableButtons();
            }
        }

        private void NewProjectForm_Load(object sender, EventArgs e)
        {
            disableStartButtons();
            OpenProject openProject = new OpenProject();
            if (a == 0)
            {
                values = openProject.Open();
            }
            if (a == 1)
            {
                values = openProject.UnzipRar();
            }
            reDrawCurrentForm();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Перед закрытием сохранить
            for (int value = 0; value < values.Count; value++)
            {
                values[value] = "";
            }
            reDrawCurrentForm();
        }

        private void openProjectButton_Click(object sender, EventArgs e)
        {
            OpenProject openProject = new OpenProject();
            List<String> newValues = new List<String>();
            newValues = openProject.Open();
            foreach (String value in newValues)
            {
                if (!value.Equals(""))
                {
                    values = newValues;
                    reDrawCurrentForm();
                }
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            closeButton_Click(sender, e);
            OpenProject openProject = new OpenProject();
            values = openProject.UnzipRar();

            reDrawCurrentForm();
        }

        private void addNewEpoch_Click(object sender, EventArgs e)
        {
            int newRow = elevatorTable.RowCount - 1;
            elevatorTable.Rows[newRow].Cells[0].Value = epochCount;
            repository.AddNewRow(epochCount);
            calculations.AddNewValuesInRow(elevatorTable, repository, epochCount);
            epochCount++;
            reDrawElevatorTable();
        }
        private void elevatorTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int currentColumn = e.ColumnIndex;
            int currentRow = e.RowIndex;
            Double newValue = Convert.ToDouble(elevatorTable.Rows[currentRow].Cells[currentColumn].Value);
            elevatorTable = repository.UpdateValue(elevatorTable, currentColumn, currentRow, newValue);
        }
        private void deleteEpochButton_Click(object sender, EventArgs e)
        {
            repository.DeleteRow(epochCountBox.Text);
            elevatorTable.Rows.RemoveAt(epochCountBox.SelectedIndex - 1);
            reDrawElevatorTable();
        }

        private void deleteLastEpoch_Click(object sender, EventArgs e)
        {
            string lastRowIndex = elevatorTable.Rows[(elevatorTable.Rows.Count - 2)].Cells[0].Value.ToString();
            repository.DeleteRow(lastRowIndex);
            reDrawElevatorTable();
        }
        private void deleteSelectedRowsButton_Click(object sender, EventArgs e)
        {
            if (elevatorTable.SelectedRows.Count > 0)
            {
                for (int i = 0; i < elevatorTable.SelectedRows.Count; i++)
                {
                    repository.DeleteRow(elevatorTable.Rows[elevatorTable.SelectedRows[i].Index].Cells[0].Value.ToString());
                }
            }
            reDrawElevatorTable();
        }

        private void infoAboutSystem_Click(object sender, EventArgs e)
        {
            SystemInfo systemInfo = new SystemInfo();
            systemInfo.ShowDialog();
        }

        private void OpenChart_Click(object sender, EventArgs e)
        {
            ChartForm chartForm = new ChartForm(elevatorTable, dataTable, values);
            chartForm.Show();
        }

        private void disableStartButtons()
        {
            this.changeTValue.Enabled = false;
            this.changeAValue.Enabled = false;
            this.closeButton.Enabled = false;
            this.saveAsButton.Enabled = false;
            this.saveButton.Enabled = false;
            this.saveCopyButton.Enabled = false;
            disableTableButtons();
        }

        private void enableTableButtons()
        {
            this.AddNewEpochButton.Enabled = true;
            this.DeleteLastEpoch.Enabled = true;
            this.redactorMenu.Enabled = true;
            this.addEpochButton.Enabled = true;
            this.chooseEpochToDelete.Enabled = true;
            this.closeButton.Enabled = true;
            this.deleteSelectedRowsButton.Enabled = true;
            this.deleteEpochButton.Enabled = true;
        }

        private void disableTableButtons()
        {
            this.AddNewEpochButton.Enabled = false;
            this.DeleteLastEpoch.Enabled = false;
            this.redactorMenu.Enabled = false;
            this.addEpochButton.Enabled = false;
            this.chooseEpochToDelete.Enabled = false;
            this.deleteSelectedRowsButton.Enabled = false;
            this.deleteEpochButton.Enabled = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
