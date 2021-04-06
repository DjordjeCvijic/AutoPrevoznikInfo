
namespace AutoPrevoznikInfo
{
    partial class AddDriverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDriverForm));
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tBoxFirstName = new System.Windows.Forms.TextBox();
            this.tBoxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tBoxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lBoxTakeBus = new System.Windows.Forms.ListBox();
            this.lblTakeBus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(31, 48);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(37, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Ime:";
            // 
            // tBoxFirstName
            // 
            this.tBoxFirstName.Location = new System.Drawing.Point(31, 71);
            this.tBoxFirstName.Name = "tBoxFirstName";
            this.tBoxFirstName.Size = new System.Drawing.Size(153, 27);
            this.tBoxFirstName.TabIndex = 1;
            // 
            // tBoxLastName
            // 
            this.tBoxLastName.Location = new System.Drawing.Point(218, 71);
            this.tBoxLastName.Name = "tBoxLastName";
            this.tBoxLastName.Size = new System.Drawing.Size(150, 27);
            this.tBoxLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(218, 48);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(65, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Prezime:";
            // 
            // tBoxUsername
            // 
            this.tBoxUsername.Location = new System.Drawing.Point(31, 167);
            this.tBoxUsername.Name = "tBoxUsername";
            this.tBoxUsername.Size = new System.Drawing.Size(153, 27);
            this.tBoxUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(31, 144);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(109, 20);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Korisnicko ime:";
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Location = new System.Drawing.Point(218, 167);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(150, 27);
            this.tBoxPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(218, 144);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 20);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Lozinka:";
            // 
            // tBoxPhoneNumber
            // 
            this.tBoxPhoneNumber.Location = new System.Drawing.Point(31, 254);
            this.tBoxPhoneNumber.Name = "tBoxPhoneNumber";
            this.tBoxPhoneNumber.Size = new System.Drawing.Size(153, 27);
            this.tBoxPhoneNumber.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(31, 231);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(95, 20);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Broj telefona";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(283, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Sacuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lBoxTakeBus
            // 
            this.lBoxTakeBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lBoxTakeBus.FormattingEnabled = true;
            this.lBoxTakeBus.ItemHeight = 20;
            this.lBoxTakeBus.Location = new System.Drawing.Point(391, 71);
            this.lBoxTakeBus.Name = "lBoxTakeBus";
            this.lBoxTakeBus.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lBoxTakeBus.Size = new System.Drawing.Size(296, 262);
            this.lBoxTakeBus.TabIndex = 11;
            // 
            // lblTakeBus
            // 
            this.lblTakeBus.AutoSize = true;
            this.lblTakeBus.Location = new System.Drawing.Point(391, 48);
            this.lblTakeBus.Name = "lblTakeBus";
            this.lblTakeBus.Size = new System.Drawing.Size(122, 20);
            this.lblTakeBus.TabIndex = 12;
            this.lblTakeBus.Text = "Zaduzi autobuse:";
            // 
            // AddDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 493);
            this.Controls.Add(this.lblTakeBus);
            this.Controls.Add(this.lBoxTakeBus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tBoxPhoneNumber);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tBoxUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tBoxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tBoxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDriverForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoPrevoznikInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tBoxFirstName;
        private System.Windows.Forms.TextBox tBoxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tBoxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lBoxTakeBus;
        private System.Windows.Forms.Label lblTakeBus;
        private System.Windows.Forms.TextBox tBoxPhoneNumber;
    }
}