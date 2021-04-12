
namespace AutoPrevoznikInfo
{
    partial class AddDriverShiftScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDriverShiftScheduleForm));
            this.lblEndTime = new System.Windows.Forms.Label();
            this.dTPEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dTPStartTime = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSelectDriver = new System.Windows.Forms.Label();
            this.cBoxWorker = new System.Windows.Forms.ComboBox();
            this.lblSelectBus = new System.Windows.Forms.Label();
            this.cBoxSelectBus = new System.Windows.Forms.ComboBox();
            this.lblSelectBusLine = new System.Windows.Forms.Label();
            this.cBoxSelectBusLine = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(420, 181);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(108, 20);
            this.lblEndTime.TabIndex = 14;
            this.lblEndTime.Text = "pocetak smjne:";
            // 
            // dTPEndTime
            // 
            this.dTPEndTime.CustomFormat = "HH:mm:ss";
            this.dTPEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPEndTime.Location = new System.Drawing.Point(420, 204);
            this.dTPEndTime.Name = "dTPEndTime";
            this.dTPEndTime.ShowUpDown = true;
            this.dTPEndTime.Size = new System.Drawing.Size(123, 27);
            this.dTPEndTime.TabIndex = 4;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(167, 181);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(108, 20);
            this.lblStartTime.TabIndex = 12;
            this.lblStartTime.Text = "pocetak smjne:";
            // 
            // dTPStartTime
            // 
            this.dTPStartTime.CustomFormat = "HH:mm:ss";
            this.dTPStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPStartTime.Location = new System.Drawing.Point(167, 204);
            this.dTPStartTime.Name = "dTPStartTime";
            this.dTPStartTime.ShowUpDown = true;
            this.dTPStartTime.Size = new System.Drawing.Size(123, 27);
            this.dTPStartTime.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(282, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 56);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Sacuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSelectDriver
            // 
            this.lblSelectDriver.AutoSize = true;
            this.lblSelectDriver.Location = new System.Drawing.Point(37, 58);
            this.lblSelectDriver.Name = "lblSelectDriver";
            this.lblSelectDriver.Size = new System.Drawing.Size(107, 20);
            this.lblSelectDriver.TabIndex = 9;
            this.lblSelectDriver.Text = "Izaberi radnika";
            // 
            // cBoxWorker
            // 
            this.cBoxWorker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBoxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWorker.FormattingEnabled = true;
            this.cBoxWorker.Location = new System.Drawing.Point(37, 81);
            this.cBoxWorker.Name = "cBoxWorker";
            this.cBoxWorker.Size = new System.Drawing.Size(183, 28);
            this.cBoxWorker.TabIndex = 0;
            this.cBoxWorker.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cBox_DrawItem);
            this.cBoxWorker.SelectedIndexChanged += new System.EventHandler(this.cBoxWorker_SelectedIndexChanged);
            // 
            // lblSelectBus
            // 
            this.lblSelectBus.AutoSize = true;
            this.lblSelectBus.Location = new System.Drawing.Point(264, 58);
            this.lblSelectBus.Name = "lblSelectBus";
            this.lblSelectBus.Size = new System.Drawing.Size(111, 20);
            this.lblSelectBus.TabIndex = 16;
            this.lblSelectBus.Text = "Izaberi autobus";
            // 
            // cBoxSelectBus
            // 
            this.cBoxSelectBus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBoxSelectBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSelectBus.FormattingEnabled = true;
            this.cBoxSelectBus.Location = new System.Drawing.Point(264, 81);
            this.cBoxSelectBus.Name = "cBoxSelectBus";
            this.cBoxSelectBus.Size = new System.Drawing.Size(183, 28);
            this.cBoxSelectBus.TabIndex = 1;
            this.cBoxSelectBus.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cBox_DrawItem);
            // 
            // lblSelectBusLine
            // 
            this.lblSelectBusLine.AutoSize = true;
            this.lblSelectBusLine.Location = new System.Drawing.Point(494, 58);
            this.lblSelectBusLine.Name = "lblSelectBusLine";
            this.lblSelectBusLine.Size = new System.Drawing.Size(111, 20);
            this.lblSelectBusLine.TabIndex = 18;
            this.lblSelectBusLine.Text = "Izaberi autobus";
            // 
            // cBoxSelectBusLine
            // 
            this.cBoxSelectBusLine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBoxSelectBusLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSelectBusLine.FormattingEnabled = true;
            this.cBoxSelectBusLine.Location = new System.Drawing.Point(494, 81);
            this.cBoxSelectBusLine.Name = "cBoxSelectBusLine";
            this.cBoxSelectBusLine.Size = new System.Drawing.Size(183, 28);
            this.cBoxSelectBusLine.TabIndex = 2;
            this.cBoxSelectBusLine.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cBox_DrawItem);
            // 
            // AddDriverShiftScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 413);
            this.Controls.Add(this.lblSelectBusLine);
            this.Controls.Add(this.cBoxSelectBusLine);
            this.Controls.Add(this.lblSelectBus);
            this.Controls.Add(this.cBoxSelectBus);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.dTPEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.dTPStartTime);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSelectDriver);
            this.Controls.Add(this.cBoxWorker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDriverShiftScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoPrevoznikInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.DateTimePicker dTPEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DateTimePicker dTPStartTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSelectDriver;
        private System.Windows.Forms.ComboBox cBoxWorker;
        private System.Windows.Forms.Label lblSelectBus;
        private System.Windows.Forms.ComboBox cBoxSelectBus;
        private System.Windows.Forms.Label lblSelectBusLine;
        private System.Windows.Forms.ComboBox cBoxSelectBusLine;
    }
}