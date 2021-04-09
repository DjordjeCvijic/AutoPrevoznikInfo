
namespace AutoPrevoznikInfo
{
    partial class AddBusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBusForm));
            this.cBoxSelectBusType = new System.Windows.Forms.ComboBox();
            this.lblSelectType = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblNumOfDoors = new System.Windows.Forms.Label();
            this.lblNumOfSeats = new System.Windows.Forms.Label();
            this.tBoxNumOfSeats = new System.Windows.Forms.TextBox();
            this.tBoxNumOfDoors = new System.Windows.Forms.TextBox();
            this.tBoxCapacity = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBoxSelectBusType
            // 
            this.cBoxSelectBusType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBoxSelectBusType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSelectBusType.FormattingEnabled = true;
            this.cBoxSelectBusType.Location = new System.Drawing.Point(40, 91);
            this.cBoxSelectBusType.Name = "cBoxSelectBusType";
            this.cBoxSelectBusType.Size = new System.Drawing.Size(205, 28);
            this.cBoxSelectBusType.TabIndex = 0;
            this.cBoxSelectBusType.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cBoxSelectBusType_DrawItem);
            // 
            // lblSelectType
            // 
            this.lblSelectType.AutoSize = true;
            this.lblSelectType.Location = new System.Drawing.Point(40, 68);
            this.lblSelectType.Name = "lblSelectType";
            this.lblSelectType.Size = new System.Drawing.Size(84, 20);
            this.lblSelectType.TabIndex = 1;
            this.lblSelectType.Text = "tip autobus";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(253, 163);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(137, 20);
            this.lblCapacity.TabIndex = 2;
            this.lblCapacity.Text = "Kapacitet autobusa";
            // 
            // lblNumOfDoors
            // 
            this.lblNumOfDoors.AutoSize = true;
            this.lblNumOfDoors.Location = new System.Drawing.Point(40, 163);
            this.lblNumOfDoors.Name = "lblNumOfDoors";
            this.lblNumOfDoors.Size = new System.Drawing.Size(76, 20);
            this.lblNumOfDoors.TabIndex = 3;
            this.lblNumOfDoors.Text = "Broj vrata:";
            // 
            // lblNumOfSeats
            // 
            this.lblNumOfSeats.AutoSize = true;
            this.lblNumOfSeats.Location = new System.Drawing.Point(253, 94);
            this.lblNumOfSeats.Name = "lblNumOfSeats";
            this.lblNumOfSeats.Size = new System.Drawing.Size(93, 20);
            this.lblNumOfSeats.TabIndex = 4;
            this.lblNumOfSeats.Text = "Broj sjedista:";
            // 
            // tBoxNumOfSeats
            // 
            this.tBoxNumOfSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxNumOfSeats.Location = new System.Drawing.Point(396, 91);
            this.tBoxNumOfSeats.Name = "tBoxNumOfSeats";
            this.tBoxNumOfSeats.Size = new System.Drawing.Size(73, 27);
            this.tBoxNumOfSeats.TabIndex = 5;
            // 
            // tBoxNumOfDoors
            // 
            this.tBoxNumOfDoors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxNumOfDoors.Location = new System.Drawing.Point(172, 160);
            this.tBoxNumOfDoors.Name = "tBoxNumOfDoors";
            this.tBoxNumOfDoors.Size = new System.Drawing.Size(73, 27);
            this.tBoxNumOfDoors.TabIndex = 6;
            // 
            // tBoxCapacity
            // 
            this.tBoxCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxCapacity.Location = new System.Drawing.Point(396, 160);
            this.tBoxCapacity.Name = "tBoxCapacity";
            this.tBoxCapacity.Size = new System.Drawing.Size(73, 27);
            this.tBoxCapacity.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(208, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 61);
            this.btnSave.TabIndex = 8;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Sacuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddBusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 374);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tBoxCapacity);
            this.Controls.Add(this.tBoxNumOfDoors);
            this.Controls.Add(this.tBoxNumOfSeats);
            this.Controls.Add(this.lblNumOfSeats);
            this.Controls.Add(this.lblNumOfDoors);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblSelectType);
            this.Controls.Add(this.cBoxSelectBusType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoPrevoznikInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxSelectBusType;
        private System.Windows.Forms.Label lblSelectType;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblNumOfDoors;
        private System.Windows.Forms.Label lblNumOfSeats;
        private System.Windows.Forms.TextBox tBoxNumOfSeats;
        private System.Windows.Forms.TextBox tBoxNumOfDoors;
        
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tBoxCapacity;
    }
}