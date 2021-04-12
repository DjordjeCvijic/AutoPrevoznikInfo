
namespace AutoPrevoznikInfo
{
    partial class AddShiftScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddShiftScheduleForm));
            this.cBoxWorker = new System.Windows.Forms.ComboBox();
            this.lblSelectDoorkeeper = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dTPStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.dTPEndTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cBoxWorker
            // 
            this.cBoxWorker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBoxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWorker.FormattingEnabled = true;
            this.cBoxWorker.Location = new System.Drawing.Point(62, 53);
            this.cBoxWorker.Name = "cBoxWorker";
            this.cBoxWorker.Size = new System.Drawing.Size(221, 28);
            this.cBoxWorker.TabIndex = 0;
            this.cBoxWorker.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cBox_DrawItem);
            // 
            // lblSelectDoorkeeper
            // 
            this.lblSelectDoorkeeper.AutoSize = true;
            this.lblSelectDoorkeeper.Location = new System.Drawing.Point(62, 30);
            this.lblSelectDoorkeeper.Name = "lblSelectDoorkeeper";
            this.lblSelectDoorkeeper.Size = new System.Drawing.Size(107, 20);
            this.lblSelectDoorkeeper.TabIndex = 1;
            this.lblSelectDoorkeeper.Text = "Izaberi radnika";
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(181, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 57);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Sacuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dTPStartTime
            // 
            this.dTPStartTime.CustomFormat = "HH:mm:ss";
            this.dTPStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPStartTime.Location = new System.Drawing.Point(62, 141);
            this.dTPStartTime.Name = "dTPStartTime";
            this.dTPStartTime.ShowUpDown = true;
            this.dTPStartTime.Size = new System.Drawing.Size(123, 27);
            this.dTPStartTime.TabIndex = 1;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(62, 118);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(108, 20);
            this.lblStartTime.TabIndex = 5;
            this.lblStartTime.Text = "pocetak smjne:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(310, 118);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(108, 20);
            this.lblEndTime.TabIndex = 7;
            this.lblEndTime.Text = "pocetak smjne:";
            // 
            // dTPEndTime
            // 
            this.dTPEndTime.CustomFormat = "HH:mm:ss";
            this.dTPEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPEndTime.Location = new System.Drawing.Point(310, 141);
            this.dTPEndTime.Name = "dTPEndTime";
            this.dTPEndTime.ShowUpDown = true;
            this.dTPEndTime.Size = new System.Drawing.Size(123, 27);
            this.dTPEndTime.TabIndex = 2;
            // 
            // AddShiftScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 288);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.dTPEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.dTPStartTime);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSelectDoorkeeper);
            this.Controls.Add(this.cBoxWorker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddShiftScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoPrevoznikInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxWorker;
        private System.Windows.Forms.Label lblSelectDoorkeeper;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dTPStartTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.DateTimePicker dTPEndTime;
    }
}