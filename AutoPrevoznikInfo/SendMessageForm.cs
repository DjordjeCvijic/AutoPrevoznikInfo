using AutoPrevoznikInfo.DataAccess;
using AutoPrevoznikInfo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoPrevoznikInfo
{
    public partial class SendMessageForm : Form
    {
        private Worker FromW, ToW;
        private string selectedLanguage;
        public SendMessageForm(Worker fromWorker,Worker toWorker,string language,string theme)
        {
            InitializeComponent();
            FromW = fromWorker;
            ToW = toWorker;
            selectedLanguage = language;
            SetLanguage(language);
            SetTheme(theme);
        }

        private void SetLanguage(string selectedLanguage)
        {
            if (selectedLanguage.Equals("S"))
            {
                lblFromWorker.Text = "OD: " + FromW.FirstName + " " + FromW.LastName;
                lblToWorker.Text = "ZA: " + ToW.FirstName + " " + ToW.LastName;
                lblMessage.Text = "Poruka:";
                btnSend.Text = "Pošalji";
            }
            else
            {
                lblFromWorker.Text = "FROM: " + FromW.FirstName + " " + FromW.LastName;
                lblToWorker.Text = "TO: " + ToW.FirstName + " " + ToW.LastName;
                lblMessage.Text = "Message:";
                btnSend.Text = "Send";


            }
        }
        private void SetTheme(string selectedTheme)
        {
            if (selectedTheme.Equals("W"))
            {
                this.BackColor = Color.White;
                lblFromWorker.ForeColor = Color.Black;
                lblToWorker.ForeColor = Color.Black;
                lblMessage.ForeColor = Color.Black;
                tBoxMessage.BackColor = Color.White;
                tBoxMessage.ForeColor = Color.Black;
                btnSend.BackColor = Color.Silver;
                btnSend.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.FromArgb(39, 38, 40);
                lblFromWorker.ForeColor =Color.DarkGray;
                lblToWorker.ForeColor = Color.DarkGray;
                lblMessage.ForeColor = Color.DarkGray;
                tBoxMessage.BackColor = Color.FromArgb(71, 70, 72);
                tBoxMessage.ForeColor = Color.White;
                btnSend.BackColor = Color.FromArgb(163, 128, 209);
                btnSend.ForeColor = Color.White;

            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (tBoxMessage.TextLength == 0)
                {
                    string messageOfError = null;
                    if (selectedLanguage.Equals("S"))
                        messageOfError = "Poruka nije unesena. Molimo pokušajte ponovo. ";
                    else
                        messageOfError = "Message is missing. Please try again. ";
                    throw new ArgumentException(messageOfError);
                }
                
                Model.Message message = new Model.Message()
                {
                    FromWorker = FromW,
                    ToWorker = ToW,
                    MessageContent = tBoxMessage.Text,
                    Date = DateTime.Now.ToString("yyyy-MM-dd hh-mm")
                };
                MessageDataAccess messageDA = new MessageDataAccess();
                messageDA.AddMessage(message);
                this.Close();
            }
            catch(Exception ex){
                string message = null;
                if (selectedLanguage.Equals("S"))
                    message = "Greška ";
                else
                    message = "Error";
                MessageBox.Show(ex.Message, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

       
    }
}
