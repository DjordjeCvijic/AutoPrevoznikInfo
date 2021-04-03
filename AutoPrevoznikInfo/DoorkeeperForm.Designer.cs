
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tSMILanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSerbian = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWhiteTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDarkTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMILanguage,
            this.tSMTheme});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
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
            // DoorkeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoorkeeperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoorkeeperForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tSMILanguage;
        private System.Windows.Forms.ToolStripMenuItem tsmiSerbian;
        private System.Windows.Forms.ToolStripMenuItem tsmiEnglish;
        private System.Windows.Forms.ToolStripMenuItem tSMTheme;
        private System.Windows.Forms.ToolStripMenuItem tsmiWhiteTheme;
        private System.Windows.Forms.ToolStripMenuItem tsmiDarkTheme;
    }
}