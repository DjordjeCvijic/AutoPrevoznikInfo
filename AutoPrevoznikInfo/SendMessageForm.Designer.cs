
namespace AutoPrevoznikInfo
{
    partial class SendMessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMessageForm));
            this.lblFromWorker = new System.Windows.Forms.Label();
            this.lblToWorker = new System.Windows.Forms.Label();
            this.tBoxMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFromWorker
            // 
            this.lblFromWorker.AutoSize = true;
            this.lblFromWorker.Location = new System.Drawing.Point(55, 39);
            this.lblFromWorker.Name = "lblFromWorker";
            this.lblFromWorker.Size = new System.Drawing.Size(50, 20);
            this.lblFromWorker.TabIndex = 0;
            this.lblFromWorker.Text = "label1";
            // 
            // lblToWorker
            // 
            this.lblToWorker.AutoSize = true;
            this.lblToWorker.Location = new System.Drawing.Point(55, 82);
            this.lblToWorker.Name = "lblToWorker";
            this.lblToWorker.Size = new System.Drawing.Size(50, 20);
            this.lblToWorker.TabIndex = 1;
            this.lblToWorker.Text = "label1";
            // 
            // tBoxMessage
            // 
            this.tBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxMessage.Location = new System.Drawing.Point(55, 168);
            this.tBoxMessage.Multiline = true;
            this.tBoxMessage.Name = "tBoxMessage";
            this.tBoxMessage.Size = new System.Drawing.Size(587, 276);
            this.tBoxMessage.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(55, 135);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 20);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "label1";
            // 
            // btnSend
            // 
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(258, 480);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(140, 52);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "button1";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // SendMessageForm
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 574);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tBoxMessage);
            this.Controls.Add(this.lblToWorker);
            this.Controls.Add(this.lblFromWorker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoPrevoznikForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFromWorker;
        private System.Windows.Forms.Label lblToWorker;
        private System.Windows.Forms.TextBox tBoxMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnSend;
    }
}