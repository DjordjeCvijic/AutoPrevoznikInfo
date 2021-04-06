
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
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlRight.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDrivers)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1230, 28);
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
            this.panelLeft.Size = new System.Drawing.Size(237, 690);
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
            this.btnLogout.Location = new System.Drawing.Point(23, 573);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(188, 46);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "button1";
            this.btnLogout.UseVisualStyleBackColor = true;
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
            this.tabControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControlRight.Location = new System.Drawing.Point(232, 28);
            this.tabControlRight.Name = "tabControlRight";
            this.tabControlRight.SelectedIndex = 0;
            this.tabControlRight.Size = new System.Drawing.Size(998, 690);
            this.tabControlRight.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSendMessage);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnUpdateDriver);
            this.tabPage1.Controls.Add(this.btnAddWorker);
            this.tabPage1.Controls.Add(this.dGVDrivers);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(990, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vozaci";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(797, 188);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "obrisi";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateDriver
            // 
            this.btnUpdateDriver.Location = new System.Drawing.Point(797, 120);
            this.btnUpdateDriver.Name = "btnUpdateDriver";
            this.btnUpdateDriver.Size = new System.Drawing.Size(165, 29);
            this.btnUpdateDriver.TabIndex = 2;
            this.btnUpdateDriver.Text = "Izmijeni";
            this.btnUpdateDriver.UseVisualStyleBackColor = true;
            this.btnUpdateDriver.Click += new System.EventHandler(this.btnUpdateDriver_Click);
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(46, 361);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(119, 43);
            this.btnAddWorker.TabIndex = 1;
            this.btnAddWorker.Text = "dodaj vozaca";
            this.btnAddWorker.UseVisualStyleBackColor = true;
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
            this.dGVDrivers.Location = new System.Drawing.Point(31, 94);
            this.dGVDrivers.MultiSelect = false;
            this.dGVDrivers.Name = "dGVDrivers";
            this.dGVDrivers.ReadOnly = true;
            this.dGVDrivers.RowHeadersVisible = false;
            this.dGVDrivers.RowHeadersWidth = 51;
            this.dGVDrivers.RowTemplate.Height = 29;
            this.dGVDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDrivers.Size = new System.Drawing.Size(689, 261);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(990, 657);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Autobusi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(797, 268);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(165, 29);
            this.btnSendMessage.TabIndex = 4;
            this.btnSendMessage.Text = "Posalji poruku";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // TrafficMenagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 718);
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
    }
}