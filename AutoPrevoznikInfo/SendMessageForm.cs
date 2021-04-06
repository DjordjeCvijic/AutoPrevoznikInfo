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
        private Worker FromWorker, ToWorker;
        private string Language, Theme;
        public SendMessageForm(Worker fromWorker,Worker toWorker,string language,string theme)
        {
            InitializeComponent();
            FromWorker = fromWorker;
            ToWorker = toWorker;
            Language = language;
            Theme = theme;
        }

        private void SetLanguage(string selectedLanguage)
        {
            if (selectedLanguage.Equals("S"))
            {
                lblFromWorker
            }
            else
            {

               

            }
        }
        private void SetTheme(string selectedTheme)
        {

        }
    }
}
