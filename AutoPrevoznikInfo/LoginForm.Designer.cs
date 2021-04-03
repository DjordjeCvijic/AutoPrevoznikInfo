
namespace AutoPrevoznikInfo
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblDobroDosli = new System.Windows.Forms.Label();
            this.gBoxLanguage = new System.Windows.Forms.GroupBox();
            this.rBtnEnglish = new System.Windows.Forms.RadioButton();
            this.rBtnSerbian = new System.Windows.Forms.RadioButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tBoxUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.gBoxLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDobroDosli
            // 
            this.lblDobroDosli.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDobroDosli.Location = new System.Drawing.Point(124, 33);
            this.lblDobroDosli.Name = "lblDobroDosli";
            this.lblDobroDosli.Size = new System.Drawing.Size(180, 46);
            this.lblDobroDosli.TabIndex = 0;
            this.lblDobroDosli.Text = "Dobro dosli";
            this.lblDobroDosli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBoxLanguage
            // 
            this.gBoxLanguage.Controls.Add(this.rBtnEnglish);
            this.gBoxLanguage.Controls.Add(this.rBtnSerbian);
            this.gBoxLanguage.Location = new System.Drawing.Point(91, 82);
            this.gBoxLanguage.Name = "gBoxLanguage";
            this.gBoxLanguage.Size = new System.Drawing.Size(249, 111);
            this.gBoxLanguage.TabIndex = 1;
            this.gBoxLanguage.TabStop = false;
            this.gBoxLanguage.Text = "Izaberite jezik";
            // 
            // rBtnEnglish
            // 
            this.rBtnEnglish.AutoSize = true;
            this.rBtnEnglish.Location = new System.Drawing.Point(6, 67);
            this.rBtnEnglish.Name = "rBtnEnglish";
            this.rBtnEnglish.Size = new System.Drawing.Size(84, 24);
            this.rBtnEnglish.TabIndex = 1;
            this.rBtnEnglish.TabStop = true;
            this.rBtnEnglish.Tag = "E";
            this.rBtnEnglish.Text = "Engleski";
            this.rBtnEnglish.UseVisualStyleBackColor = true;
            this.rBtnEnglish.CheckedChanged += new System.EventHandler(this.OnLanguageChanged);
            // 
            // rBtnSerbian
            // 
            this.rBtnSerbian.AutoSize = true;
            this.rBtnSerbian.Location = new System.Drawing.Point(6, 26);
            this.rBtnSerbian.Name = "rBtnSerbian";
            this.rBtnSerbian.Size = new System.Drawing.Size(69, 24);
            this.rBtnSerbian.TabIndex = 0;
            this.rBtnSerbian.TabStop = true;
            this.rBtnSerbian.Tag = "S";
            this.rBtnSerbian.Text = "Srpski";
            this.rBtnSerbian.UseVisualStyleBackColor = true;
            this.rBtnSerbian.CheckedChanged += new System.EventHandler(this.OnLanguageChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(91, 240);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(109, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Korisnicko ime:";
            // 
            // tBoxUsername
            // 
            this.tBoxUsername.Location = new System.Drawing.Point(91, 263);
            this.tBoxUsername.Name = "tBoxUsername";
            this.tBoxUsername.Size = new System.Drawing.Size(249, 27);
            this.tBoxUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(91, 315);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Lozinka";
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Location = new System.Drawing.Point(91, 338);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.PasswordChar = '*';
            this.tBoxPassword.Size = new System.Drawing.Size(249, 27);
            this.tBoxPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(143, 411);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(151, 53);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Prijava";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 522);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tBoxUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.gBoxLanguage);
            this.Controls.Add(this.lblDobroDosli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoPrevoznikInfo";
            this.gBoxLanguage.ResumeLayout(false);
            this.gBoxLanguage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDobroDosli;
        private System.Windows.Forms.GroupBox gBoxLanguage;
        private System.Windows.Forms.RadioButton rBtnEnglish;
        private System.Windows.Forms.RadioButton rBtnSerbian;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tBoxUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}

