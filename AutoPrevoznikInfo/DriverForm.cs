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
    public partial class DriverForm : Form
    {
        private Worker loggedInWorker;
        private string selectedLanguage;
        private string selectedTheme="W";
        private List<Model.Message> messageToShow;

        public DriverForm(Worker w,string l)
        {
            InitializeComponent();
            loggedInWorker = w;
            selectedLanguage = l;
            InitializeForm();
        }

        private void InitializeForm()
        {
            
            tsmiSerbian.Click += new System.EventHandler(this.SetSerbianLanguage);//dodavanje hendlera i metode
            tsmiEnglish.Click += new System.EventHandler(this.SetEnglishLanguage);
            tsmiWhiteTheme.Click += new System.EventHandler(this.SetWhiteTheme);
            tsmiDarkTheme.Click += new System.EventHandler(this.SetDarkTheme);
            SetLanguage();
            lblWorkerName.Text = loggedInWorker.FirstName + " " + loggedInWorker.LastName;

            MessageDataAccess messageDA = new MessageDataAccess();
            messageToShow = messageDA.GetWorkerMessages(loggedInWorker);
            foreach(Model.Message mess in messageToShow)
            {
                ItemHolder iHolder = new ItemHolder { value = mess, text =mess.FromWorker.FirstName+" "+ mess.FromWorker.LastName + " "+mess.Date };
                lBoxSenderList.Items.Add(iHolder);
            }
        }
        private void SetSerbianLanguage(object sender, EventArgs e)
        {
            if (!selectedLanguage.Equals("S"))
            {
                selectedLanguage = "S";
                SetLanguage();
            }
        }
        private void SetEnglishLanguage(object sender, EventArgs e)
        {
            if (!selectedLanguage.Equals("E"))
            {
                selectedLanguage = "E";
                SetLanguage();
            }
        }
        private void SetWhiteTheme(object sender, EventArgs e)
        {
            if (!selectedTheme.Equals("W"))
            {
                selectedTheme = "W";
                SetTheme();
            }
        }
        private void SetDarkTheme(object sender, EventArgs e)
        {
            if (!selectedTheme.Equals("D"))
            {
                selectedTheme = "D";
                SetTheme();
            }
        }
        private void SetLanguage()
        {
            if (selectedLanguage.Equals("S"))
            {
                tSMILanguage.Text = "Jezik";
                tSMTheme.Text = "Tema";
                tsmiDarkTheme.Text = "Tamna";
                tsmiWhiteTheme.Text = "Svijetla";
                tsmiEnglish.Text = "Engleski";
                tsmiSerbian.Text = "Srpski";
                tabPage1.Text = "Raspored";
                tabPage2.Text = "Obavjestenja";
                lblWorkerType.Text = "Vozac";
            }
            else
            {
                tSMILanguage.Text = "Language";
                tSMTheme.Text = "Theme";
                tsmiDarkTheme.Text = "Dark";
                tsmiWhiteTheme.Text = "White";
                tsmiEnglish.Text = "English";
                tsmiSerbian.Text = "Serbian";
                tabPage1.Text = "Schedule";
                tabPage2.Text = "Messages";
                lblWorkerType.Text = "Driver";
            }
        }
        private void SetTheme()
        {

        }

        private void lBoxSenderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemHolder selectedItem = (ItemHolder)lBoxSenderList.SelectedItem;
            Model.Message messageToShow = (Model.Message)selectedItem.value;
            tBoxMessage.Text = messageToShow.MessageContent;
        }
    }
}
