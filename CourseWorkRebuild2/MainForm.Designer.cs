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
            this.changeAValue = new System.Windows.Forms.ToolStripMenuItem();
            this.newAValue = new System.Windows.Forms.ToolStripTextBox();
            this.changeBuildingsCount = new System.Windows.Forms.ToolStripMenuItem();
            this.newBlocksCount = new System.Windows.Forms.ToolStripTextBox();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.refMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.infoAboutSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataPage = new System.Windows.Forms.TabPage();
            this.valueOfALabel = new System.Windows.Forms.Label();
            this.valueOfTLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteLastEpoch = new System.Windows.Forms.Button();
            this.AddNewEpochButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.objectPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.elevatorTable = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.acceptNewTValue = new System.Windows.Forms.ToolStripMenuItem();
            this.acceptNewAValue = new System.Windows.Forms.ToolStripMenuItem();
            this.acceptNewBlocksCount = new System.Windows.Forms.ToolStripMenuItem();
            this.buildingCountValue = new System.Windows.Forms.Label();
            this.markCount = new System.Windows.Forms.Label();
            this.changeElevatorTablePath = new System.Windows.Forms.ToolStripMenuItem();
            this.changeObjectPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.dataPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorTable)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(840, 28);
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
            this.fileMenu.Size = new System.Drawing.Size(59, 24);
            this.fileMenu.Text = "Файл";
            // 
            // createButton
            // 
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(278, 26);
            this.createButton.Text = "Создать...";
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
            this.changeObjectPicture});
            this.redactorMenu.Name = "redactorMenu";
            this.redactorMenu.Size = new System.Drawing.Size(137, 24);
            this.redactorMenu.Text = "Редактирование";
            // 
            // addEpochButton
            // 
            this.addEpochButton.Name = "addEpochButton";
            this.addEpochButton.Size = new System.Drawing.Size(313, 26);
            this.addEpochButton.Text = "Добавить эпоху";
            this.addEpochButton.Click += new System.EventHandler(this.addNewRow_Click);
            // 
            // chooseEpochToDelete
            // 
            this.chooseEpochToDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.epochCountBox,
            this.deleteEpochButton});
            this.chooseEpochToDelete.Name = "chooseEpochToDelete";
            this.chooseEpochToDelete.Size = new System.Drawing.Size(313, 26);
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
            this.deleteEpochButton.Size = new System.Drawing.Size(224, 26);
            this.deleteEpochButton.Text = "Удалить";
            this.deleteEpochButton.Click += new System.EventHandler(this.deleteEpochButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(310, 6);
            // 
            // changeTValue
            // 
            this.changeTValue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTValue,
            this.acceptNewTValue});
            this.changeTValue.Name = "changeTValue";
            this.changeTValue.Size = new System.Drawing.Size(313, 26);
            this.changeTValue.Text = "Изменить значение T";
            this.changeTValue.Click += new System.EventHandler(this.changeTValueButton_Click);
            // 
            // newTValue
            // 
            this.newTValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newTValue.Name = "newTValue";
            this.newTValue.Size = new System.Drawing.Size(100, 27);
            this.newTValue.Enter += new System.EventHandler(this.newTValue_Enter);
            this.newTValue.Leave += new System.EventHandler(this.newTValue_Enter);
            // 
            // changeAValue
            // 
            this.changeAValue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAValue,
            this.acceptNewAValue});
            this.changeAValue.Name = "changeAValue";
            this.changeAValue.Size = new System.Drawing.Size(313, 26);
            this.changeAValue.Text = "Изменить значение a";
            this.changeAValue.Click += new System.EventHandler(this.changeAValueButton_Click);
            // 
            // newAValue
            // 
            this.newAValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newAValue.Name = "newAValue";
            this.newAValue.Size = new System.Drawing.Size(100, 27);
            this.newAValue.Enter += new System.EventHandler(this.newAValue_Enter);
            this.newAValue.Leave += new System.EventHandler(this.newAValue_Enter);
            // 
            // changeBuildingsCount
            // 
            this.changeBuildingsCount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBlocksCount,
            this.acceptNewBlocksCount});
            this.changeBuildingsCount.Name = "changeBuildingsCount";
            this.changeBuildingsCount.Size = new System.Drawing.Size(313, 26);
            this.changeBuildingsCount.Text = "Изменить количество объектов";
            // 
            // newBlocksCount
            // 
            this.newBlocksCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newBlocksCount.Name = "newBlocksCount";
            this.newBlocksCount.Size = new System.Drawing.Size(100, 27);
            this.newBlocksCount.Enter += new System.EventHandler(this.newBlocksCount_Enter);
            this.newBlocksCount.Leave += new System.EventHandler(this.newBlocksCount_Enter);
            // 
            // windowsMenu
            // 
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(58, 24);
            this.windowsMenu.Text = "Окна";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dataPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 423);
            this.tabControl1.TabIndex = 1;
            // 
            // dataPage
            // 
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
            this.dataPage.Location = new System.Drawing.Point(4, 25);
            this.dataPage.Name = "dataPage";
            this.dataPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataPage.Size = new System.Drawing.Size(832, 394);
            this.dataPage.TabIndex = 0;
            this.dataPage.Text = "Данные";
            this.dataPage.UseVisualStyleBackColor = true;
            // 
            // valueOfALabel
            // 
            this.valueOfALabel.AutoSize = true;
            this.valueOfALabel.BackColor = System.Drawing.Color.White;
            this.valueOfALabel.Location = new System.Drawing.Point(159, 53);
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
            this.DeleteLastEpoch.Location = new System.Drawing.Point(162, 172);
            this.DeleteLastEpoch.Name = "DeleteLastEpoch";
            this.DeleteLastEpoch.Size = new System.Drawing.Size(148, 51);
            this.DeleteLastEpoch.TabIndex = 5;
            this.DeleteLastEpoch.Text = "Удалить последнюю эпоху";
            this.DeleteLastEpoch.UseVisualStyleBackColor = true;
            this.DeleteLastEpoch.Click += new System.EventHandler(this.deleteLastEpoch_Click);
            // 
            // AddNewEpochButton
            // 
            this.AddNewEpochButton.Location = new System.Drawing.Point(8, 172);
            this.AddNewEpochButton.Name = "AddNewEpochButton";
            this.AddNewEpochButton.Size = new System.Drawing.Size(148, 51);
            this.AddNewEpochButton.TabIndex = 4;
            this.AddNewEpochButton.Text = "Добавить эпоху";
            this.AddNewEpochButton.UseVisualStyleBackColor = true;
            this.AddNewEpochButton.Click += new System.EventHandler(this.addNewRow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(621, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Схема объекта";
            // 
            // objectPicture
            // 
            this.objectPicture.BackColor = System.Drawing.Color.White;
            this.objectPicture.Location = new System.Drawing.Point(513, 44);
            this.objectPicture.Name = "objectPicture";
            this.objectPicture.Size = new System.Drawing.Size(311, 179);
            this.objectPicture.TabIndex = 2;
            this.objectPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица высот";
            // 
            // elevatorTable
            // 
            this.elevatorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elevatorTable.Location = new System.Drawing.Point(8, 229);
            this.elevatorTable.Name = "elevatorTable";
            this.elevatorTable.RowHeadersWidth = 51;
            this.elevatorTable.RowTemplate.Height = 24;
            this.elevatorTable.Size = new System.Drawing.Size(816, 159);
            this.elevatorTable.TabIndex = 0;
            this.elevatorTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.elevatorTable_CellEndEdit);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(832, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Уровень 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 451);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.dataPage.ResumeLayout(false);
            this.dataPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorTable)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dataPage;
        private System.Windows.Forms.Button DeleteLastEpoch;
        private System.Windows.Forms.Button AddNewEpochButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox objectPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView elevatorTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem openRarButton;
        private System.Windows.Forms.ToolStripMenuItem deleteEpochButton;
        private System.Windows.Forms.Label valueOfALabel;
        private System.Windows.Forms.Label valueOfTLabel;
        private System.Windows.Forms.Label label3;
    }
}

