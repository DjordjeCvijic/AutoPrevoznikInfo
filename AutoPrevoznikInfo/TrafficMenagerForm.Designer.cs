
namespace AutoPrevoznikInfo
{
    partial class TrafficMenagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrafficMenagerForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tSMILanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSerbian = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWhiteTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDarkTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblWorkerType = new System.Windows.Forms.Label();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlRight = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateDriver = new System.Windows.Forms.Button();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.dGVDrivers = new System.Windows.Forms.DataGridView();
            this.firstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeleteBus = new System.Windows.Forms.Button();
            this.btnEditBus = new System.Windows.Forms.Button();
            this.btnAddBus = new System.Windows.Forms.Button();
            this.dGVBus = new System.Windows.Forms.DataGridView();
            this.busGarageNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfSeatsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfDoorsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busCapacityComun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDeleteShift = new System.Windows.Forms.Button();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.dGVSchedule = new System.Windows.Forms.DataGridView();
            this.firstNameColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerCodeColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busLineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlRight.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDrivers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBus)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMILanguage,
            this.tSMTheme});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tSMILanguage
            // 
            this.tSMILanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSerbian,
            this.tsmiEnglish});
            this.tSMILanguage.Name = "tSMILanguage";
            this.tSMILanguage.Size = new System.Drawing.Size(54, 24);
            this.tSMILanguage.Tag = "";
            this.tSMILanguage.Text = "Jezik";
            // 
            // tsmiSerbian
            // 
            this.tsmiSerbian.Name = "tsmiSerbian";
            this.tsmiSerbian.Size = new System.Drawing.Size(139, 26);
            this.tsmiSerbian.Tag = "S";
            this.tsmiSerbian.Text = "Srpski";
            // 
            // tsmiEnglish
            // 
            this.tsmiEnglish.Name = "tsmiEnglish";
            this.tsmiEnglish.Size = new System.Drawing.Size(139, 26);
            this.tsmiEnglish.Tag = "E";
            this.tsmiEnglish.Text = "English";
            // 
            // tSMTheme
            // 
            this.tSMTheme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWhiteTheme,
            this.tsmiDarkTheme});
            this.tSMTheme.Name = "tSMTheme";
            this.tSMTheme.Size = new System.Drawing.Size(59, 24);
            this.tSMTheme.Text = "Tema";
            // 
            // tsmiWhiteTheme
            // 
            this.tsmiWhiteTheme.Name = "tsmiWhiteTheme";
            this.tsmiWhiteTheme.Size = new System.Drawing.Size(140, 26);
            this.tsmiWhiteTheme.Text = "Svijetla";
            // 
            // tsmiDarkTheme
            // 
            this.tsmiDarkTheme.Name = "tsmiDarkTheme";
            this.tsmiDarkTheme.Size = new System.Drawing.Size(140, 26);
            this.tsmiDarkTheme.Text = "Tamna";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.lblWorkerType);
            this.panelLeft.Controls.Add(this.lblWorkerName);
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 28);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(237, 648);
            this.panelLeft.TabIndex = 3;
            // 
            // lblWorkerType
            // 
            this.lblWorkerType.Location = new System.Drawing.Point(12, 17);
            this.lblWorkerType.Name = "lblWorkerType";
            this.lblWorkerType.Size = new System.Drawing.Size(214, 34);
            this.lblWorkerType.TabIndex = 3;
            this.lblWorkerType.Text = "label2";
            this.lblWorkerType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.Location = new System.Drawing.Point(12, 292);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(214, 34);
            this.lblWorkerName.TabIndex = 2;
            this.lblWorkerName.Text = "label1";
            this.lblWorkerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Silver;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(23, 573);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(188, 46);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.TabStop = false;
            this.btnLogout.Text = "button1";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoPrevoznikInfo.Properties.Resources.korisnik2;
            this.pictureBox1.Location = new System.Drawing.Point(23, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControlRight
            // 
            this.tabControlRight.Controls.Add(this.tabPage1);
            this.tabControlRight.Controls.Add(this.tabPage2);
            this.tabControlRight.Controls.Add(this.tabPage3);
            this.tabControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControlRight.Location = new System.Drawing.Point(243, 28);
            this.tabControlRight.Name = "tabControlRight";
            this.tabControlRight.SelectedIndex = 0;
            this.tabControlRight.Size = new System.Drawing.Size(991, 648);
            this.tabControlRight.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btnSendMessage);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnUpdateDriver);
            this.tabPage1.Controls.Add(this.btnAddWorker);
            this.tabPage1.Controls.Add(this.dGVDrivers);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 615);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vozaci";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.BackColor = System.Drawing.Color.Silver;
            this.btnSendMessage.FlatAppearance.BorderSize = 0;
            this.btnSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMessage.Location = new System.Drawing.Point(793, 340);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(169, 54);
            this.btnSendMessage.TabIndex = 4;
            this.btnSendMessage.TabStop = false;
            this.btnSendMessage.Text = "Posalji poruku";
            this.btnSendMessage.UseVisualStyleBackColor = false;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(793, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 54);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "obrisi";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateDriver
            // 
            this.btnUpdateDriver.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateDriver.FlatAppearance.BorderSize = 0;
            this.btnUpdateDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDriver.Location = new System.Drawing.Point(793, 181);
            this.btnUpdateDriver.Name = "btnUpdateDriver";
            this.btnUpdateDriver.Size = new System.Drawing.Size(169, 54);
            this.btnUpdateDriver.TabIndex = 2;
            this.btnUpdateDriver.Text = "Izmijeni";
            this.btnUpdateDriver.UseVisualStyleBackColor = false;
            this.btnUpdateDriver.Click += new System.EventHandler(this.btnUpdateDriver_Click);
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.BackColor = System.Drawing.Color.Silver;
            this.btnAddWorker.FlatAppearance.BorderSize = 0;
            this.btnAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorker.Location = new System.Drawing.Point(793, 106);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(169, 54);
            this.btnAddWorker.TabIndex = 1;
            this.btnAddWorker.TabStop = false;
            this.btnAddWorker.Text = "dodaj vozaca";
            this.btnAddWorker.UseVisualStyleBackColor = false;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // dGVDrivers
            // 
            this.dGVDrivers.AllowUserToAddRows = false;
            this.dGVDrivers.AllowUserToDeleteRows = false;
            this.dGVDrivers.AllowUserToResizeColumns = false;
            this.dGVDrivers.AllowUserToResizeRows = false;
            this.dGVDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDrivers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVDrivers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDrivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameColumn,
            this.lastNameColumn,
            this.userNameColumn,
            this.phoneNumberColumn,
            this.workerCodeColumn});
            this.dGVDrivers.EnableHeadersVisualStyles = false;
            this.dGVDrivers.Location = new System.Drawing.Point(25, 84);
            this.dGVDrivers.MultiSelect = false;
            this.dGVDrivers.Name = "dGVDrivers";
            this.dGVDrivers.ReadOnly = true;
            this.dGVDrivers.RowHeadersVisible = false;
            this.dGVDrivers.RowHeadersWidth = 51;
            this.dGVDrivers.RowTemplate.Height = 29;
            this.dGVDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDrivers.Size = new System.Drawing.Size(735, 394);
            this.dGVDrivers.TabIndex = 0;
            // 
            // firstNameColumn
            // 
            this.firstNameColumn.HeaderText = "Ime";
            this.firstNameColumn.MinimumWidth = 6;
            this.firstNameColumn.Name = "firstNameColumn";
            this.firstNameColumn.ReadOnly = true;
            this.firstNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lastNameColumn
            // 
            this.lastNameColumn.HeaderText = "Prezime";
            this.lastNameColumn.MinimumWidth = 6;
            this.lastNameColumn.Name = "lastNameColumn";
            this.lastNameColumn.ReadOnly = true;
            // 
            // userNameColumn
            // 
            this.userNameColumn.HeaderText = "Korisnicko ime";
            this.userNameColumn.MinimumWidth = 6;
            this.userNameColumn.Name = "userNameColumn";
            this.userNameColumn.ReadOnly = true;
            // 
            // phoneNumberColumn
            // 
            this.phoneNumberColumn.HeaderText = "Broj telefona";
            this.phoneNumberColumn.MinimumWidth = 6;
            this.phoneNumberColumn.Name = "phoneNumberColumn";
            this.phoneNumberColumn.ReadOnly = true;
            // 
            // workerCodeColumn
            // 
            this.workerCodeColumn.HeaderText = "Sifra";
            this.workerCodeColumn.MinimumWidth = 6;
            this.workerCodeColumn.Name = "workerCodeColumn";
            this.workerCodeColumn.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.btnDeleteBus);
            this.tabPage2.Controls.Add(this.btnEditBus);
            this.tabPage2.Controls.Add(this.btnAddBus);
            this.tabPage2.Controls.Add(this.dGVBus);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 615);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Autobusi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBus
            // 
            this.btnDeleteBus.BackColor = System.Drawing.Color.Silver;
            this.btnDeleteBus.FlatAppearance.BorderSize = 0;
            this.btnDeleteBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBus.Location = new System.Drawing.Point(793, 259);
            this.btnDeleteBus.Name = "btnDeleteBus";
            this.btnDeleteBus.Size = new System.Drawing.Size(169, 54);
            this.btnDeleteBus.TabIndex = 8;
            this.btnDeleteBus.TabStop = false;
            this.btnDeleteBus.Text = "Obrisi autobus";
            this.btnDeleteBus.UseVisualStyleBackColor = false;
            this.btnDeleteBus.Click += new System.EventHandler(this.btnDeleteBus_Click);
            // 
            // btnEditBus
            // 
            this.btnEditBus.BackColor = System.Drawing.Color.Silver;
            this.btnEditBus.FlatAppearance.BorderSize = 0;
            this.btnEditBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBus.Location = new System.Drawing.Point(793, 181);
            this.btnEditBus.Name = "btnEditBus";
            this.btnEditBus.Size = new System.Drawing.Size(169, 54);
            this.btnEditBus.TabIndex = 7;
            this.btnEditBus.Text = "Izmijeni autobus";
            this.btnEditBus.UseVisualStyleBackColor = false;
            this.btnEditBus.Click += new System.EventHandler(this.btnEditBus_Click);
            // 
            // btnAddBus
            // 
            this.btnAddBus.BackColor = System.Drawing.Color.Silver;
            this.btnAddBus.FlatAppearance.BorderSize = 0;
            this.btnAddBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBus.Location = new System.Drawing.Point(793, 106);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(169, 54);
            this.btnAddBus.TabIndex = 6;
            this.btnAddBus.TabStop = false;
            this.btnAddBus.Text = "Dodaj autobus";
            this.btnAddBus.UseVisualStyleBackColor = false;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // dGVBus
            // 
            this.dGVBus.AllowUserToAddRows = false;
            this.dGVBus.AllowUserToDeleteRows = false;
            this.dGVBus.AllowUserToResizeColumns = false;
            this.dGVBus.AllowUserToResizeRows = false;
            this.dGVBus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVBus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVBus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.busGarageNumberColumn,
            this.busTypeColumn,
            this.numberOfSeatsColumn,
            this.numberOfDoorsColumn,
            this.busCapacityComun});
            this.dGVBus.EnableHeadersVisualStyles = false;
            this.dGVBus.Location = new System.Drawing.Point(25, 84);
            this.dGVBus.MultiSelect = false;
            this.dGVBus.Name = "dGVBus";
            this.dGVBus.ReadOnly = true;
            this.dGVBus.RowHeadersVisible = false;
            this.dGVBus.RowHeadersWidth = 51;
            this.dGVBus.RowTemplate.Height = 29;
            this.dGVBus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVBus.Size = new System.Drawing.Size(735, 394);
            this.dGVBus.TabIndex = 5;
            // 
            // busGarageNumberColumn
            // 
            this.busGarageNumberColumn.HeaderText = "Garzni broj";
            this.busGarageNumberColumn.MinimumWidth = 6;
            this.busGarageNumberColumn.Name = "busGarageNumberColumn";
            this.busGarageNumberColumn.ReadOnly = true;
            this.busGarageNumberColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // busTypeColumn
            // 
            this.busTypeColumn.HeaderText = "tip";
            this.busTypeColumn.MinimumWidth = 6;
            this.busTypeColumn.Name = "busTypeColumn";
            this.busTypeColumn.ReadOnly = true;
            // 
            // numberOfSeatsColumn
            // 
            this.numberOfSeatsColumn.HeaderText = "Broj sjedista";
            this.numberOfSeatsColumn.MinimumWidth = 6;
            this.numberOfSeatsColumn.Name = "numberOfSeatsColumn";
            this.numberOfSeatsColumn.ReadOnly = true;
            // 
            // numberOfDoorsColumn
            // 
            this.numberOfDoorsColumn.HeaderText = "Broj vrata";
            this.numberOfDoorsColumn.MinimumWidth = 6;
            this.numberOfDoorsColumn.Name = "numberOfDoorsColumn";
            this.numberOfDoorsColumn.ReadOnly = true;
            // 
            // busCapacityComun
            // 
            this.busCapacityComun.HeaderText = "Kapacitet vozila";
            this.busCapacityComun.MinimumWidth = 6;
            this.busCapacityComun.Name = "busCapacityComun";
            this.busCapacityComun.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.btnDeleteShift);
            this.tabPage3.Controls.Add(this.btnAddShift);
            this.tabPage3.Controls.Add(this.lblSelectDate);
            this.tabPage3.Controls.Add(this.dGVSchedule);
            this.tabPage3.Controls.Add(this.calendar);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(983, 615);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Raspored smijena";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDeleteShift
            // 
            this.btnDeleteShift.FlatAppearance.BorderSize = 0;
            this.btnDeleteShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteShift.Location = new System.Drawing.Point(70, 472);
            this.btnDeleteShift.Name = "btnDeleteShift";
            this.btnDeleteShift.Size = new System.Drawing.Size(161, 50);
            this.btnDeleteShift.TabIndex = 14;
            this.btnDeleteShift.TabStop = false;
            this.btnDeleteShift.Text = "izbrisi smjenu";
            this.btnDeleteShift.UseVisualStyleBackColor = true;
            this.btnDeleteShift.Click += new System.EventHandler(this.btnDeleteShift_Click);
            // 
            // btnAddShift
            // 
            this.btnAddShift.FlatAppearance.BorderSize = 0;
            this.btnAddShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShift.Location = new System.Drawing.Point(70, 390);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(161, 50);
            this.btnAddShift.TabIndex = 13;
            this.btnAddShift.TabStop = false;
            this.btnAddShift.Text = "dodaj smjenu";
            this.btnAddShift.UseVisualStyleBackColor = true;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Location = new System.Drawing.Point(1, 40);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(104, 20);
            this.lblSelectDate.TabIndex = 12;
            this.lblSelectDate.Text = "izaberi datum:";
            // 
            // dGVSchedule
            // 
            this.dGVSchedule.AllowUserToAddRows = false;
            this.dGVSchedule.AllowUserToDeleteRows = false;
            this.dGVSchedule.AllowUserToResizeColumns = false;
            this.dGVSchedule.AllowUserToResizeRows = false;
            this.dGVSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameColumn2,
            this.lastNameColumn2,
            this.workerCodeColumn2,
            this.startTimeColumn2,
            this.endTimeColumn2,
            this.busColumn,
            this.busLineColumn});
            this.dGVSchedule.EnableHeadersVisualStyles = false;
            this.dGVSchedule.Location = new System.Drawing.Point(275, 64);
            this.dGVSchedule.MultiSelect = false;
            this.dGVSchedule.Name = "dGVSchedule";
            this.dGVSchedule.ReadOnly = true;
            this.dGVSchedule.RowHeadersVisible = false;
            this.dGVSchedule.RowHeadersWidth = 51;
            this.dGVSchedule.RowTemplate.Height = 29;
            this.dGVSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVSchedule.Size = new System.Drawing.Size(699, 429);
            this.dGVSchedule.TabIndex = 11;
            // 
            // firstNameColumn2
            // 
            this.firstNameColumn2.HeaderText = "Ime";
            this.firstNameColumn2.MinimumWidth = 6;
            this.firstNameColumn2.Name = "firstNameColumn2";
            this.firstNameColumn2.ReadOnly = true;
            this.firstNameColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lastNameColumn2
            // 
            this.lastNameColumn2.HeaderText = "Prezime";
            this.lastNameColumn2.MinimumWidth = 6;
            this.lastNameColumn2.Name = "lastNameColumn2";
            this.lastNameColumn2.ReadOnly = true;
            // 
            // workerCodeColumn2
            // 
            this.workerCodeColumn2.HeaderText = "Sifra";
            this.workerCodeColumn2.MinimumWidth = 6;
            this.workerCodeColumn2.Name = "workerCodeColumn2";
            this.workerCodeColumn2.ReadOnly = true;
            // 
            // startTimeColumn2
            // 
            this.startTimeColumn2.HeaderText = "Poceta smjene";
            this.startTimeColumn2.MinimumWidth = 6;
            this.startTimeColumn2.Name = "startTimeColumn2";
            this.startTimeColumn2.ReadOnly = true;
            // 
            // endTimeColumn2
            // 
            this.endTimeColumn2.HeaderText = "Kraj smjene";
            this.endTimeColumn2.MinimumWidth = 6;
            this.endTimeColumn2.Name = "endTimeColumn2";
            this.endTimeColumn2.ReadOnly = true;
            // 
            // busColumn
            // 
            this.busColumn.HeaderText = "Autobus";
            this.busColumn.MinimumWidth = 6;
            this.busColumn.Name = "busColumn";
            this.busColumn.ReadOnly = true;
            // 
            // busLineColumn
            // 
            this.busLineColumn.HeaderText = "Linija";
            this.busLineColumn.MinimumWidth = 6;
            this.busLineColumn.Name = "busLineColumn";
            this.busLineColumn.ReadOnly = true;
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.SystemColors.Window;
            this.calendar.Location = new System.Drawing.Point(1, 64);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 10;
            this.calendar.TrailingForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateSelected);
            // 
            // TrafficMenagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 676);
            this.Controls.Add(this.tabControlRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrafficMenagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoPrevoznikInfo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlRight.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDrivers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBus)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tSMILanguage;
        private System.Windows.Forms.ToolStripMenuItem tsmiSerbian;
        private System.Windows.Forms.ToolStripMenuItem tsmiEnglish;
        private System.Windows.Forms.ToolStripMenuItem tSMTheme;
        private System.Windows.Forms.ToolStripMenuItem tsmiWhiteTheme;
        private System.Windows.Forms.ToolStripMenuItem tsmiDarkTheme;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWorkerType;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.TabControl tabControlRight;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dGVDrivers;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerCodeColumn;
        private System.Windows.Forms.Button btnUpdateDriver;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSendMessage;
        //private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEditBus;
        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.DataGridView dGVBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn busGarageNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn busTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfSeatsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfDoorsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn busCapacityComun;
        private System.Windows.Forms.Button btnDeleteBus;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDeleteShift;
        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.DataGridView dGVSchedule;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerCodeColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn busColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn busLineColumn;
    }
}