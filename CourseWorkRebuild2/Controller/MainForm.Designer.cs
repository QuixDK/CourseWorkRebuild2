namespace CourseWorkRebuild2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openRarButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsZipArchieve = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsRarArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsNewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCopyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.redactorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addEpochButton = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseEpochToDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.epochCountBox = new System.Windows.Forms.ToolStripComboBox();
            this.deleteEpochButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.changeTValue = new System.Windows.Forms.ToolStripMenuItem();
            this.newTValue = new System.Windows.Forms.ToolStripTextBox();
            this.acceptNewTValue = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAValue = new System.Windows.Forms.ToolStripMenuItem();
            this.newAValue = new System.Windows.Forms.ToolStripTextBox();
            this.acceptNewAValue = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBuildingsCount = new System.Windows.Forms.ToolStripMenuItem();
            this.newBlocksCount = new System.Windows.Forms.ToolStripTextBox();
            this.acceptNewBlocksCount = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.changeElevatorTablePath = new System.Windows.Forms.ToolStripMenuItem();
            this.changeObjectPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTxtFile = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.chartButton = new System.Windows.Forms.ToolStripMenuItem();
            this.expSmoothChartButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.checkValues = new System.Windows.Forms.ToolStripMenuItem();
            this.refMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.infoAboutSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabContol = new System.Windows.Forms.TabControl();
            this.dataPage = new System.Windows.Forms.TabPage();
            this.deleteSelectedRowsButton = new System.Windows.Forms.Button();
            this.markCount = new System.Windows.Forms.Label();
            this.buildingCountValue = new System.Windows.Forms.Label();
            this.valueOfALabel = new System.Windows.Forms.Label();
            this.valueOfTLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteLastEpoch = new System.Windows.Forms.Button();
            this.AddNewEpochButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.objectPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.elevatorTable = new System.Windows.Forms.DataGridView();
            this.firstLevelDecompositionTable = new System.Windows.Forms.TabPage();
            this.firstLevelOfDecompositionTable = new System.Windows.Forms.DataGridView();
            this.secondLevel = new System.Windows.Forms.TabPage();
            this.reSortMarks = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chooseBlock = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.removeMarkFromBlock = new System.Windows.Forms.Button();
            this.addMarkToBlock = new System.Windows.Forms.Button();
            this.objectDiagram = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sortedMarks = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.marksBox = new System.Windows.Forms.ListBox();
            this.secondLevelOfDecompositionTable = new System.Windows.Forms.DataGridView();
            this.thirdLevel = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.addConnectionToSubblock = new System.Windows.Forms.Button();
            this.pastStageButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.marksOnSubblocksListBox = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.strongConnectionsListBox = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nextStageButton = new System.Windows.Forms.Button();
            this.marksExcess = new System.Windows.Forms.DataGridView();
            this.distanceBetweenMarks = new System.Windows.Forms.DataGridView();
            this.chooseBlockLabel = new System.Windows.Forms.Label();
            this.chooseBlock3 = new System.Windows.Forms.ComboBox();
            this.defaultMessage2 = new System.Windows.Forms.Label();
            this.fourthLevel = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.displayedMarks = new System.Windows.Forms.ListBox();
            this.availableMarks = new System.Windows.Forms.ListBox();
            this.chooseBlockMessage = new System.Windows.Forms.Label();
            this.chooseBlock2 = new System.Windows.Forms.ComboBox();
            this.fourthLevelChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.defaultMessage = new System.Windows.Forms.Label();
            this.phaseCoordinates = new System.Windows.Forms.ToolStripMenuItem();
            this.sortMarksGroupBox = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.reSortMarksPanel = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fourthLevelChartPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.tabContol.SuspendLayout();
            this.dataPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorTable)).BeginInit();
            this.firstLevelDecompositionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstLevelOfDecompositionTable)).BeginInit();
            this.secondLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondLevelOfDecompositionTable)).BeginInit();
            this.thirdLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksExcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceBetweenMarks)).BeginInit();
            this.fourthLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fourthLevelChart)).BeginInit();
            this.sortMarksGroupBox.SuspendLayout();
            this.reSortMarksPanel.SuspendLayout();
            this.fourthLevelChartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.redactorMenu,
            this.windowsMenu,
            this.refMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createButton,
            this.openButton,
            this.openRarButton,
            this.toolStripSeparator1,
            this.closeButton,
            this.closeAllButton,
            this.saveButton,
            this.saveAsButton,
            this.saveCopyButton,
            this.toolStripSeparator2,
            this.exitButton});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(48, 20);
            this.fileMenu.Text = "Файл";
            // 
            // createButton
            // 
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(222, 22);
            this.createButton.Text = "Создать...";
            // 
            // openButton
            // 
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(222, 22);
            this.openButton.Text = "Открыть...";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // openRarButton
            // 
            this.openRarButton.Name = "openRarButton";
            this.openRarButton.Size = new System.Drawing.Size(222, 22);
            this.openRarButton.Text = "Открыть архив с проектом";
            this.openRarButton.Click += new System.EventHandler(this.openRarButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // closeButton
            // 
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(222, 22);
            this.closeButton.Text = "Закрыть";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // closeAllButton
            // 
            this.closeAllButton.Name = "closeAllButton";
            this.closeAllButton.Size = new System.Drawing.Size(222, 22);
            this.closeAllButton.Text = "Закрыть всё";
            this.closeAllButton.Click += new System.EventHandler(this.closeAllButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(222, 22);
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsZipArchieve,
            this.saveAsRarArchive,
            this.saveAsNewFolder});
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(222, 22);
            this.saveAsButton.Text = "Сохранить как...";
            // 
            // saveAsZipArchieve
            // 
            this.saveAsZipArchieve.Name = "saveAsZipArchieve";
            this.saveAsZipArchieve.Size = new System.Drawing.Size(147, 22);
            this.saveAsZipArchieve.Text = "Архив Zip";
            this.saveAsZipArchieve.Click += new System.EventHandler(this.saveAsZipArchieve_Click);
            // 
            // saveAsRarArchive
            // 
            this.saveAsRarArchive.Name = "saveAsRarArchive";
            this.saveAsRarArchive.Size = new System.Drawing.Size(147, 22);
            this.saveAsRarArchive.Text = "Архив Rar";
            this.saveAsRarArchive.Click += new System.EventHandler(this.saveAsRarArchive_Click);
            // 
            // saveAsNewFolder
            // 
            this.saveAsNewFolder.Name = "saveAsNewFolder";
            this.saveAsNewFolder.Size = new System.Drawing.Size(147, 22);
            this.saveAsNewFolder.Text = "Новую папку";
            this.saveAsNewFolder.Click += new System.EventHandler(this.saveAsNewFolder_Click);
            // 
            // saveCopyButton
            // 
            this.saveCopyButton.Name = "saveCopyButton";
            this.saveCopyButton.Size = new System.Drawing.Size(222, 22);
            this.saveCopyButton.Text = "Сохранить копию";
            this.saveCopyButton.Click += new System.EventHandler(this.saveAsNewFolder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(219, 6);
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(222, 22);
            this.exitButton.Text = "Выход";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // redactorMenu
            // 
            this.redactorMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEpochButton,
            this.chooseEpochToDelete,
            this.toolStripSeparator4,
            this.changeTValue,
            this.changeAValue,
            this.changeBuildingsCount,
            this.toolStripSeparator5,
            this.changeElevatorTablePath,
            this.changeObjectPicture,
            this.changeTxtFile});
            this.redactorMenu.Name = "redactorMenu";
            this.redactorMenu.Size = new System.Drawing.Size(108, 20);
            this.redactorMenu.Text = "Редактирование";
            // 
            // addEpochButton
            // 
            this.addEpochButton.Name = "addEpochButton";
            this.addEpochButton.Size = new System.Drawing.Size(283, 22);
            this.addEpochButton.Text = "Добавить эпоху";
            this.addEpochButton.Click += new System.EventHandler(this.addNewRow_Click);
            // 
            // chooseEpochToDelete
            // 
            this.chooseEpochToDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.epochCountBox,
            this.deleteEpochButton});
            this.chooseEpochToDelete.Name = "chooseEpochToDelete";
            this.chooseEpochToDelete.Size = new System.Drawing.Size(283, 22);
            this.chooseEpochToDelete.Text = "Удалить эпоху";
            // 
            // epochCountBox
            // 
            this.epochCountBox.Name = "epochCountBox";
            this.epochCountBox.Size = new System.Drawing.Size(121, 23);
            // 
            // deleteEpochButton
            // 
            this.deleteEpochButton.Name = "deleteEpochButton";
            this.deleteEpochButton.Size = new System.Drawing.Size(181, 22);
            this.deleteEpochButton.Text = "Удалить";
            this.deleteEpochButton.Click += new System.EventHandler(this.deleteEpochButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(280, 6);
            // 
            // changeTValue
            // 
            this.changeTValue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTValue,
            this.acceptNewTValue});
            this.changeTValue.Name = "changeTValue";
            this.changeTValue.Size = new System.Drawing.Size(283, 22);
            this.changeTValue.Text = "Изменить значение T";
            // 
            // newTValue
            // 
            this.newTValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newTValue.Name = "newTValue";
            this.newTValue.Size = new System.Drawing.Size(100, 23);
            this.newTValue.Enter += new System.EventHandler(this.newTValue_Enter);
            this.newTValue.Leave += new System.EventHandler(this.newTValue_Enter);
            this.newTValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newTValue_KeyPress);
            // 
            // acceptNewTValue
            // 
            this.acceptNewTValue.Name = "acceptNewTValue";
            this.acceptNewTValue.Size = new System.Drawing.Size(160, 22);
            this.acceptNewTValue.Text = "Применить";
            this.acceptNewTValue.Click += new System.EventHandler(this.newTValue_Enter);
            // 
            // changeAValue
            // 
            this.changeAValue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAValue,
            this.acceptNewAValue});
            this.changeAValue.Name = "changeAValue";
            this.changeAValue.Size = new System.Drawing.Size(283, 22);
            this.changeAValue.Text = "Изменить значение a";
            // 
            // newAValue
            // 
            this.newAValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newAValue.Name = "newAValue";
            this.newAValue.Size = new System.Drawing.Size(100, 23);
            this.newAValue.Enter += new System.EventHandler(this.newAValue_Enter);
            this.newAValue.Leave += new System.EventHandler(this.newAValue_Enter);
            this.newAValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newAValue_KeyPress);
            // 
            // acceptNewAValue
            // 
            this.acceptNewAValue.Name = "acceptNewAValue";
            this.acceptNewAValue.Size = new System.Drawing.Size(160, 22);
            this.acceptNewAValue.Text = "Применить";
            this.acceptNewAValue.Click += new System.EventHandler(this.newAValue_Enter);
            // 
            // changeBuildingsCount
            // 
            this.changeBuildingsCount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBlocksCount,
            this.acceptNewBlocksCount});
            this.changeBuildingsCount.Name = "changeBuildingsCount";
            this.changeBuildingsCount.Size = new System.Drawing.Size(283, 22);
            this.changeBuildingsCount.Text = "Изменить количество объектов";
            // 
            // newBlocksCount
            // 
            this.newBlocksCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newBlocksCount.Name = "newBlocksCount";
            this.newBlocksCount.Size = new System.Drawing.Size(100, 23);
            this.newBlocksCount.Enter += new System.EventHandler(this.newBlocksCount_Enter);
            this.newBlocksCount.Leave += new System.EventHandler(this.newBlocksCount_Enter);
            this.newBlocksCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newBlocksCount_KeyPress);
            // 
            // acceptNewBlocksCount
            // 
            this.acceptNewBlocksCount.Name = "acceptNewBlocksCount";
            this.acceptNewBlocksCount.Size = new System.Drawing.Size(160, 22);
            this.acceptNewBlocksCount.Text = "Применить";
            this.acceptNewBlocksCount.Click += new System.EventHandler(this.newBlocksCount_Enter);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(280, 6);
            // 
            // changeElevatorTablePath
            // 
            this.changeElevatorTablePath.Name = "changeElevatorTablePath";
            this.changeElevatorTablePath.Size = new System.Drawing.Size(283, 22);
            this.changeElevatorTablePath.Text = "Указать новую таблицу";
            this.changeElevatorTablePath.Click += new System.EventHandler(this.changeElevatorTablePath_Click);
            // 
            // changeObjectPicture
            // 
            this.changeObjectPicture.Name = "changeObjectPicture";
            this.changeObjectPicture.Size = new System.Drawing.Size(283, 22);
            this.changeObjectPicture.Text = "Указать новую схему объекта";
            this.changeObjectPicture.Click += new System.EventHandler(this.changeObjectPicture_Click);
            // 
            // changeTxtFile
            // 
            this.changeTxtFile.Name = "changeTxtFile";
            this.changeTxtFile.Size = new System.Drawing.Size(283, 22);
            this.changeTxtFile.Text = "Указать новый файл с документацией";
            this.changeTxtFile.Click += new System.EventHandler(this.changeTxtFile_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartButton,
            this.expSmoothChartButton,
            this.toolStripSeparator6,
            this.phaseCoordinates,
            this.checkValues});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(47, 20);
            this.windowsMenu.Text = "Окна";
            // 
            // chartButton
            // 
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(304, 22);
            this.chartButton.Text = "График z(t) + Прогноз";
            this.chartButton.Click += new System.EventHandler(this.chartButton_Click);
            // 
            // expSmoothChartButton
            // 
            this.expSmoothChartButton.Name = "expSmoothChartButton";
            this.expSmoothChartButton.Size = new System.Drawing.Size(304, 22);
            this.expSmoothChartButton.Text = "График экспоненциального сглаживания";
            this.expSmoothChartButton.Click += new System.EventHandler(this.expSmoothChartButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(301, 6);
            // 
            // checkValues
            // 
            this.checkValues.Name = "checkValues";
            this.checkValues.Size = new System.Drawing.Size(304, 22);
            this.checkValues.Text = "Проверка";
            this.checkValues.Click += new System.EventHandler(this.checkValues_Click);
            // 
            // refMenu
            // 
            this.refMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13,
            this.aboutProgramButton,
            this.toolStripSeparator3,
            this.infoAboutSystem});
            this.refMenu.Name = "refMenu";
            this.refMenu.Size = new System.Drawing.Size(65, 20);
            this.refMenu.Text = "Справка";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuItem13.Text = "Справка по программе...";
            // 
            // aboutProgramButton
            // 
            this.aboutProgramButton.Name = "aboutProgramButton";
            this.aboutProgramButton.Size = new System.Drawing.Size(212, 22);
            this.aboutProgramButton.Text = "О программе...";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(209, 6);
            // 
            // infoAboutSystem
            // 
            this.infoAboutSystem.Name = "infoAboutSystem";
            this.infoAboutSystem.Size = new System.Drawing.Size(212, 22);
            this.infoAboutSystem.Text = "Информация о системе";
            this.infoAboutSystem.Click += new System.EventHandler(this.infoAboutSystem_Click);
            // 
            // tabContol
            // 
            this.tabContol.Controls.Add(this.dataPage);
            this.tabContol.Controls.Add(this.firstLevelDecompositionTable);
            this.tabContol.Controls.Add(this.secondLevel);
            this.tabContol.Controls.Add(this.thirdLevel);
            this.tabContol.Controls.Add(this.fourthLevel);
            this.tabContol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContol.Location = new System.Drawing.Point(0, 24);
            this.tabContol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabContol.Name = "tabContol";
            this.tabContol.SelectedIndex = 0;
            this.tabContol.Size = new System.Drawing.Size(711, 410);
            this.tabContol.TabIndex = 1;
            // 
            // dataPage
            // 
            this.dataPage.Controls.Add(this.deleteSelectedRowsButton);
            this.dataPage.Controls.Add(this.markCount);
            this.dataPage.Controls.Add(this.buildingCountValue);
            this.dataPage.Controls.Add(this.valueOfALabel);
            this.dataPage.Controls.Add(this.valueOfTLabel);
            this.dataPage.Controls.Add(this.label3);
            this.dataPage.Controls.Add(this.DeleteLastEpoch);
            this.dataPage.Controls.Add(this.AddNewEpochButton);
            this.dataPage.Controls.Add(this.label2);
            this.dataPage.Controls.Add(this.objectPicture);
            this.dataPage.Controls.Add(this.label1);
            this.dataPage.Controls.Add(this.elevatorTable);
            this.dataPage.Location = new System.Drawing.Point(4, 22);
            this.dataPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataPage.Name = "dataPage";
            this.dataPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataPage.Size = new System.Drawing.Size(703, 384);
            this.dataPage.TabIndex = 0;
            this.dataPage.Text = "Данные";
            this.dataPage.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedRowsButton
            // 
            this.deleteSelectedRowsButton.Location = new System.Drawing.Point(237, 140);
            this.deleteSelectedRowsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteSelectedRowsButton.Name = "deleteSelectedRowsButton";
            this.deleteSelectedRowsButton.Size = new System.Drawing.Size(89, 41);
            this.deleteSelectedRowsButton.TabIndex = 13;
            this.deleteSelectedRowsButton.Text = "Удалить выделенные";
            this.deleteSelectedRowsButton.UseVisualStyleBackColor = true;
            this.deleteSelectedRowsButton.Click += new System.EventHandler(this.deleteSelectedRowsButton_Click);
            // 
            // markCount
            // 
            this.markCount.AutoSize = true;
            this.markCount.BackColor = System.Drawing.Color.White;
            this.markCount.Location = new System.Drawing.Point(6, 94);
            this.markCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.markCount.Name = "markCount";
            this.markCount.Size = new System.Drawing.Size(0, 13);
            this.markCount.TabIndex = 12;
            // 
            // buildingCountValue
            // 
            this.buildingCountValue.AutoSize = true;
            this.buildingCountValue.BackColor = System.Drawing.Color.White;
            this.buildingCountValue.Location = new System.Drawing.Point(6, 76);
            this.buildingCountValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buildingCountValue.Name = "buildingCountValue";
            this.buildingCountValue.Size = new System.Drawing.Size(0, 13);
            this.buildingCountValue.TabIndex = 11;
            // 
            // valueOfALabel
            // 
            this.valueOfALabel.AutoSize = true;
            this.valueOfALabel.BackColor = System.Drawing.Color.White;
            this.valueOfALabel.Location = new System.Drawing.Point(139, 43);
            this.valueOfALabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueOfALabel.Name = "valueOfALabel";
            this.valueOfALabel.Size = new System.Drawing.Size(0, 13);
            this.valueOfALabel.TabIndex = 10;
            // 
            // valueOfTLabel
            // 
            this.valueOfTLabel.AutoSize = true;
            this.valueOfTLabel.BackColor = System.Drawing.Color.White;
            this.valueOfTLabel.Location = new System.Drawing.Point(6, 43);
            this.valueOfTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueOfTLabel.Name = "valueOfTLabel";
            this.valueOfTLabel.Size = new System.Drawing.Size(0, 13);
            this.valueOfTLabel.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Начальные данные";
            // 
            // DeleteLastEpoch
            // 
            this.DeleteLastEpoch.Location = new System.Drawing.Point(122, 140);
            this.DeleteLastEpoch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteLastEpoch.Name = "DeleteLastEpoch";
            this.DeleteLastEpoch.Size = new System.Drawing.Size(111, 41);
            this.DeleteLastEpoch.TabIndex = 5;
            this.DeleteLastEpoch.Text = "Удалить последнюю эпоху";
            this.DeleteLastEpoch.UseVisualStyleBackColor = true;
            this.DeleteLastEpoch.Click += new System.EventHandler(this.deleteLastEpoch_Click);
            // 
            // AddNewEpochButton
            // 
            this.AddNewEpochButton.Location = new System.Drawing.Point(6, 140);
            this.AddNewEpochButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddNewEpochButton.Name = "AddNewEpochButton";
            this.AddNewEpochButton.Size = new System.Drawing.Size(111, 41);
            this.AddNewEpochButton.TabIndex = 4;
            this.AddNewEpochButton.Text = "Добавить эпоху";
            this.AddNewEpochButton.UseVisualStyleBackColor = true;
            this.AddNewEpochButton.Click += new System.EventHandler(this.addNewRow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(612, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Схема объекта";
            // 
            // objectPicture
            // 
            this.objectPicture.BackColor = System.Drawing.Color.White;
            this.objectPicture.Location = new System.Drawing.Point(463, 37);
            this.objectPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.objectPicture.Name = "objectPicture";
            this.objectPicture.Size = new System.Drawing.Size(233, 145);
            this.objectPicture.TabIndex = 2;
            this.objectPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица высот";
            // 
            // elevatorTable
            // 
            this.elevatorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elevatorTable.Location = new System.Drawing.Point(6, 186);
            this.elevatorTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.elevatorTable.Name = "elevatorTable";
            this.elevatorTable.RowHeadersWidth = 51;
            this.elevatorTable.RowTemplate.Height = 24;
            this.elevatorTable.Size = new System.Drawing.Size(690, 191);
            this.elevatorTable.TabIndex = 0;
            this.elevatorTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.elevatorTable_CellEndEdit);
            this.elevatorTable.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.elevatorTable_EditingControlShowing);
            // 
            // firstLevelDecompositionTable
            // 
            this.firstLevelDecompositionTable.Controls.Add(this.firstLevelOfDecompositionTable);
            this.firstLevelDecompositionTable.Location = new System.Drawing.Point(4, 22);
            this.firstLevelDecompositionTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstLevelDecompositionTable.Name = "firstLevelDecompositionTable";
            this.firstLevelDecompositionTable.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstLevelDecompositionTable.Size = new System.Drawing.Size(703, 384);
            this.firstLevelDecompositionTable.TabIndex = 1;
            this.firstLevelDecompositionTable.Text = "Уровень 1";
            this.firstLevelDecompositionTable.UseVisualStyleBackColor = true;
            this.firstLevelDecompositionTable.Enter += new System.EventHandler(this.firstLevelDecomposition_Enter);
            // 
            // firstLevelOfDecompositionTable
            // 
            this.firstLevelOfDecompositionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firstLevelOfDecompositionTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstLevelOfDecompositionTable.Location = new System.Drawing.Point(2, 2);
            this.firstLevelOfDecompositionTable.Name = "firstLevelOfDecompositionTable";
            this.firstLevelOfDecompositionTable.RowHeadersWidth = 51;
            this.firstLevelOfDecompositionTable.Size = new System.Drawing.Size(699, 380);
            this.firstLevelOfDecompositionTable.TabIndex = 0;
            // 
            // secondLevel
            // 
            this.secondLevel.Controls.Add(this.reSortMarksPanel);
            this.secondLevel.Controls.Add(this.objectDiagram);
            this.secondLevel.Controls.Add(this.sortMarksGroupBox);
            this.secondLevel.Controls.Add(this.secondLevelOfDecompositionTable);
            this.secondLevel.Location = new System.Drawing.Point(4, 22);
            this.secondLevel.Name = "secondLevel";
            this.secondLevel.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.secondLevel.Size = new System.Drawing.Size(703, 384);
            this.secondLevel.TabIndex = 2;
            this.secondLevel.Text = "Уровень 2";
            this.secondLevel.UseVisualStyleBackColor = true;
            this.secondLevel.Enter += new System.EventHandler(this.secondLevel_Enter);
            // 
            // reSortMarks
            // 
            this.reSortMarks.Location = new System.Drawing.Point(4, 3);
            this.reSortMarks.Name = "reSortMarks";
            this.reSortMarks.Size = new System.Drawing.Size(294, 23);
            this.reSortMarks.TabIndex = 11;
            this.reSortMarks.Text = "Перераспределить марки";
            this.reSortMarks.UseVisualStyleBackColor = true;
            this.reSortMarks.Click += new System.EventHandler(this.reSortMarks_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Выберите блок:";
            // 
            // chooseBlock
            // 
            this.chooseBlock.FormattingEnabled = true;
            this.chooseBlock.Location = new System.Drawing.Point(92, 31);
            this.chooseBlock.Name = "chooseBlock";
            this.chooseBlock.Size = new System.Drawing.Size(206, 21);
            this.chooseBlock.TabIndex = 9;
            this.chooseBlock.SelectedIndexChanged += new System.EventHandler(this.chooseBlock_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "   ";
            // 
            // removeMarkFromBlock
            // 
            this.removeMarkFromBlock.Location = new System.Drawing.Point(173, 215);
            this.removeMarkFromBlock.Name = "removeMarkFromBlock";
            this.removeMarkFromBlock.Size = new System.Drawing.Size(31, 23);
            this.removeMarkFromBlock.TabIndex = 6;
            this.removeMarkFromBlock.Text = "<-";
            this.removeMarkFromBlock.UseVisualStyleBackColor = true;
            this.removeMarkFromBlock.Click += new System.EventHandler(this.removeMarkFromBlock_Click);
            // 
            // addMarkToBlock
            // 
            this.addMarkToBlock.Location = new System.Drawing.Point(173, 186);
            this.addMarkToBlock.Name = "addMarkToBlock";
            this.addMarkToBlock.Size = new System.Drawing.Size(31, 23);
            this.addMarkToBlock.TabIndex = 5;
            this.addMarkToBlock.Text = "->";
            this.addMarkToBlock.UseVisualStyleBackColor = true;
            this.addMarkToBlock.Click += new System.EventHandler(this.addMarkToBlock_Click);
            // 
            // objectDiagram
            // 
            this.objectDiagram.Location = new System.Drawing.Point(399, 104);
            this.objectDiagram.Name = "objectDiagram";
            this.objectDiagram.Size = new System.Drawing.Size(301, 277);
            this.objectDiagram.TabIndex = 4;
            this.objectDiagram.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "    ";
            // 
            // sortedMarks
            // 
            this.sortedMarks.FormattingEnabled = true;
            this.sortedMarks.Location = new System.Drawing.Point(210, 130);
            this.sortedMarks.Name = "sortedMarks";
            this.sortedMarks.Size = new System.Drawing.Size(170, 225);
            this.sortedMarks.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "  ";
            // 
            // marksBox
            // 
            this.marksBox.FormattingEnabled = true;
            this.marksBox.Location = new System.Drawing.Point(6, 130);
            this.marksBox.Name = "marksBox";
            this.marksBox.Size = new System.Drawing.Size(157, 225);
            this.marksBox.TabIndex = 0;
            this.marksBox.DoubleClick += new System.EventHandler(this.marksBox_DoubleClick);
            // 
            // secondLevelOfDecompositionTable
            // 
            this.secondLevelOfDecompositionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secondLevelOfDecompositionTable.Location = new System.Drawing.Point(6, 104);
            this.secondLevelOfDecompositionTable.Name = "secondLevelOfDecompositionTable";
            this.secondLevelOfDecompositionTable.RowHeadersWidth = 51;
            this.secondLevelOfDecompositionTable.Size = new System.Drawing.Size(694, 277);
            this.secondLevelOfDecompositionTable.TabIndex = 8;
            // 
            // thirdLevel
            // 
            this.thirdLevel.Controls.Add(this.button1);
            this.thirdLevel.Controls.Add(this.addConnectionToSubblock);
            this.thirdLevel.Controls.Add(this.pastStageButton);
            this.thirdLevel.Controls.Add(this.label13);
            this.thirdLevel.Controls.Add(this.marksOnSubblocksListBox);
            this.thirdLevel.Controls.Add(this.label12);
            this.thirdLevel.Controls.Add(this.strongConnectionsListBox);
            this.thirdLevel.Controls.Add(this.label11);
            this.thirdLevel.Controls.Add(this.label10);
            this.thirdLevel.Controls.Add(this.nextStageButton);
            this.thirdLevel.Controls.Add(this.marksExcess);
            this.thirdLevel.Controls.Add(this.distanceBetweenMarks);
            this.thirdLevel.Controls.Add(this.chooseBlockLabel);
            this.thirdLevel.Controls.Add(this.chooseBlock3);
            this.thirdLevel.Controls.Add(this.defaultMessage2);
            this.thirdLevel.Location = new System.Drawing.Point(4, 22);
            this.thirdLevel.Name = "thirdLevel";
            this.thirdLevel.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.thirdLevel.Size = new System.Drawing.Size(703, 384);
            this.thirdLevel.TabIndex = 3;
            this.thirdLevel.Text = "Уровень 3";
            this.thirdLevel.UseVisualStyleBackColor = true;
            this.thirdLevel.Enter += new System.EventHandler(this.thirdLevel_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addConnectionToSubblock
            // 
            this.addConnectionToSubblock.Location = new System.Drawing.Point(103, 139);
            this.addConnectionToSubblock.Name = "addConnectionToSubblock";
            this.addConnectionToSubblock.Size = new System.Drawing.Size(31, 23);
            this.addConnectionToSubblock.TabIndex = 26;
            this.addConnectionToSubblock.Text = "->";
            this.addConnectionToSubblock.UseVisualStyleBackColor = true;
            // 
            // pastStageButton
            // 
            this.pastStageButton.Location = new System.Drawing.Point(424, 30);
            this.pastStageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pastStageButton.Name = "pastStageButton";
            this.pastStageButton.Size = new System.Drawing.Size(193, 20);
            this.pastStageButton.TabIndex = 25;
            this.pastStageButton.Text = "Вернуться к прошлому шагу  <--";
            this.pastStageButton.UseVisualStyleBackColor = true;
            this.pastStageButton.Click += new System.EventHandler(this.pastStageButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(127, 41);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Подструктурный блок";
            // 
            // marksOnSubblocksListBox
            // 
            this.marksOnSubblocksListBox.FormattingEnabled = true;
            this.marksOnSubblocksListBox.Location = new System.Drawing.Point(139, 56);
            this.marksOnSubblocksListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.marksOnSubblocksListBox.Name = "marksOnSubblocksListBox";
            this.marksOnSubblocksListBox.Size = new System.Drawing.Size(94, 251);
            this.marksOnSubblocksListBox.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 41);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Крепкие связи";
            // 
            // strongConnectionsListBox
            // 
            this.strongConnectionsListBox.FormattingEnabled = true;
            this.strongConnectionsListBox.Location = new System.Drawing.Point(4, 56);
            this.strongConnectionsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.strongConnectionsListBox.Name = "strongConnectionsListBox";
            this.strongConnectionsListBox.Size = new System.Drawing.Size(94, 251);
            this.strongConnectionsListBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 171);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Таблица превышений";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Таблица расстояния между точками";
            // 
            // nextStageButton
            // 
            this.nextStageButton.Location = new System.Drawing.Point(424, 8);
            this.nextStageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextStageButton.Name = "nextStageButton";
            this.nextStageButton.Size = new System.Drawing.Size(193, 20);
            this.nextStageButton.TabIndex = 18;
            this.nextStageButton.Text = "Перейти к следующему шагу -->";
            this.nextStageButton.UseVisualStyleBackColor = true;
            this.nextStageButton.Click += new System.EventHandler(this.nextStageButton_Click);
            // 
            // marksExcess
            // 
            this.marksExcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marksExcess.Location = new System.Drawing.Point(6, 186);
            this.marksExcess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.marksExcess.Name = "marksExcess";
            this.marksExcess.RowHeadersWidth = 51;
            this.marksExcess.RowTemplate.Height = 24;
            this.marksExcess.Size = new System.Drawing.Size(612, 130);
            this.marksExcess.TabIndex = 17;
            // 
            // distanceBetweenMarks
            // 
            this.distanceBetweenMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.distanceBetweenMarks.Location = new System.Drawing.Point(5, 54);
            this.distanceBetweenMarks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.distanceBetweenMarks.Name = "distanceBetweenMarks";
            this.distanceBetweenMarks.RowHeadersWidth = 51;
            this.distanceBetweenMarks.RowTemplate.Height = 24;
            this.distanceBetweenMarks.Size = new System.Drawing.Size(612, 107);
            this.distanceBetweenMarks.TabIndex = 16;
            // 
            // chooseBlockLabel
            // 
            this.chooseBlockLabel.AutoSize = true;
            this.chooseBlockLabel.Location = new System.Drawing.Point(7, 11);
            this.chooseBlockLabel.Name = "chooseBlockLabel";
            this.chooseBlockLabel.Size = new System.Drawing.Size(87, 13);
            this.chooseBlockLabel.TabIndex = 14;
            this.chooseBlockLabel.Text = "Выберите блок:";
            // 
            // chooseBlock3
            // 
            this.chooseBlock3.FormattingEnabled = true;
            this.chooseBlock3.Location = new System.Drawing.Point(112, 8);
            this.chooseBlock3.Name = "chooseBlock3";
            this.chooseBlock3.Size = new System.Drawing.Size(121, 21);
            this.chooseBlock3.TabIndex = 13;
            this.chooseBlock3.SelectedIndexChanged += new System.EventHandler(this.chooseBlock3_SelectedIndexChanged);
            // 
            // defaultMessage2
            // 
            this.defaultMessage2.AutoSize = true;
            this.defaultMessage2.Location = new System.Drawing.Point(184, 11);
            this.defaultMessage2.Name = "defaultMessage2";
            this.defaultMessage2.Size = new System.Drawing.Size(251, 13);
            this.defaultMessage2.TabIndex = 15;
            this.defaultMessage2.Text = "Сначала распределите марки на втором уровне";
            // 
            // fourthLevel
            // 
            this.fourthLevel.Controls.Add(this.fourthLevelChartPanel);
            this.fourthLevel.Controls.Add(this.defaultMessage);
            this.fourthLevel.Location = new System.Drawing.Point(4, 22);
            this.fourthLevel.Name = "fourthLevel";
            this.fourthLevel.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.fourthLevel.Size = new System.Drawing.Size(703, 384);
            this.fourthLevel.TabIndex = 4;
            this.fourthLevel.Text = "Уровень 4";
            this.fourthLevel.UseVisualStyleBackColor = true;
            this.fourthLevel.Enter += new System.EventHandler(this.fourthLevel_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(563, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Отображенные марки";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(572, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Доступные марки";
            // 
            // displayedMarks
            // 
            this.displayedMarks.FormattingEnabled = true;
            this.displayedMarks.Location = new System.Drawing.Point(563, 182);
            this.displayedMarks.Name = "displayedMarks";
            this.displayedMarks.Size = new System.Drawing.Size(126, 173);
            this.displayedMarks.TabIndex = 15;
            this.displayedMarks.SelectedIndexChanged += new System.EventHandler(this.displayedMarks_SelectedIndexChanged);
            this.displayedMarks.DoubleClick += new System.EventHandler(this.displayedMarks_DoubleClick);
            // 
            // availableMarks
            // 
            this.availableMarks.FormattingEnabled = true;
            this.availableMarks.Location = new System.Drawing.Point(563, 29);
            this.availableMarks.Name = "availableMarks";
            this.availableMarks.Size = new System.Drawing.Size(126, 121);
            this.availableMarks.TabIndex = 14;
            this.availableMarks.DoubleClick += new System.EventHandler(this.availableMarks_DoubleClick);
            // 
            // chooseBlockMessage
            // 
            this.chooseBlockMessage.AutoSize = true;
            this.chooseBlockMessage.Location = new System.Drawing.Point(3, 6);
            this.chooseBlockMessage.Name = "chooseBlockMessage";
            this.chooseBlockMessage.Size = new System.Drawing.Size(87, 13);
            this.chooseBlockMessage.TabIndex = 12;
            this.chooseBlockMessage.Text = "Выберите блок:";
            // 
            // chooseBlock2
            // 
            this.chooseBlock2.FormattingEnabled = true;
            this.chooseBlock2.Location = new System.Drawing.Point(96, 3);
            this.chooseBlock2.Name = "chooseBlock2";
            this.chooseBlock2.Size = new System.Drawing.Size(121, 21);
            this.chooseBlock2.TabIndex = 11;
            this.chooseBlock2.SelectedIndexChanged += new System.EventHandler(this.chooseBlock2_SelectedIndexChanged);
            // 
            // fourthLevelChart
            // 
            chartArea1.Name = "ChartArea1";
            this.fourthLevelChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.fourthLevelChart.Legends.Add(legend1);
            this.fourthLevelChart.Location = new System.Drawing.Point(5, 30);
            this.fourthLevelChart.Name = "fourthLevelChart";
            this.fourthLevelChart.Size = new System.Drawing.Size(552, 328);
            this.fourthLevelChart.TabIndex = 0;
            this.fourthLevelChart.Text = "chart1";
            // 
            // defaultMessage
            // 
            this.defaultMessage.AutoSize = true;
            this.defaultMessage.Location = new System.Drawing.Point(235, 4);
            this.defaultMessage.Name = "defaultMessage";
            this.defaultMessage.Size = new System.Drawing.Size(251, 13);
            this.defaultMessage.TabIndex = 13;
            this.defaultMessage.Text = "Сначала распределите марки на втором уровне";
            // 
            // phaseCoordinates
            // 
            this.phaseCoordinates.Name = "phaseCoordinates";
            this.phaseCoordinates.Size = new System.Drawing.Size(304, 22);
            this.phaseCoordinates.Text = "Фазовые координаты";
            this.phaseCoordinates.Click += new System.EventHandler(this.phaseCoordinates_Click);
            // 
            // sortMarksGroupBox
            // 
            this.sortMarksGroupBox.Controls.Add(this.label15);
            this.sortMarksGroupBox.Controls.Add(this.label14);
            this.sortMarksGroupBox.Controls.Add(this.marksBox);
            this.sortMarksGroupBox.Controls.Add(this.label6);
            this.sortMarksGroupBox.Controls.Add(this.removeMarkFromBlock);
            this.sortMarksGroupBox.Controls.Add(this.label5);
            this.sortMarksGroupBox.Controls.Add(this.addMarkToBlock);
            this.sortMarksGroupBox.Controls.Add(this.label4);
            this.sortMarksGroupBox.Controls.Add(this.sortedMarks);
            this.sortMarksGroupBox.Location = new System.Drawing.Point(3, 3);
            this.sortMarksGroupBox.Name = "sortMarksGroupBox";
            this.sortMarksGroupBox.Size = new System.Drawing.Size(390, 378);
            this.sortMarksGroupBox.TabIndex = 12;
            this.sortMarksGroupBox.TabStop = false;
            this.sortMarksGroupBox.Text = "Сгруппируйте марки";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 101);
            this.label14.MaximumSize = new System.Drawing.Size(150, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 26);
            this.label14.TabIndex = 11;
            this.label14.Text = "Все доступные марки объекта";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(209, 75);
            this.label15.MaximumSize = new System.Drawing.Size(110, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 26);
            this.label15.TabIndex = 12;
            this.label15.Text = "Рассортированные марки";
            // 
            // reSortMarksPanel
            // 
            this.reSortMarksPanel.Controls.Add(this.comboBox1);
            this.reSortMarksPanel.Controls.Add(this.label16);
            this.reSortMarksPanel.Controls.Add(this.label7);
            this.reSortMarksPanel.Controls.Add(this.reSortMarks);
            this.reSortMarksPanel.Controls.Add(this.chooseBlock);
            this.reSortMarksPanel.Location = new System.Drawing.Point(399, 3);
            this.reSortMarksPanel.Name = "reSortMarksPanel";
            this.reSortMarksPanel.Size = new System.Drawing.Size(301, 100);
            this.reSortMarksPanel.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Выберите таблицу:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // fourthLevelChartPanel
            // 
            this.fourthLevelChartPanel.Controls.Add(this.chooseBlock2);
            this.fourthLevelChartPanel.Controls.Add(this.chooseBlockMessage);
            this.fourthLevelChartPanel.Controls.Add(this.label8);
            this.fourthLevelChartPanel.Controls.Add(this.label9);
            this.fourthLevelChartPanel.Controls.Add(this.availableMarks);
            this.fourthLevelChartPanel.Controls.Add(this.displayedMarks);
            this.fourthLevelChartPanel.Controls.Add(this.fourthLevelChart);
            this.fourthLevelChartPanel.Location = new System.Drawing.Point(6, 20);
            this.fourthLevelChartPanel.Name = "fourthLevelChartPanel";
            this.fourthLevelChartPanel.Size = new System.Drawing.Size(694, 368);
            this.fourthLevelChartPanel.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 434);
            this.Controls.Add(this.tabContol);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabContol.ResumeLayout(false);
            this.dataPage.ResumeLayout(false);
            this.dataPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorTable)).EndInit();
            this.firstLevelDecompositionTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.firstLevelOfDecompositionTable)).EndInit();
            this.secondLevel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondLevelOfDecompositionTable)).EndInit();
            this.thirdLevel.ResumeLayout(false);
            this.thirdLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksExcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceBetweenMarks)).EndInit();
            this.fourthLevel.ResumeLayout(false);
            this.fourthLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fourthLevelChart)).EndInit();
            this.sortMarksGroupBox.ResumeLayout(false);
            this.sortMarksGroupBox.PerformLayout();
            this.reSortMarksPanel.ResumeLayout(false);
            this.reSortMarksPanel.PerformLayout();
            this.fourthLevelChartPanel.ResumeLayout(false);
            this.fourthLevelChartPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem createButton;
        private System.Windows.Forms.ToolStripMenuItem openButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeButton;
        private System.Windows.Forms.ToolStripMenuItem closeAllButton;
        private System.Windows.Forms.ToolStripMenuItem saveButton;
        private System.Windows.Forms.ToolStripMenuItem saveAsButton;
        private System.Windows.Forms.ToolStripMenuItem saveCopyButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.ToolStripMenuItem redactorMenu;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem refMenu;
        private System.Windows.Forms.ToolStripMenuItem addEpochButton;
        private System.Windows.Forms.ToolStripMenuItem chooseEpochToDelete;
        private System.Windows.Forms.ToolStripComboBox epochCountBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem changeTValue;
        private System.Windows.Forms.ToolStripMenuItem changeAValue;
        private System.Windows.Forms.ToolStripMenuItem changeBuildingsCount;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem infoAboutSystem;
        private System.Windows.Forms.TabControl tabContol;
        private System.Windows.Forms.TabPage dataPage;
        private System.Windows.Forms.Button DeleteLastEpoch;
        private System.Windows.Forms.Button AddNewEpochButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox objectPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView elevatorTable;
        private System.Windows.Forms.TabPage firstLevelDecompositionTable;
        private System.Windows.Forms.ToolStripMenuItem openRarButton;
        private System.Windows.Forms.ToolStripMenuItem deleteEpochButton;
        private System.Windows.Forms.Label valueOfALabel;
        private System.Windows.Forms.Label valueOfTLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem saveAsZipArchieve;
        private System.Windows.Forms.ToolStripMenuItem saveAsRarArchive;
        private System.Windows.Forms.ToolStripMenuItem saveAsNewFolder;
        private System.Windows.Forms.ToolStripTextBox newTValue;
        private System.Windows.Forms.ToolStripTextBox newAValue;
        private System.Windows.Forms.ToolStripTextBox newBlocksCount;
        private System.Windows.Forms.ToolStripMenuItem acceptNewTValue;
        private System.Windows.Forms.ToolStripMenuItem acceptNewAValue;
        private System.Windows.Forms.ToolStripMenuItem acceptNewBlocksCount;
        private System.Windows.Forms.Label markCount;
        private System.Windows.Forms.Label buildingCountValue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem changeElevatorTablePath;
        private System.Windows.Forms.ToolStripMenuItem changeObjectPicture;
        private System.Windows.Forms.Button deleteSelectedRowsButton;
        private System.Windows.Forms.ToolStripMenuItem chartButton;
        private System.Windows.Forms.DataGridView firstLevelOfDecompositionTable;
        private System.Windows.Forms.ToolStripMenuItem checkValues;
        private System.Windows.Forms.TabPage secondLevel;
        private System.Windows.Forms.Button removeMarkFromBlock;
        private System.Windows.Forms.Button addMarkToBlock;
        private System.Windows.Forms.PictureBox objectDiagram;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox sortedMarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox marksBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView secondLevelOfDecompositionTable;
        private System.Windows.Forms.ComboBox chooseBlock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button reSortMarks;
        private System.Windows.Forms.ToolStripMenuItem expSmoothChartButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.TabPage thirdLevel;
        private System.Windows.Forms.TabPage fourthLevel;
        private System.Windows.Forms.Label chooseBlockMessage;
        private System.Windows.Forms.ComboBox chooseBlock2;
        private System.Windows.Forms.DataVisualization.Charting.Chart fourthLevelChart;
        private System.Windows.Forms.Label defaultMessage;
        private System.Windows.Forms.ListBox displayedMarks;
        private System.Windows.Forms.ListBox availableMarks;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem changeTxtFile;
        private System.Windows.Forms.DataGridView marksExcess;
        private System.Windows.Forms.DataGridView distanceBetweenMarks;
        private System.Windows.Forms.Label chooseBlockLabel;
        private System.Windows.Forms.ComboBox chooseBlock3;
        private System.Windows.Forms.Label defaultMessage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button nextStageButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox strongConnectionsListBox;
        private System.Windows.Forms.Button pastStageButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox marksOnSubblocksListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addConnectionToSubblock;
        private System.Windows.Forms.ToolStripMenuItem phaseCoordinates;
        private System.Windows.Forms.GroupBox sortMarksGroupBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel reSortMarksPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel fourthLevelChartPanel;
    }
}

