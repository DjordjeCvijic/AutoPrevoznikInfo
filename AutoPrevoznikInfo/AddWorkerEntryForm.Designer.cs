
namespace AutoPrevoznikInfo
{
    partial class AddWorkerEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWorkerEntryForm));
            this.lblSelectWorker = new System.Windows.Forms.Label();
            this.lBoxSelectWorker = new System.Windows.Forms.ListBox();
            this.lblEntryTime = new System.Windows.Forms.Label();
            this.lblEntryTime1 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.tBoxNote = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectWorker
            // 
            this.lblSelectWorker.AutoSize = true;
            this.lblSelectWorker.Location = new System.Drawing.Point(44, 39);
            this.lblSelectWorker.Name = "lblSelectWorker";
            this.lblSelectWorker.Size = new System.Drawing.Size(107, 20);
            this.lblSelectWorker.TabIndex = 0;
            this.lblSelectWorker.Text = "Izaberi radnika";
            // 
            // lBoxSelectWorker
            // 
            this.lBoxSelectWorker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lBoxSelectWorker.FormattingEnabled = true;
            this.lBoxSelectWorker.ItemHeight = 20;
            this.lBoxSelectWorker.Location = new System.Drawing.Point(44, 62);
            this.lBoxSelectWorker.Name = "lBoxSelectWorker";
            this.lBoxSelectWorker.Size = new System.Drawing.Size(332, 222);
            this.lBoxSelectWorker.TabIndex = 1;
            // 
            // lblEntryTime
            // 
            this.lblEntryTime.AutoSize = true;
            this.lblEntryTime.Location = new System.Drawing.Point(411, 62);
            this.lblEntryTime.Name = "lblEntryTime";
            this.lblEntryTime.Size = new System.Drawing.Size(107, 20);
            this.lblEntryTime.TabIndex = 2;
            this.lblEntryTime.Text = "Vrijeme ulaska:";
            // 
            // lblEntryTime1
            // 
            this.lblEntryTime1.AutoSize = true;
            this.lblEntryTime1.Location = new System.Drawing.Point(524, 62);
            this.lblEntryTime1.Name = "lblEntryTime1";
            this.lblEntryTime1.Size = new System.Drawing.Size(32, 20);
            this.lblEntryTime1.TabIndex = 3;
            this.lblEntryTime1.Text = "sati";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(44, 352);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(83, 20);
            this.lblNote.TabIndex = 4;
            this.lblNote.Text = "Napomena";
            // 
            // tBoxNote
            // 
            this.tBoxNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxNote.Location = new System.Drawing.Point(44, 375);
            this.tBoxNote.Multiline = true;
            this.tBoxNote.Name = "tBoxNote";
            this.tBoxNote.Size = new System.Drawing.Size(559, 108);
            this.tBoxNote.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(235, 513);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 48);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Sacuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddWorkerEntryForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 608);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tBoxNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblEntryTime1);
            this.Controls.Add(this.lblEntryTime);
            this.Controls.Add(this.lBoxSelectWorker);
            this.Controls.Add(this.lblSelectWorker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddWorkerEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddWorkerEntryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectWorker;
        private System.Windows.Forms.ListBox lBoxSelectWorker;
        private System.Windows.Forms.Label lblEntryTime;
        private System.Windows.Forms.Label lblEntryTime1;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox tBoxNote;
        private System.Windows.Forms.Button btnSave;
    }
}