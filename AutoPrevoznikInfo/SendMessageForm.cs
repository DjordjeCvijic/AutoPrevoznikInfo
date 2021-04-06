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
        public SendMessageForm(Worker fromWorker,Worker toWorker,string language,string theme)
        {
            InitializeComponent();
            FromW = fromWorker;
            ToW = toWorker;
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
                btnSend.Text = "Posalji";
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

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (tBoxMessage.TextLength == 0)
                    throw new ArgumentException("Poruka nije unesena. Molimo pokušajte ponovo. ");
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
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

       
    }
}
