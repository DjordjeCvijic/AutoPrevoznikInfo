
namespace AutoPrevoznikInfo
{
    partial class AddDoorkeeperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDoorkeeperForm));
            this.tBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tBoxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tBoxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxPhoneNumber
            // 
            this.tBoxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxPhoneNumber.Location = new System.Drawing.Point(64, 245);
            this.tBoxPhoneNumber.Name = "tBoxPhoneNumber";
            this.tBoxPhoneNumber.Size = new System.Drawing.Size(153, 27);
            this.tBoxPhoneNumber.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(64, 222);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(95, 20);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Broj telefona";
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxPassword.Location = new System.Drawing.Point(293, 158);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(150, 27);
            this.tBoxPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(293, 135);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 20);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Lozinka:";
            // 
            // tBoxUsername
            // 
            this.tBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxUsername.Location = new System.Drawing.Point(64, 158);
            this.tBoxUsername.Name = "tBoxUsername";
            this.tBoxUsername.Size = new System.Drawing.Size(153, 27);
            this.tBoxUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(64, 135);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(109, 20);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Korisnicko ime:";
            // 
            // tBoxLastName
            // 
            this.tBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxLastName.Location = new System.Drawing.Point(293, 62);
            this.tBoxLastName.Name = "tBoxLastName";
            this.tBoxLastName.Size = new System.Drawing.Size(150, 27);
            this.tBoxLastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(293, 39);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(65, 20);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Prezime:";
            // 
            // tBoxFirstName
            // 
            this.tBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxFirstName.Location = new System.Drawing.Point(64, 62);
            this.tBoxFirstName.Name = "tBoxFirstName";
            this.tBoxFirstName.Size = new System.Drawing.Size(153, 27);
            this.tBoxFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(64, 39);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(37, 20);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "Ime:";
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(188, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 50);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "sacuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddDoorkeeperForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(521, 471);
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
            this.Name = "AddDoorkeeperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoPrevoznikInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxPhoneNumber;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tBoxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tBoxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tBoxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnSave;
    }
}