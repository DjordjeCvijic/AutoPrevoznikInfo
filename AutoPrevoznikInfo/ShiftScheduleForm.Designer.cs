
namespace AutoPrevoznikInfo
{
    partial class ShiftScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftScheduleForm));
            this.lblShiftScedule = new System.Windows.Forms.Label();
            this.dGVShiftSchedule = new System.Windows.Forms.DataGridView();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVShiftSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShiftScedule
            // 
            this.lblShiftScedule.AutoSize = true;
            this.lblShiftScedule.Location = new System.Drawing.Point(47, 56);
            this.lblShiftScedule.Name = "lblShiftScedule";
            this.lblShiftScedule.Size = new System.Drawing.Size(126, 20);
            this.lblShiftScedule.TabIndex = 0;
            this.lblShiftScedule.Text = "Rastored smijena:";
            // 
            // dGVShiftSchedule
            // 
            this.dGVShiftSchedule.AllowUserToAddRows = false;
            this.dGVShiftSchedule.AllowUserToDeleteRows = false;
            this.dGVShiftSchedule.AllowUserToResizeColumns = false;
            this.dGVShiftSchedule.AllowUserToResizeRows = false;
            this.dGVShiftSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVShiftSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVShiftSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVShiftSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVShiftSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateColumn,
            this.startTimeColumn,
            this.endTimeColumn});
            this.dGVShiftSchedule.EnableHeadersVisualStyles = false;
            this.dGVShiftSchedule.Location = new System.Drawing.Point(47, 79);
            this.dGVShiftSchedule.MultiSelect = false;
            this.dGVShiftSchedule.Name = "dGVShiftSchedule";
            this.dGVShiftSchedule.ReadOnly = true;
            this.dGVShiftSchedule.RowHeadersVisible = false;
            this.dGVShiftSchedule.RowHeadersWidth = 51;
            this.dGVShiftSchedule.RowTemplate.Height = 29;
            this.dGVShiftSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVShiftSchedule.Size = new System.Drawing.Size(535, 285);
            this.dGVShiftSchedule.TabIndex = 2;
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "Datum";
            this.dateColumn.MinimumWidth = 6;
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            // 
            // startTimeColumn
            // 
            this.startTimeColumn.HeaderText = "Pocetak smjene";
            this.startTimeColumn.MinimumWidth = 6;
            this.startTimeColumn.Name = "startTimeColumn";
            this.startTimeColumn.ReadOnly = true;
            // 
            // endTimeColumn
            // 
            this.endTimeColumn.HeaderText = "Kraj smjene";
            this.endTimeColumn.MinimumWidth = 6;
            this.endTimeColumn.Name = "endTimeColumn";
            this.endTimeColumn.ReadOnly = true;
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(212, 414);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(166, 54);
            this.btnOk.TabIndex = 3;
            this.btnOk.TabStop = false;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ShiftScheduleForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 529);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dGVShiftSchedule);
            this.Controls.Add(this.lblShiftScedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShiftScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoPrevoznikInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dGVShiftSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShiftScedule;
        private System.Windows.Forms.DataGridView dGVShiftSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeColumn;
        private System.Windows.Forms.Button btnOk;
    }
}