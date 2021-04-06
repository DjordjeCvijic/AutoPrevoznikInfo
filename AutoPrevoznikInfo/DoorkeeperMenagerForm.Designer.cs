
namespace AutoPrevoznikInfo
{
    partial class DoorkeeperMenagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoorkeeperMenagerForm));
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
            this.btnAddDoorkeeper = new System.Windows.Forms.Button();
            this.dGVDoorkeepers = new System.Windows.Forms.DataGridView();
            this.firstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUpdateDoorkeeper = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlRight.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDoorkeepers)).BeginInit();
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
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tSMILanguage
            // 
            this.tSMILanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSerbian,
            this.tsmiEnglish});
            this.tSMILanguage.Name = "tSMILanguage";
            this.tSMILanguage.Size = new System.Drawing.Size(54, 24);
            this.tSMILanguage.Text = "Jezik";
            // 
            // tsmiSerbian
            // 
            this.tsmiSerbian.Name = "tsmiSerbian";
            this.tsmiSerbian.Size = new System.Drawing.Size(139, 26);
            this.tsmiSerbian.Text = "Srpski";
            // 
            // tsmiEnglish
            // 
            this.tsmiEnglish.Name = "tsmiEnglish";
            this.tsmiEnglish.Size = new System.Drawing.Size(139, 26);
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
            this.panelLeft.Size = new System.Drawing.Size(237, 636);
            this.panelLeft.TabIndex = 4;
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
            this.tabControlRight.Location = new System.Drawing.Point(236, 28);
            this.tabControlRight.Name = "tabControlRight";
            this.tabControlRight.SelectedIndex = 0;
            this.tabControlRight.Size = new System.Drawing.Size(998, 636);
            this.tabControlRight.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUpdateDoorkeeper);
            this.tabPage1.Controls.Add(this.btnAddDoorkeeper);
            this.tabPage1.Controls.Add(this.dGVDoorkeepers);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(990, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vozaci";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddDoorkeeper
            // 
            this.btnAddDoorkeeper.Location = new System.Drawing.Point(785, 94);
            this.btnAddDoorkeeper.Name = "btnAddDoorkeeper";
            this.btnAddDoorkeeper.Size = new System.Drawing.Size(168, 31);
            this.btnAddDoorkeeper.TabIndex = 4;
            this.btnAddDoorkeeper.Text = "dodaj";
            this.btnAddDoorkeeper.UseVisualStyleBackColor = true;
            this.btnAddDoorkeeper.Click += new System.EventHandler(this.btnAddDoorkeeper_Click);
            // 
            // dGVDoorkeepers
            // 
            this.dGVDoorkeepers.AllowUserToAddRows = false;
            this.dGVDoorkeepers.AllowUserToDeleteRows = false;
            this.dGVDoorkeepers.AllowUserToResizeColumns = false;
            this.dGVDoorkeepers.AllowUserToResizeRows = false;
            this.dGVDoorkeepers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDoorkeepers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVDoorkeepers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVDoorkeepers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDoorkeepers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameColumn,
            this.lastNameColumn,
            this.userNameColumn,
            this.phoneNumberColumn,
            this.workerCodeColumn});
            this.dGVDoorkeepers.EnableHeadersVisualStyles = false;
            this.dGVDoorkeepers.Location = new System.Drawing.Point(31, 94);
            this.dGVDoorkeepers.MultiSelect = false;
            this.dGVDoorkeepers.Name = "dGVDoorkeepers";
            this.dGVDoorkeepers.ReadOnly = true;
            this.dGVDoorkeepers.RowHeadersVisible = false;
            this.dGVDoorkeepers.RowHeadersWidth = 51;
            this.dGVDoorkeepers.RowTemplate.Height = 29;
            this.dGVDoorkeepers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDoorkeepers.Size = new System.Drawing.Size(689, 261);
            this.dGVDoorkeepers.TabIndex = 0;
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
            this.tabPage2.Size = new System.Drawing.Size(990, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Autobusi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDoorkeeper
            // 
            this.btnUpdateDoorkeeper.Location = new System.Drawing.Point(785, 177);
            this.btnUpdateDoorkeeper.Name = "btnUpdateDoorkeeper";
            this.btnUpdateDoorkeeper.Size = new System.Drawing.Size(168, 30);
            this.btnUpdateDoorkeeper.TabIndex = 5;
            this.btnUpdateDoorkeeper.Text = "izmijeni";
            this.btnUpdateDoorkeeper.UseVisualStyleBackColor = true;
            this.btnUpdateDoorkeeper.Click += new System.EventHandler(this.btnUpdateDoorkeeper_Click);
            // 
            // DoorkeeperMenagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 664);
            this.Controls.Add(this.tabControlRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoorkeeperMenagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoPrevoznikInfo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlRight.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDoorkeepers)).EndInit();
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
        private System.Windows.Forms.Label lblWorkerType;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControlRight;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dGVDoorkeepers;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerCodeColumn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddDoorkeeper;
        private System.Windows.Forms.Button btnUpdateDoorkeeper;
    }
}