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
            this.phaseCoordinates = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label1 = new System.Windows.Forms.Label();
            this.elevatorTable = new System.Windows.Forms.DataGridView();
            this.firstLevelDecompositionTable = new System.Windows.Forms.TabPage();
            this.firstLevelOfDecompositionTable = new System.Windows.Forms.DataGridView();
            this.secondLevel = new System.Windows.Forms.TabPage();
            this.reSortMarksPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.reSortMarks = new System.Windows.Forms.Button();
            this.chooseBlock = new System.Windows.Forms.ComboBox();
            this.sortMarksGroupBox = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.marksBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.removeMarkFromBlock = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.addMarkToBlock = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sortedMarks = new System.Windows.Forms.ListBox();
            this.secondLevelOfDecompositionTable = new System.Windows.Forms.DataGridView();
            this.thirdLevel = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.levelThirdPanel = new System.Windows.Forms.Panel();
            this.subblockSettingPanel = new System.Windows.Forms.Panel();
            this.acceptButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nextStageButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.strongConnectionsListBox = new System.Windows.Forms.ListBox();
            this.removeMarkFromSubblock = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.chooseBlockLabel = new System.Windows.Forms.Label();
            this.addConnectionToSubblock = new System.Windows.Forms.Button();
            this.chooseBlock3 = new System.Windows.Forms.ComboBox();
            this.distanceBetweenMarks = new System.Windows.Forms.DataGridView();
            this.marksExcess = new System.Windows.Forms.DataGridView();
            this.blockLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.marksOnSubblocksListBox = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.defaultMessage2 = new System.Windows.Forms.Label();
            this.fourthLevel = new System.Windows.Forms.TabPage();
            this.fourthLevelChartPanel = new System.Windows.Forms.Panel();
            this.chooseBlock2 = new System.Windows.Forms.ComboBox();
            this.chooseBlockMessage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.availableMarks = new System.Windows.Forms.ListBox();
            this.displayedMarks = new System.Windows.Forms.ListBox();
            this.fourthLevelChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.defaultMessage = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.objectPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.noImageIcon = new System.Windows.Forms.PictureBox();
            this.noDBConnectionIcon = new System.Windows.Forms.PictureBox();
            this.objectDiagram = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.tabContol.SuspendLayout();
            this.dataPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorTable)).BeginInit();
            this.firstLevelDecompositionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstLevelOfDecompositionTable)).BeginInit();
            this.secondLevel.SuspendLayout();
            this.reSortMarksPanel.SuspendLayout();
            this.sortMarksGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondLevelOfDecompositionTable)).BeginInit();
            this.thirdLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.levelThirdPanel.SuspendLayout();
            this.subblockSettingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceBetweenMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksExcess)).BeginInit();
            this.fourthLevel.SuspendLayout();
            this.fourthLevelChartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fourthLevelChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noImageIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDBConnectionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDiagram)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1308, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fileMenu.Size = new System.Drawing.Size(59, 24);
            this.fileMenu.Text = "Файл";
            // 
            // openButton
            // 
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(278, 26);
            this.openButton.Text = "Открыть...";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // openRarButton
            // 
            this.openRarButton.Name = "openRarButton";
            this.openRarButton.Size = new System.Drawing.Size(278, 26);
            this.openRarButton.Text = "Открыть архив с проектом";
            this.openRarButton.Click += new System.EventHandler(this.openRarButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(275, 6);
            // 
            // closeButton
            // 
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(278, 26);
            this.closeButton.Text = "Закрыть";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // closeAllButton
            // 
            this.closeAllButton.Name = "closeAllButton";
            this.closeAllButton.Size = new System.Drawing.Size(278, 26);
            this.closeAllButton.Text = "Закрыть всё";
            this.closeAllButton.Click += new System.EventHandler(this.closeAllButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(278, 26);
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
            this.saveAsButton.Size = new System.Drawing.Size(278, 26);
            this.saveAsButton.Text = "Сохранить как...";
            // 
            // saveAsZipArchieve
            // 
            this.saveAsZipArchieve.Name = "saveAsZipArchieve";
            this.saveAsZipArchieve.Size = new System.Drawing.Size(183, 26);
            this.saveAsZipArchieve.Text = "Архив Zip";
            this.saveAsZipArchieve.Click += new System.EventHandler(this.saveAsZipArchieve_Click);
            // 
            // saveAsRarArchive
            // 
            this.saveAsRarArchive.Name = "saveAsRarArchive";
            this.saveAsRarArchive.Size = new System.Drawing.Size(183, 26);
            this.saveAsRarArchive.Text = "Архив Rar";
            this.saveAsRarArchive.Click += new System.EventHandler(this.saveAsRarArchive_Click);
            // 
            // saveAsNewFolder
            // 
            this.saveAsNewFolder.Name = "saveAsNewFolder";
            this.saveAsNewFolder.Size = new System.Drawing.Size(183, 26);
            this.saveAsNewFolder.Text = "Новую папку";
            this.saveAsNewFolder.Click += new System.EventHandler(this.saveAsNewFolder_Click);
            // 
            // saveCopyButton
            // 
            this.saveCopyButton.Name = "saveCopyButton";
            this.saveCopyButton.Size = new System.Drawing.Size(278, 26);
            this.saveCopyButton.Text = "Сохранить копию";
            this.saveCopyButton.Click += new System.EventHandler(this.saveAsNewFolder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(275, 6);
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(278, 26);
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
            this.redactorMenu.Size = new System.Drawing.Size(137, 24);
            this.redactorMenu.Text = "Редактирование";
            // 
            // addEpochButton
            // 
            this.addEpochButton.Name = "addEpochButton";
            this.addEpochButton.Size = new System.Drawing.Size(357, 26);
            this.addEpochButton.Text = "Добавить эпоху";
            this.addEpochButton.Click += new System.EventHandler(this.addNewRow_Click);
            // 
            // chooseEpochToDelete
            // 
            this.chooseEpochToDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.epochCountBox,
            this.deleteEpochButton});
            this.chooseEpochToDelete.Name = "chooseEpochToDelete";
            this.chooseEpochToDelete.Size = new System.Drawing.Size(357, 26);
            this.chooseEpochToDelete.Text = "Удалить эпоху";
            // 
            // epochCountBox
            // 
            this.epochCountBox.Name = "epochCountBox";
            this.epochCountBox.Size = new System.Drawing.Size(121, 28);
            // 
            // deleteEpochButton
            // 
            this.deleteEpochButton.Name = "deleteEpochButton";
            this.deleteEpochButton.Size = new System.Drawing.Size(195, 26);
            this.deleteEpochButton.Text = "Удалить";
            this.deleteEpochButton.Click += new System.EventHandler(this.deleteEpochButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(354, 6);
            // 
            // changeTValue
            // 
            this.changeTValue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTValue,
            this.acceptNewTValue});
            this.changeTValue.Name = "changeTValue";
            this.changeTValue.Size = new System.Drawing.Size(357, 26);
            this.changeTValue.Text = "Изменить значение T";
            // 
            // newTValue
            // 
            this.newTValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newTValue.Name = "newTValue";
            this.newTValue.Size = new System.Drawing.Size(100, 27);
            this.newTValue.Enter += new System.EventHandler(this.newTValue_Enter);
            this.newTValue.Leave += new System.EventHandler(this.newTValue_Enter);
            this.newTValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newTValue_KeyPress);
            // 
            // acceptNewTValue
            // 
            this.acceptNewTValue.Name = "acceptNewTValue";
            this.acceptNewTValue.Size = new System.Drawing.Size(174, 26);
            this.acceptNewTValue.Text = "Применить";
            this.acceptNewTValue.Click += new System.EventHandler(this.newTValue_Enter);
            // 
            // changeAValue
            // 
            this.changeAValue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAValue,
            this.acceptNewAValue});
            this.changeAValue.Name = "changeAValue";
            this.changeAValue.Size = new System.Drawing.Size(357, 26);
            this.changeAValue.Text = "Изменить значение a";
            // 
            // newAValue
            // 
            this.newAValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newAValue.Name = "newAValue";
            this.newAValue.Size = new System.Drawing.Size(100, 27);
            this.newAValue.Enter += new System.EventHandler(this.newAValue_Enter);
            this.newAValue.Leave += new System.EventHandler(this.newAValue_Enter);
            this.newAValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newAValue_KeyPress);
            // 
            // acceptNewAValue
            // 
            this.acceptNewAValue.Name = "acceptNewAValue";
            this.acceptNewAValue.Size = new System.Drawing.Size(174, 26);
            this.acceptNewAValue.Text = "Применить";
            this.acceptNewAValue.Click += new System.EventHandler(this.newAValue_Enter);
            // 
            // changeBuildingsCount
            // 
            this.changeBuildingsCount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBlocksCount,
            this.acceptNewBlocksCount});
            this.changeBuildingsCount.Name = "changeBuildingsCount";
            this.changeBuildingsCount.Size = new System.Drawing.Size(357, 26);
            this.changeBuildingsCount.Text = "Изменить количество объектов";
            // 
            // newBlocksCount
            // 
            this.newBlocksCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newBlocksCount.Name = "newBlocksCount";
            this.newBlocksCount.Size = new System.Drawing.Size(100, 27);
            this.newBlocksCount.Enter += new System.EventHandler(this.newBlocksCount_Enter);
            this.newBlocksCount.Leave += new System.EventHandler(this.newBlocksCount_Enter);
            this.newBlocksCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newBlocksCount_KeyPress);
            // 
            // acceptNewBlocksCount
            // 
            this.acceptNewBlocksCount.Name = "acceptNewBlocksCount";
            this.acceptNewBlocksCount.Size = new System.Drawing.Size(174, 26);
            this.acceptNewBlocksCount.Text = "Применить";
            this.acceptNewBlocksCount.Click += new System.EventHandler(this.newBlocksCount_Enter);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(354, 6);
            // 
            // changeElevatorTablePath
            // 
            this.changeElevatorTablePath.Name = "changeElevatorTablePath";
            this.changeElevatorTablePath.Size = new System.Drawing.Size(357, 26);
            this.changeElevatorTablePath.Text = "Указать новую таблицу";
            this.changeElevatorTablePath.Click += new System.EventHandler(this.changeElevatorTablePath_Click);
            // 
            // changeObjectPicture
            // 
            this.changeObjectPicture.Name = "changeObjectPicture";
            this.changeObjectPicture.Size = new System.Drawing.Size(357, 26);
            this.changeObjectPicture.Text = "Указать новую схему объекта";
            this.changeObjectPicture.Click += new System.EventHandler(this.changeObjectPicture_Click);
            // 
            // changeTxtFile
            // 
            this.changeTxtFile.Name = "changeTxtFile";
            this.changeTxtFile.Size = new System.Drawing.Size(357, 26);
            this.changeTxtFile.Text = "Указать новый файл с документацией";
            this.changeTxtFile.Click += new System.EventHandler(this.changeTxtFile_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartButton,
            this.expSmoothChartButton,
            this.toolStripSeparator6,
            this.phaseCoordinates});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(58, 24);
            this.windowsMenu.Text = "Окна";
            // 
            // chartButton
            // 
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(381, 26);
            this.chartButton.Text = "График z(t) + Прогноз";
            this.chartButton.Click += new System.EventHandler(this.chartButton_Click);
            // 
            // expSmoothChartButton
            // 
            this.expSmoothChartButton.Name = "expSmoothChartButton";
            this.expSmoothChartButton.Size = new System.Drawing.Size(381, 26);
            this.expSmoothChartButton.Text = "График экспоненциального сглаживания";
            this.expSmoothChartButton.Click += new System.EventHandler(this.expSmoothChartButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(378, 6);
            // 
            // phaseCoordinates
            // 
            this.phaseCoordinates.Name = "phaseCoordinates";
            this.phaseCoordinates.Size = new System.Drawing.Size(381, 26);
            this.phaseCoordinates.Text = "Проверка";
            this.phaseCoordinates.Click += new System.EventHandler(this.checkValues_Click);
            // 
            // refMenu
            // 
            this.refMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13,
            this.aboutProgramButton,
            this.toolStripSeparator3,
            this.infoAboutSystem});
            this.refMenu.Name = "refMenu";
            this.refMenu.Size = new System.Drawing.Size(81, 24);
            this.refMenu.Text = "Справка";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(265, 26);
            this.toolStripMenuItem13.Text = "Справка по программе...";
            // 
            // aboutProgramButton
            // 
            this.aboutProgramButton.Name = "aboutProgramButton";
            this.aboutProgramButton.Size = new System.Drawing.Size(265, 26);
            this.aboutProgramButton.Text = "О программе...";
            this.aboutProgramButton.Click += new System.EventHandler(this.aboutProgramButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(262, 6);
            // 
            // infoAboutSystem
            // 
            this.infoAboutSystem.Name = "infoAboutSystem";
            this.infoAboutSystem.Size = new System.Drawing.Size(265, 26);
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
            this.tabContol.Location = new System.Drawing.Point(0, 28);
            this.tabContol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabContol.Name = "tabContol";
            this.tabContol.SelectedIndex = 0;
            this.tabContol.Size = new System.Drawing.Size(1308, 514);
            this.tabContol.TabIndex = 1;
            // 
            // dataPage
            // 
            this.dataPage.Controls.Add(this.panel3);
            this.dataPage.Controls.Add(this.panel2);
            this.dataPage.Controls.Add(this.panel1);
            this.dataPage.Controls.Add(this.pictureBox3);
            this.dataPage.Controls.Add(this.noImageIcon);
            this.dataPage.Controls.Add(this.noDBConnectionIcon);
            this.dataPage.Controls.Add(this.markCount);
            this.dataPage.Controls.Add(this.buildingCountValue);
            this.dataPage.Controls.Add(this.valueOfALabel);
            this.dataPage.Controls.Add(this.valueOfTLabel);
            this.dataPage.Controls.Add(this.label3);
            this.dataPage.Location = new System.Drawing.Point(4, 25);
            this.dataPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataPage.Name = "dataPage";
            this.dataPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataPage.Size = new System.Drawing.Size(1300, 483);
            this.dataPage.TabIndex = 0;
            this.dataPage.Text = "Данные";
            this.dataPage.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedRowsButton
            // 
            this.deleteSelectedRowsButton.Location = new System.Drawing.Point(313, 54);
            this.deleteSelectedRowsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteSelectedRowsButton.Name = "deleteSelectedRowsButton";
            this.deleteSelectedRowsButton.Size = new System.Drawing.Size(119, 50);
            this.deleteSelectedRowsButton.TabIndex = 13;
            this.deleteSelectedRowsButton.Text = "Удалить выделенные";
            this.deleteSelectedRowsButton.UseVisualStyleBackColor = true;
            this.deleteSelectedRowsButton.Click += new System.EventHandler(this.deleteSelectedRowsButton_Click);
            // 
            // markCount
            // 
            this.markCount.AutoSize = true;
            this.markCount.BackColor = System.Drawing.Color.White;
            this.markCount.Location = new System.Drawing.Point(8, 116);
            this.markCount.Name = "markCount";
            this.markCount.Size = new System.Drawing.Size(0, 16);
            this.markCount.TabIndex = 12;
            // 
            // buildingCountValue
            // 
            this.buildingCountValue.AutoSize = true;
            this.buildingCountValue.BackColor = System.Drawing.Color.White;
            this.buildingCountValue.Location = new System.Drawing.Point(8, 94);
            this.buildingCountValue.Name = "buildingCountValue";
            this.buildingCountValue.Size = new System.Drawing.Size(0, 16);
            this.buildingCountValue.TabIndex = 11;
            // 
            // valueOfALabel
            // 
            this.valueOfALabel.AutoSize = true;
            this.valueOfALabel.BackColor = System.Drawing.Color.White;
            this.valueOfALabel.Location = new System.Drawing.Point(185, 53);
            this.valueOfALabel.Name = "valueOfALabel";
            this.valueOfALabel.Size = new System.Drawing.Size(0, 16);
            this.valueOfALabel.TabIndex = 10;
            // 
            // valueOfTLabel
            // 
            this.valueOfTLabel.AutoSize = true;
            this.valueOfTLabel.BackColor = System.Drawing.Color.White;
            this.valueOfTLabel.Location = new System.Drawing.Point(8, 53);
            this.valueOfTLabel.Name = "valueOfTLabel";
            this.valueOfTLabel.Size = new System.Drawing.Size(0, 16);
            this.valueOfTLabel.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Начальные данные";
            // 
            // DeleteLastEpoch
            // 
            this.DeleteLastEpoch.Location = new System.Drawing.Point(159, 54);
            this.DeleteLastEpoch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteLastEpoch.Name = "DeleteLastEpoch";
            this.DeleteLastEpoch.Size = new System.Drawing.Size(148, 50);
            this.DeleteLastEpoch.TabIndex = 5;
            this.DeleteLastEpoch.Text = "Удалить последнюю эпоху";
            this.DeleteLastEpoch.UseVisualStyleBackColor = true;
            this.DeleteLastEpoch.Click += new System.EventHandler(this.deleteLastEpoch_Click);
            // 
            // AddNewEpochButton
            // 
            this.AddNewEpochButton.Location = new System.Drawing.Point(5, 54);
            this.AddNewEpochButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddNewEpochButton.Name = "AddNewEpochButton";
            this.AddNewEpochButton.Size = new System.Drawing.Size(148, 50);
            this.AddNewEpochButton.TabIndex = 4;
            this.AddNewEpochButton.Text = "Добавить эпоху";
            this.AddNewEpochButton.UseVisualStyleBackColor = true;
            this.AddNewEpochButton.Click += new System.EventHandler(this.addNewRow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(391, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Схема объекта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица высот";
            // 
            // elevatorTable
            // 
            this.elevatorTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.elevatorTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.elevatorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elevatorTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elevatorTable.Location = new System.Drawing.Point(0, 0);
            this.elevatorTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elevatorTable.Name = "elevatorTable";
            this.elevatorTable.RowHeadersWidth = 51;
            this.elevatorTable.RowTemplate.Height = 24;
            this.elevatorTable.Size = new System.Drawing.Size(1289, 212);
            this.elevatorTable.TabIndex = 0;
            this.elevatorTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.elevatorTable_CellEndEdit);
            this.elevatorTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.elevatorTable_DataBindingComplete);
            this.elevatorTable.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.elevatorTable_EditingControlShowing);
            // 
            // firstLevelDecompositionTable
            // 
            this.firstLevelDecompositionTable.Controls.Add(this.firstLevelOfDecompositionTable);
            this.firstLevelDecompositionTable.Location = new System.Drawing.Point(4, 25);
            this.firstLevelDecompositionTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstLevelDecompositionTable.Name = "firstLevelDecompositionTable";
            this.firstLevelDecompositionTable.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstLevelDecompositionTable.Size = new System.Drawing.Size(1300, 485);
            this.firstLevelDecompositionTable.TabIndex = 1;
            this.firstLevelDecompositionTable.Text = "Уровень 1";
            this.firstLevelDecompositionTable.UseVisualStyleBackColor = true;
            this.firstLevelDecompositionTable.Enter += new System.EventHandler(this.firstLevelDecomposition_Enter);
            // 
            // firstLevelOfDecompositionTable
            // 
            this.firstLevelOfDecompositionTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.firstLevelOfDecompositionTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.firstLevelOfDecompositionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firstLevelOfDecompositionTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstLevelOfDecompositionTable.Location = new System.Drawing.Point(3, 2);
            this.firstLevelOfDecompositionTable.Margin = new System.Windows.Forms.Padding(4);
            this.firstLevelOfDecompositionTable.Name = "firstLevelOfDecompositionTable";
            this.firstLevelOfDecompositionTable.RowHeadersWidth = 51;
            this.firstLevelOfDecompositionTable.Size = new System.Drawing.Size(1294, 481);
            this.firstLevelOfDecompositionTable.TabIndex = 0;
            // 
            // secondLevel
            // 
            this.secondLevel.Controls.Add(this.secondLevelOfDecompositionTable);
            this.secondLevel.Controls.Add(this.reSortMarksPanel);
            this.secondLevel.Controls.Add(this.sortMarksGroupBox);
            this.secondLevel.Controls.Add(this.objectDiagram);
            this.secondLevel.Location = new System.Drawing.Point(4, 25);
            this.secondLevel.Margin = new System.Windows.Forms.Padding(4);
            this.secondLevel.Name = "secondLevel";
            this.secondLevel.Padding = new System.Windows.Forms.Padding(4);
            this.secondLevel.Size = new System.Drawing.Size(1300, 485);
            this.secondLevel.TabIndex = 2;
            this.secondLevel.Text = "Уровень 2";
            this.secondLevel.UseVisualStyleBackColor = true;
            this.secondLevel.Enter += new System.EventHandler(this.secondLevel_Enter);
            // 
            // reSortMarksPanel
            // 
            this.reSortMarksPanel.Controls.Add(this.label7);
            this.reSortMarksPanel.Controls.Add(this.reSortMarks);
            this.reSortMarksPanel.Controls.Add(this.chooseBlock);
            this.reSortMarksPanel.Location = new System.Drawing.Point(532, 7);
            this.reSortMarksPanel.Margin = new System.Windows.Forms.Padding(4);
            this.reSortMarksPanel.Name = "reSortMarksPanel";
            this.reSortMarksPanel.Size = new System.Drawing.Size(753, 76);
            this.reSortMarksPanel.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Выберите блок:";
            // 
            // reSortMarks
            // 
            this.reSortMarks.Location = new System.Drawing.Point(5, 4);
            this.reSortMarks.Margin = new System.Windows.Forms.Padding(4);
            this.reSortMarks.Name = "reSortMarks";
            this.reSortMarks.Size = new System.Drawing.Size(744, 28);
            this.reSortMarks.TabIndex = 11;
            this.reSortMarks.Text = "Перераспределить марки";
            this.reSortMarks.UseVisualStyleBackColor = true;
            this.reSortMarks.Click += new System.EventHandler(this.reSortMarks_Click);
            // 
            // chooseBlock
            // 
            this.chooseBlock.FormattingEnabled = true;
            this.chooseBlock.Location = new System.Drawing.Point(123, 38);
            this.chooseBlock.Margin = new System.Windows.Forms.Padding(4);
            this.chooseBlock.Name = "chooseBlock";
            this.chooseBlock.Size = new System.Drawing.Size(612, 24);
            this.chooseBlock.TabIndex = 9;
            this.chooseBlock.SelectedIndexChanged += new System.EventHandler(this.chooseBlock_SelectedIndexChanged);
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
            this.sortMarksGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.sortMarksGroupBox.Location = new System.Drawing.Point(4, 4);
            this.sortMarksGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.sortMarksGroupBox.Name = "sortMarksGroupBox";
            this.sortMarksGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.sortMarksGroupBox.Size = new System.Drawing.Size(520, 477);
            this.sortMarksGroupBox.TabIndex = 12;
            this.sortMarksGroupBox.TabStop = false;
            this.sortMarksGroupBox.Text = "Сгруппируйте марки";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(279, 92);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.MaximumSize = new System.Drawing.Size(147, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 32);
            this.label15.TabIndex = 12;
            this.label15.Text = "Рассортированные марки";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 124);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.MaximumSize = new System.Drawing.Size(200, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 32);
            this.label14.TabIndex = 11;
            this.label14.Text = "Все доступные марки объекта";
            // 
            // marksBox
            // 
            this.marksBox.FormattingEnabled = true;
            this.marksBox.ItemHeight = 16;
            this.marksBox.Location = new System.Drawing.Point(8, 160);
            this.marksBox.Margin = new System.Windows.Forms.Padding(4);
            this.marksBox.Name = "marksBox";
            this.marksBox.Size = new System.Drawing.Size(208, 276);
            this.marksBox.TabIndex = 0;
            this.marksBox.DoubleClick += new System.EventHandler(this.marksBox_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "   ";
            // 
            // removeMarkFromBlock
            // 
            this.removeMarkFromBlock.Location = new System.Drawing.Point(231, 265);
            this.removeMarkFromBlock.Margin = new System.Windows.Forms.Padding(4);
            this.removeMarkFromBlock.Name = "removeMarkFromBlock";
            this.removeMarkFromBlock.Size = new System.Drawing.Size(41, 28);
            this.removeMarkFromBlock.TabIndex = 6;
            this.removeMarkFromBlock.Text = "<-";
            this.removeMarkFromBlock.UseVisualStyleBackColor = true;
            this.removeMarkFromBlock.Click += new System.EventHandler(this.removeMarkFromBlock_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "    ";
            // 
            // addMarkToBlock
            // 
            this.addMarkToBlock.Location = new System.Drawing.Point(231, 229);
            this.addMarkToBlock.Margin = new System.Windows.Forms.Padding(4);
            this.addMarkToBlock.Name = "addMarkToBlock";
            this.addMarkToBlock.Size = new System.Drawing.Size(41, 28);
            this.addMarkToBlock.TabIndex = 5;
            this.addMarkToBlock.Text = "->";
            this.addMarkToBlock.UseVisualStyleBackColor = true;
            this.addMarkToBlock.Click += new System.EventHandler(this.addMarkToBlock_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "  ";
            // 
            // sortedMarks
            // 
            this.sortedMarks.FormattingEnabled = true;
            this.sortedMarks.ItemHeight = 16;
            this.sortedMarks.Location = new System.Drawing.Point(280, 160);
            this.sortedMarks.Margin = new System.Windows.Forms.Padding(4);
            this.sortedMarks.Name = "sortedMarks";
            this.sortedMarks.Size = new System.Drawing.Size(225, 276);
            this.sortedMarks.TabIndex = 2;
            // 
            // secondLevelOfDecompositionTable
            // 
            this.secondLevelOfDecompositionTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondLevelOfDecompositionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secondLevelOfDecompositionTable.Location = new System.Drawing.Point(8, 91);
            this.secondLevelOfDecompositionTable.Margin = new System.Windows.Forms.Padding(4);
            this.secondLevelOfDecompositionTable.Name = "secondLevelOfDecompositionTable";
            this.secondLevelOfDecompositionTable.RowHeadersWidth = 51;
            this.secondLevelOfDecompositionTable.Size = new System.Drawing.Size(1277, 378);
            this.secondLevelOfDecompositionTable.TabIndex = 8;
            // 
            // thirdLevel
            // 
            this.thirdLevel.Controls.Add(this.levelThirdPanel);
            this.thirdLevel.Controls.Add(this.defaultMessage2);
            this.thirdLevel.Controls.Add(this.dataGridView1);
            this.thirdLevel.Location = new System.Drawing.Point(4, 25);
            this.thirdLevel.Margin = new System.Windows.Forms.Padding(4);
            this.thirdLevel.Name = "thirdLevel";
            this.thirdLevel.Padding = new System.Windows.Forms.Padding(4);
            this.thirdLevel.Size = new System.Drawing.Size(1300, 485);
            this.thirdLevel.TabIndex = 3;
            this.thirdLevel.Text = "Уровень 3";
            this.thirdLevel.UseVisualStyleBackColor = true;
            this.thirdLevel.Enter += new System.EventHandler(this.thirdLevel_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(296, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(989, 452);
            this.dataGridView1.TabIndex = 29;
            // 
            // levelThirdPanel
            // 
            this.levelThirdPanel.Controls.Add(this.subblockSettingPanel);
            this.levelThirdPanel.Controls.Add(this.nextStageButton);
            this.levelThirdPanel.Controls.Add(this.listBox1);
            this.levelThirdPanel.Controls.Add(this.strongConnectionsListBox);
            this.levelThirdPanel.Controls.Add(this.removeMarkFromSubblock);
            this.levelThirdPanel.Controls.Add(this.label12);
            this.levelThirdPanel.Controls.Add(this.chooseBlockLabel);
            this.levelThirdPanel.Controls.Add(this.addConnectionToSubblock);
            this.levelThirdPanel.Controls.Add(this.chooseBlock3);
            this.levelThirdPanel.Controls.Add(this.distanceBetweenMarks);
            this.levelThirdPanel.Controls.Add(this.marksExcess);
            this.levelThirdPanel.Controls.Add(this.blockLabel);
            this.levelThirdPanel.Controls.Add(this.label11);
            this.levelThirdPanel.Controls.Add(this.marksOnSubblocksListBox);
            this.levelThirdPanel.Controls.Add(this.label10);
            this.levelThirdPanel.Location = new System.Drawing.Point(4, 4);
            this.levelThirdPanel.Margin = new System.Windows.Forms.Padding(4);
            this.levelThirdPanel.Name = "levelThirdPanel";
            this.levelThirdPanel.Size = new System.Drawing.Size(1291, 470);
            this.levelThirdPanel.TabIndex = 28;
            // 
            // subblockSettingPanel
            // 
            this.subblockSettingPanel.Controls.Add(this.acceptButton);
            this.subblockSettingPanel.Controls.Add(this.textBox2);
            this.subblockSettingPanel.Controls.Add(this.textBox1);
            this.subblockSettingPanel.Controls.Add(this.label16);
            this.subblockSettingPanel.Controls.Add(this.label13);
            this.subblockSettingPanel.Location = new System.Drawing.Point(8, 305);
            this.subblockSettingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.subblockSettingPanel.Name = "subblockSettingPanel";
            this.subblockSettingPanel.Size = new System.Drawing.Size(280, 153);
            this.subblockSettingPanel.TabIndex = 30;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(8, 101);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(268, 48);
            this.acceptButton.TabIndex = 31;
            this.acceptButton.Text = "Подтвердить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 69);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 62);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.MaximumSize = new System.Drawing.Size(133, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 32);
            this.label16.TabIndex = 1;
            this.label16.Text = "Марок на подблоке";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 11);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.MaximumSize = new System.Drawing.Size(133, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 32);
            this.label13.TabIndex = 0;
            this.label13.Text = "Количество подблоков";
            // 
            // nextStageButton
            // 
            this.nextStageButton.Location = new System.Drawing.Point(5, 245);
            this.nextStageButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextStageButton.Name = "nextStageButton";
            this.nextStageButton.Size = new System.Drawing.Size(283, 53);
            this.nextStageButton.TabIndex = 29;
            this.nextStageButton.Text = "Продолжить";
            this.nextStageButton.UseVisualStyleBackColor = true;
            this.nextStageButton.Click += new System.EventHandler(this.nextStageButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(5, 73);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(113, 164);
            this.listBox1.TabIndex = 28;
            // 
            // strongConnectionsListBox
            // 
            this.strongConnectionsListBox.FormattingEnabled = true;
            this.strongConnectionsListBox.ItemHeight = 16;
            this.strongConnectionsListBox.Location = new System.Drawing.Point(1116, 42);
            this.strongConnectionsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.strongConnectionsListBox.Name = "strongConnectionsListBox";
            this.strongConnectionsListBox.Size = new System.Drawing.Size(164, 420);
            this.strongConnectionsListBox.TabIndex = 21;
            // 
            // removeMarkFromSubblock
            // 
            this.removeMarkFromSubblock.Location = new System.Drawing.Point(128, 209);
            this.removeMarkFromSubblock.Margin = new System.Windows.Forms.Padding(4);
            this.removeMarkFromSubblock.Name = "removeMarkFromSubblock";
            this.removeMarkFromSubblock.Size = new System.Drawing.Size(41, 28);
            this.removeMarkFromSubblock.TabIndex = 27;
            this.removeMarkFromSubblock.Text = "<-";
            this.removeMarkFromSubblock.UseVisualStyleBackColor = true;
            this.removeMarkFromSubblock.Click += new System.EventHandler(this.removeMarkFromSubblock_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1112, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Крепкие связи";
            // 
            // chooseBlockLabel
            // 
            this.chooseBlockLabel.AutoSize = true;
            this.chooseBlockLabel.Location = new System.Drawing.Point(4, 20);
            this.chooseBlockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chooseBlockLabel.Name = "chooseBlockLabel";
            this.chooseBlockLabel.Size = new System.Drawing.Size(109, 16);
            this.chooseBlockLabel.TabIndex = 14;
            this.chooseBlockLabel.Text = "Выберите блок:";
            // 
            // addConnectionToSubblock
            // 
            this.addConnectionToSubblock.Location = new System.Drawing.Point(128, 73);
            this.addConnectionToSubblock.Margin = new System.Windows.Forms.Padding(4);
            this.addConnectionToSubblock.Name = "addConnectionToSubblock";
            this.addConnectionToSubblock.Size = new System.Drawing.Size(41, 28);
            this.addConnectionToSubblock.TabIndex = 26;
            this.addConnectionToSubblock.Text = "->";
            this.addConnectionToSubblock.UseVisualStyleBackColor = true;
            this.addConnectionToSubblock.Click += new System.EventHandler(this.addConnectionToSubblock_Click);
            // 
            // chooseBlock3
            // 
            this.chooseBlock3.FormattingEnabled = true;
            this.chooseBlock3.Location = new System.Drawing.Point(4, 39);
            this.chooseBlock3.Margin = new System.Windows.Forms.Padding(4);
            this.chooseBlock3.Name = "chooseBlock3";
            this.chooseBlock3.Size = new System.Drawing.Size(115, 24);
            this.chooseBlock3.TabIndex = 13;
            this.chooseBlock3.SelectedIndexChanged += new System.EventHandler(this.chooseBlock3_SelectedIndexChanged);
            // 
            // distanceBetweenMarks
            // 
            this.distanceBetweenMarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.distanceBetweenMarks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.distanceBetweenMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.distanceBetweenMarks.Location = new System.Drawing.Point(295, 42);
            this.distanceBetweenMarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.distanceBetweenMarks.Name = "distanceBetweenMarks";
            this.distanceBetweenMarks.RowHeadersWidth = 51;
            this.distanceBetweenMarks.RowTemplate.Height = 24;
            this.distanceBetweenMarks.Size = new System.Drawing.Size(816, 149);
            this.distanceBetweenMarks.TabIndex = 16;
            // 
            // marksExcess
            // 
            this.marksExcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.marksExcess.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.marksExcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marksExcess.Location = new System.Drawing.Point(295, 223);
            this.marksExcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marksExcess.Name = "marksExcess";
            this.marksExcess.RowHeadersWidth = 51;
            this.marksExcess.RowTemplate.Height = 24;
            this.marksExcess.Size = new System.Drawing.Size(816, 235);
            this.marksExcess.TabIndex = 17;
            // 
            // blockLabel
            // 
            this.blockLabel.AutoSize = true;
            this.blockLabel.Location = new System.Drawing.Point(172, 5);
            this.blockLabel.MaximumSize = new System.Drawing.Size(133, 0);
            this.blockLabel.Name = "blockLabel";
            this.blockLabel.Size = new System.Drawing.Size(39, 16);
            this.blockLabel.TabIndex = 24;
            this.blockLabel.Text = "Блок";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Таблица превышений";
            // 
            // marksOnSubblocksListBox
            // 
            this.marksOnSubblocksListBox.FormattingEnabled = true;
            this.marksOnSubblocksListBox.ItemHeight = 16;
            this.marksOnSubblocksListBox.Location = new System.Drawing.Point(176, 38);
            this.marksOnSubblocksListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marksOnSubblocksListBox.Name = "marksOnSubblocksListBox";
            this.marksOnSubblocksListBox.Size = new System.Drawing.Size(112, 196);
            this.marksOnSubblocksListBox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Таблица расстояния между точками";
            // 
            // defaultMessage2
            // 
            this.defaultMessage2.AutoSize = true;
            this.defaultMessage2.Location = new System.Drawing.Point(260, 15);
            this.defaultMessage2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.defaultMessage2.Name = "defaultMessage2";
            this.defaultMessage2.Size = new System.Drawing.Size(325, 16);
            this.defaultMessage2.TabIndex = 15;
            this.defaultMessage2.Text = "Сначала распределите марки на втором уровне";
            // 
            // fourthLevel
            // 
            this.fourthLevel.Controls.Add(this.fourthLevelChartPanel);
            this.fourthLevel.Controls.Add(this.defaultMessage);
            this.fourthLevel.Location = new System.Drawing.Point(4, 25);
            this.fourthLevel.Margin = new System.Windows.Forms.Padding(4);
            this.fourthLevel.Name = "fourthLevel";
            this.fourthLevel.Padding = new System.Windows.Forms.Padding(4);
            this.fourthLevel.Size = new System.Drawing.Size(1300, 485);
            this.fourthLevel.TabIndex = 4;
            this.fourthLevel.Text = "Уровень 4";
            this.fourthLevel.UseVisualStyleBackColor = true;
            this.fourthLevel.Enter += new System.EventHandler(this.fourthLevel_Enter);
            // 
            // fourthLevelChartPanel
            // 
            this.fourthLevelChartPanel.Controls.Add(this.panel5);
            this.fourthLevelChartPanel.Controls.Add(this.chooseBlock2);
            this.fourthLevelChartPanel.Controls.Add(this.chooseBlockMessage);
            this.fourthLevelChartPanel.Controls.Add(this.panel4);
            this.fourthLevelChartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourthLevelChartPanel.Location = new System.Drawing.Point(4, 4);
            this.fourthLevelChartPanel.Margin = new System.Windows.Forms.Padding(4);
            this.fourthLevelChartPanel.Name = "fourthLevelChartPanel";
            this.fourthLevelChartPanel.Size = new System.Drawing.Size(1292, 477);
            this.fourthLevelChartPanel.TabIndex = 18;
            // 
            // chooseBlock2
            // 
            this.chooseBlock2.FormattingEnabled = true;
            this.chooseBlock2.Location = new System.Drawing.Point(122, 16);
            this.chooseBlock2.Margin = new System.Windows.Forms.Padding(4);
            this.chooseBlock2.Name = "chooseBlock2";
            this.chooseBlock2.Size = new System.Drawing.Size(160, 24);
            this.chooseBlock2.TabIndex = 11;
            this.chooseBlock2.SelectedIndexChanged += new System.EventHandler(this.chooseBlock2_SelectedIndexChanged);
            // 
            // chooseBlockMessage
            // 
            this.chooseBlockMessage.AutoSize = true;
            this.chooseBlockMessage.Location = new System.Drawing.Point(5, 16);
            this.chooseBlockMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chooseBlockMessage.Name = "chooseBlockMessage";
            this.chooseBlockMessage.Size = new System.Drawing.Size(109, 16);
            this.chooseBlockMessage.TabIndex = 12;
            this.chooseBlockMessage.Text = "Выберите блок:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Доступные марки";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 210);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Отображенные марки";
            // 
            // availableMarks
            // 
            this.availableMarks.FormattingEnabled = true;
            this.availableMarks.ItemHeight = 16;
            this.availableMarks.Location = new System.Drawing.Point(13, 31);
            this.availableMarks.Margin = new System.Windows.Forms.Padding(4);
            this.availableMarks.Name = "availableMarks";
            this.availableMarks.Size = new System.Drawing.Size(167, 148);
            this.availableMarks.TabIndex = 14;
            this.availableMarks.DoubleClick += new System.EventHandler(this.availableMarks_DoubleClick);
            // 
            // displayedMarks
            // 
            this.displayedMarks.FormattingEnabled = true;
            this.displayedMarks.ItemHeight = 16;
            this.displayedMarks.Location = new System.Drawing.Point(16, 230);
            this.displayedMarks.Margin = new System.Windows.Forms.Padding(4);
            this.displayedMarks.Name = "displayedMarks";
            this.displayedMarks.Size = new System.Drawing.Size(167, 212);
            this.displayedMarks.TabIndex = 15;
            this.displayedMarks.DoubleClick += new System.EventHandler(this.displayedMarks_DoubleClick);
            // 
            // fourthLevelChart
            // 
            chartArea1.Name = "ChartArea1";
            this.fourthLevelChart.ChartAreas.Add(chartArea1);
            this.fourthLevelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.fourthLevelChart.Legends.Add(legend1);
            this.fourthLevelChart.Location = new System.Drawing.Point(0, 0);
            this.fourthLevelChart.Margin = new System.Windows.Forms.Padding(4);
            this.fourthLevelChart.Name = "fourthLevelChart";
            this.fourthLevelChart.Size = new System.Drawing.Size(1086, 427);
            this.fourthLevelChart.TabIndex = 0;
            this.fourthLevelChart.Text = "chart1";
            // 
            // defaultMessage
            // 
            this.defaultMessage.AutoSize = true;
            this.defaultMessage.Location = new System.Drawing.Point(313, 5);
            this.defaultMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.defaultMessage.Name = "defaultMessage";
            this.defaultMessage.Size = new System.Drawing.Size(325, 16);
            this.defaultMessage.TabIndex = 13;
            this.defaultMessage.Text = "Сначала распределите марки на втором уровне";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.elevatorTable);
            this.panel1.Location = new System.Drawing.Point(3, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 212);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.objectPicture);
            this.panel2.Location = new System.Drawing.Point(782, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 255);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.deleteSelectedRowsButton);
            this.panel3.Controls.Add(this.DeleteLastEpoch);
            this.panel3.Controls.Add(this.AddNewEpochButton);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 111);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.fourthLevelChart);
            this.panel4.Location = new System.Drawing.Point(8, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1086, 427);
            this.panel4.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.availableMarks);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.displayedMarks);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(1097, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(192, 443);
            this.panel5.TabIndex = 19;
            // 
            // objectPicture
            // 
            this.objectPicture.BackColor = System.Drawing.Color.White;
            this.objectPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectPicture.Location = new System.Drawing.Point(0, 0);
            this.objectPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.objectPicture.Name = "objectPicture";
            this.objectPicture.Size = new System.Drawing.Size(510, 255);
            this.objectPicture.TabIndex = 2;
            this.objectPicture.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(292, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 46);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // noImageIcon
            // 
            this.noImageIcon.Image = global::CourseWorkRebuild2.Properties.Resources.noImageIcon;
            this.noImageIcon.Location = new System.Drawing.Point(400, 15);
            this.noImageIcon.Name = "noImageIcon";
            this.noImageIcon.Size = new System.Drawing.Size(48, 46);
            this.noImageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.noImageIcon.TabIndex = 15;
            this.noImageIcon.TabStop = false;
            // 
            // noDBConnectionIcon
            // 
            this.noDBConnectionIcon.Image = global::CourseWorkRebuild2.Properties.Resources.DBErroConnectionIcon;
            this.noDBConnectionIcon.Location = new System.Drawing.Point(346, 15);
            this.noDBConnectionIcon.Name = "noDBConnectionIcon";
            this.noDBConnectionIcon.Size = new System.Drawing.Size(48, 46);
            this.noDBConnectionIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.noDBConnectionIcon.TabIndex = 14;
            this.noDBConnectionIcon.TabStop = false;
            // 
            // objectDiagram
            // 
            this.objectDiagram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectDiagram.Location = new System.Drawing.Point(532, 91);
            this.objectDiagram.Margin = new System.Windows.Forms.Padding(4);
            this.objectDiagram.Name = "objectDiagram";
            this.objectDiagram.Size = new System.Drawing.Size(749, 374);
            this.objectDiagram.TabIndex = 4;
            this.objectDiagram.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 542);
            this.Controls.Add(this.tabContol);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabContol.ResumeLayout(false);
            this.dataPage.ResumeLayout(false);
            this.dataPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorTable)).EndInit();
            this.firstLevelDecompositionTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.firstLevelOfDecompositionTable)).EndInit();
            this.secondLevel.ResumeLayout(false);
            this.reSortMarksPanel.ResumeLayout(false);
            this.reSortMarksPanel.PerformLayout();
            this.sortMarksGroupBox.ResumeLayout(false);
            this.sortMarksGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondLevelOfDecompositionTable)).EndInit();
            this.thirdLevel.ResumeLayout(false);
            this.thirdLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.levelThirdPanel.ResumeLayout(false);
            this.levelThirdPanel.PerformLayout();
            this.subblockSettingPanel.ResumeLayout(false);
            this.subblockSettingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceBetweenMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksExcess)).EndInit();
            this.fourthLevel.ResumeLayout(false);
            this.fourthLevel.PerformLayout();
            this.fourthLevelChartPanel.ResumeLayout(false);
            this.fourthLevelChartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fourthLevelChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noImageIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDBConnectionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDiagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox strongConnectionsListBox;
        private System.Windows.Forms.Label blockLabel;
        private System.Windows.Forms.ListBox marksOnSubblocksListBox;
        private System.Windows.Forms.Button removeMarkFromSubblock;
        private System.Windows.Forms.Button addConnectionToSubblock;
        private System.Windows.Forms.ToolStripMenuItem phaseCoordinates;
        private System.Windows.Forms.GroupBox sortMarksGroupBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel reSortMarksPanel;
        private System.Windows.Forms.Panel fourthLevelChartPanel;
        private System.Windows.Forms.Panel levelThirdPanel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button nextStageButton;
        private System.Windows.Forms.Panel subblockSettingPanel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox noImageIcon;
        private System.Windows.Forms.PictureBox noDBConnectionIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}

