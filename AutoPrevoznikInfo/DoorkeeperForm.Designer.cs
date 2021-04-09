
namespace AutoPrevoznikInfo
{
    partial class DoorkeeperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoorkeeperForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tSMILanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSerbian = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWhiteTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDarkTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnShowShiftSchedule = new System.Windows.Forms.Button();
            this.lblWorkerType = new System.Windows.Forms.Label();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlRight = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnAddExitTime = new System.Windows.Forms.Button();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.dGVWorkerRecord = new System.Windows.Forms.DataGridView();
            this.firstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSelectMessage = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tBoxMessage = new System.Windows.Forms.TextBox();
            this.lBoxSenderList = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlRight.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVWorkerRecord)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.panelLeft.Controls.Add(this.btnShowShiftSchedule);
            this.panelLeft.Controls.Add(this.lblWorkerType);
            this.panelLeft.Controls.Add(this.lblWorkerName);
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 28);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(237, 652);
            this.panelLeft.TabIndex = 5;
            // 
            // btnShowShiftSchedule
            // 
            this.btnShowShiftSchedule.FlatAppearance.BorderSize = 0;
            this.btnShowShiftSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowShiftSchedule.Location = new System.Drawing.Point(23, 505);
            this.btnShowShiftSchedule.Name = "btnShowShiftSchedule";
            this.btnShowShiftSchedule.Size = new System.Drawing.Size(188, 46);
            this.btnShowShiftSchedule.TabIndex = 4;
            this.btnShowShiftSchedule.TabStop = false;
            this.btnShowShiftSchedule.Text = "raspore";
            this.btnShowShiftSchedule.UseVisualStyleBackColor = true;
            this.btnShowShiftSchedule.Click += new System.EventHandler(this.btnShowShiftSchedule_Click);
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
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(23, 573);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(188, 46);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.TabStop = false;
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
            this.tabControlRight.Location = new System.Drawing.Point(243, 28);
            this.tabControlRight.Name = "tabControlRight";
            this.tabControlRight.SelectedIndex = 0;
            this.tabControlRight.Size = new System.Drawing.Size(991, 652);
            this.tabControlRight.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.lblRecord);
            this.tabPage1.Controls.Add(this.btnAddExitTime);
            this.tabPage1.Controls.Add(this.btnAddEntry);
            this.tabPage1.Controls.Add(this.dGVWorkerRecord);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 619);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Evidencija radnika";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(60, 55);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(144, 20);
            this.lblRecord.TabIndex = 4;
            this.lblRecord.Text = "Danasnja evidencija:";
            // 
            // btnAddExitTime
            // 
            this.btnAddExitTime.FlatAppearance.BorderSize = 0;
            this.btnAddExitTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExitTime.Location = new System.Drawing.Point(802, 159);
            this.btnAddExitTime.Name = "btnAddExitTime";
            this.btnAddExitTime.Size = new System.Drawing.Size(141, 46);
            this.btnAddExitTime.TabIndex = 3;
            this.btnAddExitTime.TabStop = false;
            this.btnAddExitTime.Text = "zabiljezi izlazak";
            this.btnAddExitTime.UseVisualStyleBackColor = true;
            this.btnAddExitTime.Click += new System.EventHandler(this.btnAddExitTime_Click);
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.FlatAppearance.BorderSize = 0;
            this.btnAddEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEntry.Location = new System.Drawing.Point(802, 89);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(141, 39);
            this.btnAddEntry.TabIndex = 2;
            this.btnAddEntry.TabStop = false;
            this.btnAddEntry.Text = "dodaj ulazak";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // dGVWorkerRecord
            // 
            this.dGVWorkerRecord.AllowUserToAddRows = false;
            this.dGVWorkerRecord.AllowUserToDeleteRows = false;
            this.dGVWorkerRecord.AllowUserToResizeColumns = false;
            this.dGVWorkerRecord.AllowUserToResizeRows = false;
            this.dGVWorkerRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVWorkerRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVWorkerRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVWorkerRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVWorkerRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameColumn,
            this.lastNameColumn,
            this.dateColumn,
            this.enterTimeColumn,
            this.exitTimeColumn});
            this.dGVWorkerRecord.EnableHeadersVisualStyles = false;
            this.dGVWorkerRecord.Location = new System.Drawing.Point(60, 78);
            this.dGVWorkerRecord.MultiSelect = false;
            this.dGVWorkerRecord.Name = "dGVWorkerRecord";
            this.dGVWorkerRecord.ReadOnly = true;
            this.dGVWorkerRecord.RowHeadersVisible = false;
            this.dGVWorkerRecord.RowHeadersWidth = 51;
            this.dGVWorkerRecord.RowTemplate.Height = 29;
            this.dGVWorkerRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVWorkerRecord.Size = new System.Drawing.Size(689, 479);
            this.dGVWorkerRecord.TabIndex = 1;
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
            // dateColumn
            // 
            this.dateColumn.HeaderText = "Datum";
            this.dateColumn.MinimumWidth = 6;
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            // 
            // enterTimeColumn
            // 
            this.enterTimeColumn.HeaderText = "Vrijeme ulaska";
            this.enterTimeColumn.MinimumWidth = 6;
            this.enterTimeColumn.Name = "enterTimeColumn";
            this.enterTimeColumn.ReadOnly = true;
            // 
            // exitTimeColumn
            // 
            this.exitTimeColumn.HeaderText = "Vrijeme izlaska";
            this.exitTimeColumn.MinimumWidth = 6;
            this.exitTimeColumn.Name = "exitTimeColumn";
            this.exitTimeColumn.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblSelectMessage);
            this.tabPage2.Controls.Add(this.lblMessage);
            this.tabPage2.Controls.Add(this.tBoxMessage);
            this.tabPage2.Controls.Add(this.lBoxSenderList);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 619);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Obavjestenja";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblSelectMessage
            // 
            this.lblSelectMessage.AutoSize = true;
            this.lblSelectMessage.Location = new System.Drawing.Point(47, 76);
            this.lblSelectMessage.Name = "lblSelectMessage";
            this.lblSelectMessage.Size = new System.Drawing.Size(107, 20);
            this.lblSelectMessage.TabIndex = 3;
            this.lblSelectMessage.Text = "Izaberi poruku:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(361, 76);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(56, 20);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Poruka:";
            // 
            // tBoxMessage
            // 
            this.tBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxMessage.Location = new System.Drawing.Point(361, 99);
            this.tBoxMessage.Multiline = true;
            this.tBoxMessage.Name = "tBoxMessage";
            this.tBoxMessage.ReadOnly = true;
            this.tBoxMessage.Size = new System.Drawing.Size(470, 424);
            this.tBoxMessage.TabIndex = 1;
            // 
            // lBoxSenderList
            // 
            this.lBoxSenderList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lBoxSenderList.FormattingEnabled = true;
            this.lBoxSenderList.ItemHeight = 20;
            this.lBoxSenderList.Location = new System.Drawing.Point(47, 99);
            this.lBoxSenderList.Name = "lBoxSenderList";
            this.lBoxSenderList.Size = new System.Drawing.Size(280, 422);
            this.lBoxSenderList.TabIndex = 0;
            this.lBoxSenderList.SelectedIndexChanged += new System.EventHandler(this.lBoxSenderList_SelectedIndexChanged);
            // 
            // DoorkeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 680);
            this.Controls.Add(this.tabControlRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoorkeeperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoPrevoznikInfo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlRight.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVWorkerRecord)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tBoxMessage;
        private System.Windows.Forms.ListBox lBoxSenderList;
        private System.Windows.Forms.DataGridView dGVWorkerRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitTimeColumn;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.Button btnAddExitTime;
        private System.Windows.Forms.Button btnShowShiftSchedule;
        private System.Windows.Forms.Label lblSelectMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblRecord;
    }
}