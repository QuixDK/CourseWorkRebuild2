using CourseWorkRebuild;
using CourseWorkRebuild2.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace CourseWorkRebuild2
{
    public partial class MainForm : Form
    {
        private List<String> pathToFilesAndData = new List<String>();
        private List<NewProjectForm1> openForms = new List<NewProjectForm1>();
        private DataTable dataTable = new DataTable();
        private System.Data.SQLite.SQLiteConnection sqlConnection;
        private Repository repository;
        private String oldObjectPicturePath = "";
        private String oldElevatorTablePath = "";
        private String oldTxtFile = "";
        List<List<Double>> valuesForSecondLevel;
        List<List<Double>> valuesForFirstLevel;
        List<List<Double>> valuesForThirdLevel;
        private Decomposition decomposition = new Decomposition();

        private PhaseCoordinates checkValuesForm = new PhaseCoordinates();
        Calculations calculations = new Calculations();
        Dictionary<int, String> blockDictionary;
        private int activeForm = 0;
        private int epochCount = 0;
        private int needMarksCount;
        private int blockIndex = 0;
        private int decompositionLevel = 0;
        private int subblockCount = 0;
        private int marksOnSubblock = 0;
        int stage = 0;
        private List<List<String>> marksByBlocks = new List<List<String>>();
        private List<List<String>> marksByBlocksForThirdLevel = new List<List<String>>();
        private List<List<String>> marksBySubBlocks = new List<List<String>>();
        private List<String> unsortedMarks = new List<String>();
        public MainForm()
        {
            InitializeComponent();
            disableStartButtons();
            checkValuesForm = new PhaseCoordinates();

            blockDictionary = new Dictionary<int, String>();
            blockDictionary.Add(0, "A");
            blockDictionary.Add(1, "Б");
            blockDictionary.Add(2, "В");
            blockDictionary.Add(3, "Г");
            blockDictionary.Add(4, "Д");

            reSortMarksPanel.Hide();
            secondLevelOfDecompositionTable.Hide();
            dataGridView1.Hide();
        
        }

        private void initEpochCount()
        {
            if (epochCount == 0)
            {
                epochCount = Convert.ToInt32(elevatorTable.Rows[(elevatorTable.Rows.Count - 2)].Cells[0].Value) + 1;
            }
        }

        private void reDrawMainForm()
        {
            reDrawElevatorTable();
            initEpochCount();
            reDrawValues();
            reDrawObjectPicture();
            if (pathToFilesAndData[6] != null & pathToFilesAndData[6] != "")
            {
                this.Text = pathToFilesAndData[6];
                this.closeButton.Enabled = true;
                this.saveAsButton.Enabled = true;
                this.closeAllButton.Enabled = true;
                this.saveCopyButton.Enabled = true;
                this.saveButton.Enabled = true;
            }
            else { this.Text = ""; }
        }
        private void firstLevelDecomposition_Enter(object sender, EventArgs e)
        {
            //Если достаточно данных для расчетов
            if (pathToFilesAndData.Count > 0 && pathToFilesAndData[0] != "" & pathToFilesAndData[2] != "" & pathToFilesAndData[3] != "")
            {

                //Тут получаем значения из расчетов
                valuesForFirstLevel = decomposition.FirstLevel(elevatorTable, dataTable, pathToFilesAndData);
                //А тут заполняем табличку
                decomposition.FillTable(firstLevelOfDecompositionTable, valuesForFirstLevel, elevatorTable);
                decomposition.FillPhaseCoordinatesTable(elevatorTable, valuesForFirstLevel, checkValuesForm.GetTable());
            }

            decompositionLevel = 1;
        }

        private bool checkSortedMarks(int needMarksCount)
        {
            if (sortedMarks.Items.Count == needMarksCount)
            {
                return true;
            }
            return false;
        }

        private void secondLevel_Enter(object sender, EventArgs e)
        {

            sortedMarks.Items.Clear();
            marksBox.Items.Clear();

            int startMarksCount = Convert.ToInt32(pathToFilesAndData[4]);
            while (startMarksCount % Convert.ToInt32(pathToFilesAndData[5]) != 0)
            {
                startMarksCount--;
            }

            needMarksCount = startMarksCount / Convert.ToInt32(pathToFilesAndData[5]);

            label4.Text = "Всего марок: " + pathToFilesAndData[4];
            label5.Text = "Блок " + blockDictionary[blockIndex];
            label6.Text = "Количество структурных блоков: " + pathToFilesAndData[5];


            for (int i = 1; i < elevatorTable.Columns.Count; i++)
            {
                marksBox.Items.Add(elevatorTable.Columns[i].Name);
            }

            if (pathToFilesAndData[1] != null & pathToFilesAndData[1] != "")
            {
                objectDiagram.Load(pathToFilesAndData[1]);
                objectDiagram.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else objectDiagram.Image = null;

            
        }

        private void reSortMarks_Click(object sender, EventArgs e)
        {
            secondLevelOfDecompositionTable.Rows.Clear();
            secondLevelOfDecompositionTable.Columns.Clear();
            marksBox.Items.Clear();
            sortedMarks.Items.Clear();
            chooseBlock.Items.Clear();

            unsortedMarks.Clear();

            foreach (List<String> list in marksByBlocks)
            {
                list.Clear();
            }

            sortMarksGroupBox.Show();
            objectDiagram.Show();

            reSortMarksPanel.Hide();
            secondLevelOfDecompositionTable.Hide();

            blockIndex = 0;
            secondLevel_Enter(sender, e);
        }
        private void addMarkToBlock_Click(object sender, EventArgs e)
        {

            if (marksBox.Items.Count > 0)
            {
                sortedMarks.Items.Add(marksBox.Items[0]);
                marksBox.Items.Remove(marksBox.Items[0]);
                sortMarks();
            }

        }

        private void sortMarks()
        {
            if (checkSortedMarks(needMarksCount))
            {
                marksByBlocks.Add(new List<String>());
                foreach (String mark in sortedMarks.Items)
                {
                    marksByBlocks[blockIndex].Add(mark);
                }
                blockIndex++;
                sortedMarks.Items.Clear();
                label5.Text = "Блок " + blockDictionary[blockIndex];
            }
            if (blockIndex == Convert.ToInt32(pathToFilesAndData[5]))
            {
                sortMarksGroupBox.Hide();
                objectDiagram.Hide();

                reSortMarksPanel.Show();
                secondLevelOfDecompositionTable.Show();

                for (int i = 0; i < Convert.ToInt32(pathToFilesAndData[5]); i++)
                {
                    chooseBlock.Items.Add(blockDictionary[i]);
                }

                for (int i = 0; i < marksBox.Items.Count; i++)
                {
                    unsortedMarks.Add(marksBox.Items[i].ToString());
                }

                chooseBlock.SelectedItem = chooseBlock.Items[0];
                decompositionLevel = 2;
                valuesForSecondLevel = decomposition.SecondLevel(elevatorTable, pathToFilesAndData, marksByBlocks, chooseBlock);
                decomposition.FillTable(secondLevelOfDecompositionTable, valuesForSecondLevel, elevatorTable);
                decomposition.FillPhaseCoordinatesTable(elevatorTable, valuesForSecondLevel, checkValuesForm.GetTable());
                
            }
        }
        private void chooseBlock_SelectedIndexChanged(object sender, EventArgs e)
        {
            valuesForSecondLevel = decomposition.SecondLevel(elevatorTable, pathToFilesAndData, marksByBlocks, chooseBlock);
            decomposition.FillTable(secondLevelOfDecompositionTable, valuesForSecondLevel, elevatorTable);
            decomposition.FillPhaseCoordinatesTable(elevatorTable, valuesForSecondLevel, checkValuesForm.GetTable());
        }

        private void removeMarkFromBlock_Click(object sender, EventArgs e)
        {
            if (sortedMarks.Items.Count > 0)
            {
                marksBox.Items.Add(sortedMarks.Items[0]);
                sortedMarks.Items.Remove(sortedMarks.Items[0]);
            }

        }
        private void fourthLevel_Enter(object sender, EventArgs e)
        {
            if (marksByBlocks.Count > 0)
            {
                fourthLevelChart.Series.Clear();
                defaultMessage.Hide();

                fourthLevelChartPanel.Show();

                availableMarks.Items.Clear();
                displayedMarks.Items.Clear();
                chooseBlock2.Items.Clear();

                for (int i = 0; i < Convert.ToInt32(pathToFilesAndData[5]); i++)
                {
                    chooseBlock2.Items.Add(blockDictionary[i]);
                }

            }
            else
            {
                defaultMessage.Show();
                fourthLevelChartPanel.Hide();
            }
        }

        private void chooseBlock2_SelectedIndexChanged(object sender, EventArgs e)
        {
            availableMarks.Items.Clear();
            displayedMarks.Items.Clear();
            foreach (String mark in marksByBlocks[chooseBlock2.SelectedIndex])
            {
                availableMarks.Items.Add(mark);

            }
            fourthLevelChart.Series.Clear();
        }

        private void availableMarks_DoubleClick(object sender, EventArgs e)
        {
            if (availableMarks.SelectedItem != null)
            {
                displayedMarks.Items.Add(availableMarks.SelectedItem);
                decomposition.FourthLevelChartAddLine(availableMarks.SelectedItem.ToString(), elevatorTable, pathToFilesAndData, fourthLevelChart);
                availableMarks.Items.Remove(availableMarks.SelectedItem);
            }

        }

        private void displayedMarks_DoubleClick(object sender, EventArgs e)
        {
            if (displayedMarks.SelectedItem != null)
            {
                availableMarks.Items.Add(displayedMarks.SelectedItem);
                decomposition.FourthLevelChartRemoveLine(displayedMarks.SelectedItem.ToString(), fourthLevelChart);
                displayedMarks.Items.Remove(displayedMarks.SelectedItem);
            }

        }
        
        private void reDrawObjectPicture()
        {
            //Если есть путь к картинке
            if (pathToFilesAndData[1] != null & pathToFilesAndData[1] != "")
            {
                noImageIcon.Image = Properties.Resources.okImageicon;
                objectPicture.Load(pathToFilesAndData[1]);
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
                noImageIcon.Image = Properties.Resources.noImageIcon;
            }
        }

        private void reDrawValues()
        {
            //Если есть значение Т
            if (pathToFilesAndData[2] != null & pathToFilesAndData[2] != "")
            {
                valueOfTLabel.Text = "T: " + pathToFilesAndData[2];
                enableButtonsForValues();
            }
            else
            {
                valueOfTLabel.Text = "Значение T не найдено";
            }
            //Если есть значение А (для сглаживания)
            if (pathToFilesAndData[3] != null & pathToFilesAndData[3] != "")
            {
                valueOfALabel.Text = "A: " + pathToFilesAndData[3];
                enableButtonsForValues();
            }
            else
            {
                valueOfALabel.Text = "Значение А не найдено";
            }
            //Если известно количество марок
            if (pathToFilesAndData[4] != null & pathToFilesAndData[4] != "")
            {
                markCount.Text = "Количество марок: " + pathToFilesAndData[4];
            }
            else markCount.Text = "Количество марок не найдено";
            //Если известно количество объектов
            if (pathToFilesAndData[5] != null & pathToFilesAndData[5] != "")
            {
                buildingCountValue.Text = "Количество объектов: " + pathToFilesAndData[5];

            }
            else buildingCountValue.Text = "Количество объектов не найдено";
        }

        private void reDrawElevatorTable()
        {
            //Если есть путь к БД
            if (pathToFilesAndData[0] != null & pathToFilesAndData[0] != "")
            {
                noDBConnectionIcon.Image = Properties.Resources.okDBIcon;
                epochCountBox.Items.Clear();
                repository = new Repository(pathToFilesAndData[0]);
                sqlConnection = repository.GetDbConnection();
                elevatorTable = repository.ShowTable(dataTable, elevatorTable);
                for (int row = 0; row < elevatorTable.Rows.Count - 1; row++)
                {
                    epochCountBox.Items.Add(elevatorTable.Rows[row].Cells[0].Value);
                }
                epochCountBox.SelectedIndex = 0;
                enableButtonsForTable();
            }
            else
            {
                noDBConnectionIcon.Image = Properties.Resources.DBErroConnectionIcon;
                elevatorTable.Rows.Clear();
                elevatorTable.Columns.Clear();
                disableButtonsForTable();
            }

        }

        private void addNewRow_Click(object sender, EventArgs e)
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

        private void openButton_Click(object sender, EventArgs e)
        {
            if (activeForm > 0)
            {
                NewProjectForm1 newProjectForm = new NewProjectForm1();
                openForms.Add(newProjectForm);
                newProjectForm.Show();
                activeForm++;
            }
            else
            {
                OpenProject openProject = new OpenProject();
                pathToFilesAndData = openProject.Open();
                if (!(pathToFilesAndData[0] == "")  & !(pathToFilesAndData[7] == ""))
                {
                    activeForm++;
                    reDrawMainForm();
                }
            }
        }

        private void openRarButton_Click(object sender, EventArgs e)
        {
            if (activeForm > 0)
            {
                NewProjectForm1 newProjectForm = new NewProjectForm1();
                openForms.Add(newProjectForm);
                newProjectForm.Show();
                activeForm++;
            }
            else
            {
                OpenProject openProject = new OpenProject();
                pathToFilesAndData = openProject.UnzipRar();
                reDrawMainForm();
                activeForm++;
            }

        }

        private void closeAllButton_Click(object sender, EventArgs e)
        {
            //Очищаем пути ко всем Файлам и все известные значения
            closeButton_Click(sender, e);

            //Дропаем все открытые формы
            foreach (NewProjectForm1 form in openForms)
            {
                form.Close();
            }
            openForms.Clear();
            reDrawMainForm();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            for (int value = 0; value < pathToFilesAndData.Count; value++)
            {
                pathToFilesAndData[value] = "";
            }
            decomposition.ClearTable(firstLevelOfDecompositionTable);
            decomposition.ClearTable(secondLevelOfDecompositionTable);
            activeForm = 0;
            reDrawMainForm();
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

        private void saveAsZipArchieve_Click(object sender, EventArgs e)
        {
            saveAsNewFolder_Click(sender, e);
        }

        private void saveAsRarArchive_Click(object sender, EventArgs e)
        {
            saveAsNewFolder_Click(sender, e);
        }

        private String getPathToSave()
        {
            String sourceDirectory = "";
            if (pathToFilesAndData[0] != "" & pathToFilesAndData[0] != null)
            {
                sourceDirectory = Path.GetDirectoryName(pathToFilesAndData[0]);
            }
            else if (pathToFilesAndData[1] != "" & pathToFilesAndData[1] != null)
            {
                sourceDirectory = Path.GetDirectoryName(pathToFilesAndData[1]);
            }
            else if (pathToFilesAndData[7] != "" & pathToFilesAndData[7] != null)
            {
                sourceDirectory = Path.GetDirectoryName(pathToFilesAndData[7]);
            }
            return sourceDirectory;
        }

        private void saveAsNewFolder_Click(object sender, EventArgs e)
        {
            try
            {
                String sourceDirectory = getPathToSave();
                if (sourceDirectory != "")
                {
                    sqlConnection.Close();
                    Save save = new Save();
                    save.SaveFilesToNewFolder(sourceDirectory);
                    sqlConnection = repository.GetDbConnection();
                    MessageBox.Show("Сохранение успешно!");
                }
                else
                {
                    MessageBox.Show("Не найдены файлы для сохранения");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение не удалось, попробуйте еще раз");
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            String tempTableFile = pathToFilesAndData[0];
            String tempPngFile = pathToFilesAndData[1];
            pathToFilesAndData[0] = "";
            pathToFilesAndData[1] = "";
            reDrawMainForm();
            Save save = new Save();
            save.SaveTxtFile(pathToFilesAndData[7], Convert.ToDouble(pathToFilesAndData[2]), Convert.ToInt32(pathToFilesAndData[5]), Convert.ToInt32(pathToFilesAndData[4]));
            if (oldObjectPicturePath != "" & oldObjectPicturePath != pathToFilesAndData[1]) { save.SaveNewFile(tempPngFile, oldObjectPicturePath, "*.png"); }
            if (oldElevatorTablePath != "" & oldElevatorTablePath != tempTableFile) { save.SaveNewFile(tempTableFile, oldElevatorTablePath, "*.sqlite"); }
            pathToFilesAndData[0] = tempTableFile;
            pathToFilesAndData[1] = tempPngFile;
            reDrawMainForm();
        }

        private void newBlocksCount_Enter(object sender, EventArgs e)
        {
            pathToFilesAndData[5] = this.newBlocksCount.Text;
            reDrawValues();
        }

        private void newAValue_Enter(object sender, EventArgs e)
        {
            pathToFilesAndData[3] = this.newAValue.Text;
            reDrawValues();
        }

        private void newTValue_Enter(object sender, EventArgs e)
        {
            pathToFilesAndData[2] = this.newTValue.Text;
            reDrawValues();
        }

        private void newTValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar.Equals(',')) | e.KeyChar.Equals('\b')) return;
            else
                e.Handled = true;
        }

        private void newAValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar.Equals(',')) | e.KeyChar.Equals('\b')) return;
            else
                e.Handled = true;
        }

        private void newBlocksCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar.Equals(',')) | e.KeyChar.Equals('\b')) return;
            else
                e.Handled = true;
        }

        private String getNewFilePath(String title, String filter)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();
            chooseFile.Multiselect = false;
            String newFilePath = "";
            chooseFile.Title = title;
            chooseFile.Filter = filter;
            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                newFilePath = Path.GetFullPath(chooseFile.FileName);

            }
            return newFilePath;
        }

        private void changeElevatorTablePath_Click(object sender, EventArgs e)
        {
            String title = "Выберите таблицу высот";
            String filter = "SQLite files (*.sqlite)|*.sqlite";
            oldElevatorTablePath = pathToFilesAndData[0];
            pathToFilesAndData[0] = getNewFilePath(title, filter);
            if (pathToFilesAndData[0] == "")
            {
                pathToFilesAndData[0] = oldElevatorTablePath;
            }
            reDrawElevatorTable();
        }

        private void changeObjectPicture_Click(object sender, EventArgs e)
        {
            String title = "Выберите схему объекта";
            String filter = "PNG files (*.png)|*.png";
            oldObjectPicturePath = pathToFilesAndData[1];
            pathToFilesAndData[1] = getNewFilePath(title, filter);
            if (pathToFilesAndData[1] == "")
            {
                pathToFilesAndData[1] = oldObjectPicturePath;
            }
            reDrawObjectPicture();
        }

        private void expSmoothChartButton_Click(object sender, EventArgs e)
        {
            if (decompositionLevel == 1)
            {
                ExpSmoothChart chartForm = new ExpSmoothChart(valuesForFirstLevel);
                chartForm.Show();
            }
            else if (decompositionLevel == 2)
            {
                ExpSmoothChart chartForm = new ExpSmoothChart(valuesForSecondLevel);
                chartForm.Show();
            }
            else if (decompositionLevel == 3)
            {
                ExpSmoothChart chartForm = new ExpSmoothChart(valuesForThirdLevel);
                chartForm.Show();
            }
        }

        private void chartButton_Click(object sender, EventArgs e)
        {
            if (decompositionLevel == 1)
            {
                ResponseChart chartForm = new ResponseChart(valuesForFirstLevel);
                chartForm.Show();
            }
            else if (decompositionLevel == 2)
            {
                ResponseChart chartForm = new ResponseChart(valuesForSecondLevel);
                chartForm.Show();
            }
            else if (decompositionLevel == 3)
            {
                ResponseChart chartForm = new ResponseChart(valuesForThirdLevel);
                chartForm.Show();
            }


        }

        private void checkValues_Click(object sender, EventArgs e)
        {
            checkValuesForm.Show();
        }

        private void enableButtonsForTable()
        {
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
            this.deleteSelectedRowsButton.Enabled = true;
            this.tabContol.Enabled = true;
            this.phaseCoordinates.Enabled = true;
            this.chartButton.Enabled = true;
            this.expSmoothChartButton.Enabled = true;
        }

        private void disableButtonsForTable()
        {
            this.AddNewEpochButton.Enabled = false;
            this.DeleteLastEpoch.Enabled = false;
            this.redactorMenu.Enabled = false;
            this.addEpochButton.Enabled = false;
            this.chooseEpochToDelete.Enabled = false;
            this.deleteEpochButton.Enabled = false;
            this.deleteSelectedRowsButton.Enabled = false;
            this.tabContol.Enabled = false;
            this.chartButton.Enabled = false;
            this.expSmoothChartButton.Enabled = false;
            this.phaseCoordinates.Enabled = false;
        }

        private void disableStartButtons()
        {
            disableButtonsForTable();
            this.closeAllButton.Enabled = false;
            this.closeButton.Enabled = false;
            this.saveAsButton.Enabled = false;
            this.saveButton.Enabled = false;
            this.saveCopyButton.Enabled = false;
        }

        private void enableButtonsForValues()
        {
            this.closeButton.Enabled = true;
            this.saveAsButton.Enabled = true;
            this.closeAllButton.Enabled = true;
            this.saveCopyButton.Enabled = true;
            this.saveButton.Enabled = true;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void marksBox_DoubleClick(object sender, EventArgs e)
        {
            if (marksBox.SelectedItem != null)
            {
                sortedMarks.Items.Add(marksBox.SelectedItem);
                marksBox.Items.Remove(marksBox.SelectedItem);
                sortMarks();
            }

        }

        private void elevatorTable_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            if (elevatorTable.CurrentCell.ColumnIndex != 0) // замените "0" на индекс столбца, в котором нужно ограничить ввод
            {
                if (e.Control is TextBox textBox)
                {
                    textBox.KeyPress -= TextBox_KeyPress; // отписываемся от старого обработчика
                    textBox.KeyPress += TextBox_KeyPress; // подписываемся на новый обработчик
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true; // отменяем ввод, если это не цифра или запятая
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true; // отменяем ввод, если запятая уже есть в ячейке
            }

        }

        private void changeTxtFile_Click(object sender, EventArgs e)
        {
            OpenProject openProject = new OpenProject();
            String title = "Выберите файл с документацией";
            String filter = "Txt files (*.txt)|*.txt";
            oldTxtFile = pathToFilesAndData[7];
            pathToFilesAndData[7] = getNewFilePath(title, filter);
            if (pathToFilesAndData[7] == "")
            {
                pathToFilesAndData[7] = oldTxtFile;
            }
            List<String> newValues = new List<String>();
            newValues = openProject.ReadValuesFromTxtFile(pathToFilesAndData[7]);
            pathToFilesAndData[2] = newValues[2];
            pathToFilesAndData[5] = newValues[0];
            pathToFilesAndData[4] = newValues[1];
            reDrawValues();
        }

        private void thirdLevel_Enter(object sender, EventArgs e)
        {
            if (marksByBlocks.Count > 0)
            {
                stage = 1;

                defaultMessage2.Hide();
                levelThirdPanel.Show();
                subblockSettingPanel.Hide();
                dataGridView1.Hide();

                chooseBlock3.Items.Clear();

                for (int i = 0; i < Convert.ToInt32(pathToFilesAndData[5]); i++)
                {
                    marksByBlocksForThirdLevel.Add(new List<String>());
                }
                
                for (int i = 0; i < marksByBlocks.Count; i++)
                {
                    for (int j = 0; j < marksByBlocks[i].Count; j++)
                    {
                        marksByBlocksForThirdLevel[i].Add(marksByBlocks[i][j]);
                    }
                }

                for (int i = 0; i < Convert.ToInt32(pathToFilesAndData[5]); i++)
                {
                    chooseBlock3.Items.Add(blockDictionary[i]);
                }

                chooseBlock3.SelectedItem = chooseBlock3.Items[0];
                marksOnSubblocksListBox.Items.Clear();

                for (int i = 0; i < marksByBlocksForThirdLevel[chooseBlock3.SelectedIndex].Count; i++)
                {
                    marksOnSubblocksListBox.Items.Add(marksByBlocksForThirdLevel[chooseBlock3.SelectedIndex][i]);
                }

                if (unsortedMarks.Count > 0)
                {
                    blockLabel.Text = "Блок " + blockDictionary[chooseBlock3.SelectedIndex];
                    listBox1.Items.Clear();
                    for (int i = 0; i < unsortedMarks.Count; i++)
                    {
                        listBox1.Items.Add(unsortedMarks[i]);
                    }
                }

            }
            else
            {
                defaultMessage2.Show();
                levelThirdPanel.Hide();
            }
        }

        private void chooseBlock3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stage == 1)
            {
                marksOnSubblocksListBox.Items.Clear();

                blockLabel.Text = "Блок " + blockDictionary[chooseBlock3.SelectedIndex];

                for (int i = 0; i < marksByBlocksForThirdLevel[chooseBlock3.SelectedIndex].Count; i++)
                {
                    marksOnSubblocksListBox.Items.Add(marksByBlocksForThirdLevel[chooseBlock3.SelectedIndex][i]);
                }
            }
            else if (stage == 2)
            {
                decomposition.ThirdLevelFillDistanceTable(distanceBetweenMarks, marksByBlocksForThirdLevel, chooseBlock3, elevatorTable, marksExcess, strongConnectionsListBox, pathToFilesAndData[2]);
            }
            else if (stage == 3)
            {
                marksOnSubblocksListBox.Items.Clear();
                for (int i = 0; i < marksBySubBlocks[chooseBlock3.SelectedIndex].Count; i++)
                {
                    marksOnSubblocksListBox.Items.Add(marksBySubBlocks[chooseBlock3.SelectedIndex][i]);
                }
            }

            
        }

        private void addConnectionToSubblock_Click(object sender, EventArgs e)
        {
            if (stage == 1)
            {
                unsortedMarks.Remove(listBox1.Items[0].ToString());
                marksByBlocksForThirdLevel[chooseBlock3.SelectedIndex].Add(listBox1.Items[0].ToString());
                marksOnSubblocksListBox.Items.Add(listBox1.Items[0]);
                listBox1.Items.Remove(listBox1.Items[0]);
            }
            if (stage == 3)
            {
                marksBySubBlocks[chooseBlock3.SelectedIndex].Add(listBox1.Items[0].ToString());
                marksOnSubblocksListBox.Items.Add(listBox1.Items[0]);
                listBox1.Items.Remove(listBox1.Items[0]);
            }
        }

        private void removeMarkFromSubblock_Click(object sender, EventArgs e)
        {
            if (stage == 1)
            {
                unsortedMarks.Add(marksOnSubblocksListBox.Items[0].ToString());
                marksByBlocksForThirdLevel[chooseBlock3.SelectedIndex].Remove(marksOnSubblocksListBox.Items[0].ToString());
                listBox1.Items.Add(marksOnSubblocksListBox.Items[0]);
                marksOnSubblocksListBox.Items.Remove(marksOnSubblocksListBox.Items[0]);
            }
            if (stage == 3)
            {
                marksBySubBlocks[chooseBlock3.SelectedIndex].Remove(marksOnSubblocksListBox.Items[0].ToString());
                listBox1.Items.Add(marksOnSubblocksListBox.Items[0]);
                marksOnSubblocksListBox.Items.Remove(marksOnSubblocksListBox.Items[0]);
            }
        }

        private void nextStageButton_Click(object sender, EventArgs e)
        {
            if (stage == 1)
            {
                subblockSettingPanel.Show();

                stage = 2;
                decomposition.ThirdLevelFillDistanceTable(distanceBetweenMarks, marksByBlocksForThirdLevel, chooseBlock3, elevatorTable, marksExcess, strongConnectionsListBox, pathToFilesAndData[2]);

                addConnectionToSubblock.Enabled = false;
                removeMarkFromBlock.Enabled = false;
            }
            if (stage == 3)
            {
                for (int i = 0; i < subblockCount; i++)
                {
                    if (marksBySubBlocks[i].Count != marksOnSubblock)
                    {
                        MessageBox.Show("На каждом структурном подблоке должно быть " + marksOnSubblock + " марок");
                        return;
                    }
                }
                dataGridView1.Show();
                decompositionLevel = 3;
                valuesForThirdLevel = decomposition.SecondLevel(elevatorTable, pathToFilesAndData, marksBySubBlocks, chooseBlock3);
                decomposition.FillTable(dataGridView1, valuesForThirdLevel, elevatorTable);
                decomposition.FillPhaseCoordinatesTable(elevatorTable, valuesForThirdLevel, checkValuesForm.GetTable());
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            subblockCount = Convert.ToInt32(textBox1.Text);
            marksOnSubblock = Convert.ToInt32(textBox2.Text);

            addConnectionToSubblock.Enabled = true;
            removeMarkFromBlock.Enabled = true;
            listBox1.Items.Clear();

            for (int i = 0; i < marksByBlocksForThirdLevel[chooseBlock3.SelectedIndex].Count; i++)
            {
                listBox1.Items.Add(marksByBlocksForThirdLevel[chooseBlock3.SelectedIndex][i]);
            }

            chooseBlock3.Items.Clear();

            for (int i = 0; i < subblockCount; i++)
            {
                chooseBlock3.Items.Add(blockDictionary[i]);
            }

            chooseBlockLabel.Text = "Выберите подБлок";

            chooseBlock3.SelectedItem = chooseBlock3.Items[0];
            marksOnSubblocksListBox.Items.Clear();

            for (int i = 0; i < subblockCount; i++)
            {
                marksBySubBlocks.Add(new List<String>());
            }

            blockLabel.Text = "Подблок " + blockDictionary[0];
            stage = 3;
        }

        private void aboutProgramButton_Click(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgramForm = new AboutProgramForm();
            aboutProgramForm.Show();
        }

        private void elevatorTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            ReferenceForm referenceForm = new ReferenceForm();
            referenceForm.Show();
        }
    }
        
}
