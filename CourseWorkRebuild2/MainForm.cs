using CourseWorkRebuild;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkRebuild2
{
    public partial class MainForm : Form
    {
        private List<String> values = new List<String>();
        private List<NewProjectForm> openForms = new List<NewProjectForm>();
        private DataTable dataTable = new DataTable();
        private System.Data.SQLite.SQLiteConnection sqlConnection;
        private Repository repository;
        private int activeForms = 0;
        public MainForm()
        {
            InitializeComponent();
            this.addEpochButton.Enabled = false;
            this.chooseEpochToDelete.Enabled = false;
            this.deleteEpochButton.Enabled = false;
            this.redactorMenu.Enabled = false;
            this.AddNewEpochButton.Enabled = false;
            this.DeleteLastEpoch.Enabled = false;
            this.closeAllButton.Enabled = false;
            this.closeButton.Enabled = false;
            this.saveAsButton.Enabled = false;
            this.saveButton.Enabled = false;
            this.saveCopyButton.Enabled = false;
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
                this.AddNewEpochButton.Enabled = true;
                this.deleteEpochButton.Enabled = true;
                this.DeleteLastEpoch.Enabled = true;
                this.redactorMenu.Enabled = true;
                this.addEpochButton.Enabled = true;
                this.chooseEpochToDelete.Enabled = true;
                this.closeButton.Enabled = true;
                this.saveAsButton.Enabled = true;
                this.closeAllButton.Enabled = true;
                this.saveCopyButton.Enabled = true;
                this.saveButton.Enabled = true;
            }
            else
            {
                elevatorTable.Rows.Clear();
                elevatorTable.Columns.Clear();
                this.AddNewEpochButton.Enabled = false;
                this.DeleteLastEpoch.Enabled = false;
                this.redactorMenu.Enabled = false;
                this.addEpochButton.Enabled = false;
                this.chooseEpochToDelete.Enabled = false;
                this.deleteEpochButton.Enabled = false;
            }
            if (values[1] != null & values[1] != "")
            {
                objectPicture.Load(values[1]);
                objectPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                this.closeButton.Enabled = true;
                this.saveAsButton.Enabled = true;
                this.closeAllButton.Enabled = true;
                this.saveCopyButton.Enabled = true;
                this.saveButton.Enabled = true;
            }
            else
            {
                objectPicture.Image = null;
            }
            if (values[2] != null & values[2] != "")
            {
                valueOfTLabel.Text = "T: " + values[2];
                this.closeButton.Enabled = true;
                this.saveAsButton.Enabled = true;
                this.closeAllButton.Enabled = true;
                this.saveCopyButton.Enabled = true;
                this.saveButton.Enabled = true;
            }
            else
            {
                valueOfTLabel.Text = "";
            }
            if (values[3] != null & values[3] != "")
            {
                valueOfALabel.Text = "A: " + values[3];
                this.closeButton.Enabled = true;
                this.saveAsButton.Enabled = true;
                this.closeAllButton.Enabled = true;
                this.saveCopyButton.Enabled = true;
                this.saveButton.Enabled = true;
            }
            else
            {
                valueOfALabel.Text = "";
                this.changeAValue.Enabled = false;
            }
            if (values[4] != null & values[4] != "")
            {
                markCount.Text = "Количество марок: " + values[4];
            }
            else markCount.Text = "";
            if (values[5] != null & values[5] != "")
            {
                buildingCountValue.Text = "Количество объектов: " + values[5];

            }
            else buildingCountValue.Text = "";
            if (values[6] != null & values[6] != "")
            {
                this.Text = values[6] + "              Открыто окон " + activeForms;
                this.closeButton.Enabled = true;
                this.saveAsButton.Enabled = true;
                this.closeAllButton.Enabled = true;
                this.saveCopyButton.Enabled = true;
                this.saveButton.Enabled = true;
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
                openForms.Add(newProjectForm);
                newProjectForm.Show();
                activeForms++;
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
            if (activeForms > 0)
            {
                NewProjectForm newProjectForm = new NewProjectForm();
                openForms.Add(newProjectForm);
                newProjectForm.SetParameter(1);
                newProjectForm.Show();
                activeForms++;
            }
            else
            {
                OpenProject openProject = new OpenProject();
                values = openProject.UnzipRar();
                reDrawMainForm();
                activeForms++;
            }
           
        }

        private void closeAllButton_Click(object sender, EventArgs e)
        {
            for (int value = 0; value < values.Count; value++)
            {
                values[value] = "";
            }
            activeForms = 0;
            foreach (NewProjectForm form in openForms)
            {
                form.Close();
            }
            reDrawMainForm();
        }
        private void closeButton_Click(object sender, EventArgs e)
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infoAboutSystem_Click(object sender, EventArgs e)
        {
            SystemInfo systemInfo = new SystemInfo();
            systemInfo.ShowDialog();
        }
        private void savePackage(List<String> filePaths, String packagePath)
        {
            // Create a new ZIP archive for the package
            using (ZipArchive archive = ZipFile.Open(packagePath, ZipArchiveMode.Create))
            {
                
                // Add each file to the archive
                foreach (String filePath in filePaths)
                {
                    archive.CreateEntryFromFile(filePath, Path.GetFileName(filePath));
                }
            }
        }

        private void saveAsZipArchieve_Click(object sender, EventArgs e)
        {
            List<String> filesToSave = new List<String>();
            if (values[0] != null & values[0] != "")
            {
                filesToSave.Add(values[0]); // save DB
            }
            if (values[1] != null & values[1] != "")
            {
                filesToSave.Add(values[1]); // save png
            }
            if (values[7] != null & values[7] != "")
            {
                filesToSave.Add(values[7]); // save txt
            }
            repository.closeSQLConnection();
            closeButton_Click(sender, e);
            sqlConnection.Close();
            savePackage(filesToSave, "SaveProjects\\newProject.zip");
        }

        private void saveAsRarArchive_Click(object sender, EventArgs e)
        {
            List<String> filesToSave = new List<String>();
            if (values[0] != null & values[0] != "")
            {
                filesToSave.Add(values[0]); // save DB
            }
            if (values[1] != null & values[1] != "")
            {
                filesToSave.Add(values[1]); // save png
            }
            if (values[7] != null & values[7] != "")
            {
                filesToSave.Add(values[7]); // save txt
            }
            repository.closeSQLConnection();
            closeButton_Click(sender, e);
            sqlConnection.Close();
            savePackage(filesToSave, "SaveProjects\\newProject.rar");
        }

        private void saveAsNewFolder_Click(object sender, EventArgs e)
        {
            List<String> filesToSave = new List<String>();
            if (values[0] != null & values[0] != "")
            {
                filesToSave.Add(values[0]); // save DB
            }
            if (values[1] != null & values[1] != "")
            {
                filesToSave.Add(values[1]); // save png
            }
            if (values[7] != null & values[7] != "")
            {
                filesToSave.Add(values[7]); // save txt
            }
            repository.closeSQLConnection();
            closeButton_Click(sender, e);
            sqlConnection.Close();
            Directory.CreateDirectory("SaveProjects\\newProject");
            File.Copy(filesToSave[0], "newProject1");
            File.Copy(filesToSave[1], "newProject2");
            File.Copy(filesToSave[2], "newProject3");
        }

        private void newBlocksCount_Enter(object sender, EventArgs e)
        {
            values[5] = this.newBlocksCount.Text;
            reDrawMainForm();
        }

        private void newAValue_Enter(object sender, EventArgs e)
        {
            values[3] = this.newAValue.Text;
            reDrawMainForm();
        }

        private void newTValue_Enter(object sender, EventArgs e)
        {
            values[2] = this.newTValue.Text;
            reDrawMainForm();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save save = new Save();
            save.SaveTxtFile(values[7], Convert.ToDouble(values[2]), Convert.ToInt32(values[5]), Convert.ToInt32(values[4]));
        }
    }
}
