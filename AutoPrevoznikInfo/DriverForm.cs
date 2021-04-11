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
        private WorkerDataAccess workerDA = new WorkerDataAccess();

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
            selectedTheme = loggedInWorker.Theme;
            SetTheme();
            lblWorkerName.Text = loggedInWorker.FirstName + " " + loggedInWorker.LastName;

            MessageDataAccess messageDA = new MessageDataAccess();
             List<Model.Message>  messageToShow = messageDA.GetWorkerMessages(loggedInWorker);
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
               
                tabPage2.Text = "Obavještenja";
                lblWorkerType.Text = "Vozač";
                btnLogout.Text = "Odjava";
            }
            else
            {
                tSMILanguage.Text = "Language";
                tSMTheme.Text = "Theme";
                tsmiDarkTheme.Text = "Dark";
                tsmiWhiteTheme.Text = "White";
                tsmiEnglish.Text = "English";
                tsmiSerbian.Text = "Serbian";
                
                tabPage2.Text = "Messages";
                lblWorkerType.Text = "Driver";
                btnLogout.Text = "Logout";
            }
        }
        private void SetTheme()
        {
            if (selectedTheme.Equals("W"))
            {
                //meni na vrhu:
                menuStrip1.BackColor = Control.DefaultBackColor;

                tsmiSerbian.BackColor = Control.DefaultBackColor;
                tsmiEnglish.BackColor = Control.DefaultBackColor;
                tsmiWhiteTheme.BackColor = Control.DefaultBackColor;
                tsmiDarkTheme.BackColor = Control.DefaultBackColor;

                tSMILanguage.ForeColor = Color.Black;
                tSMTheme.ForeColor = Color.Black;
                tsmiDarkTheme.ForeColor = Color.Black;
                tsmiWhiteTheme.ForeColor = Color.Black;
                tsmiEnglish.ForeColor = Color.Black;
                tsmiSerbian.ForeColor = Color.Black;

                this.BackColor = Control.DefaultBackColor;

                //lijevi meni
                panelLeft.BackColor = Control.DefaultBackColor;
                lblWorkerName.ForeColor = Color.Black;
                lblWorkerType.ForeColor = Color.Black;
                btnLogout.BackColor = Color.Silver;
                btnLogout.ForeColor = Color.Black;
                btnShowShiftSchedule.BackColor = Color.Silver;
                btnShowShiftSchedule.ForeColor = Color.Black;
                //desni panel:
                tabPage2.BackColor = Color.White;
                lBoxSenderList.BackColor = Color.White;
                lBoxSenderList.ForeColor = Color.Black;
                tBoxMessage.BackColor = Color.White;
                tBoxMessage.ForeColor = Color.Black;
                lblMessage.ForeColor = Color.Black;
                lblSelectMessage.ForeColor = Color.Black;

            }
            else
            {
                menuStrip1.BackColor = Color.FromArgb(51, 51, 53);

                tsmiSerbian.BackColor = Color.FromArgb(51, 51, 53);
                tsmiEnglish.BackColor = Color.FromArgb(51, 51, 53);
                tsmiWhiteTheme.BackColor = Color.FromArgb(51, 51, 53);
                tsmiDarkTheme.BackColor = Color.FromArgb(51, 51, 53);

                tSMILanguage.ForeColor = Color.White;
                tSMTheme.ForeColor = Color.White;
                tsmiDarkTheme.ForeColor = Color.White;
                tsmiWhiteTheme.ForeColor = Color.White;
                tsmiEnglish.ForeColor = Color.White;
                tsmiSerbian.ForeColor = Color.White;

                this.BackColor = Color.FromArgb(51, 51, 53);

                //lijevi meni
                panelLeft.BackColor = Color.FromArgb(39, 38, 40);
                lblWorkerName.ForeColor = Color.White;
                lblWorkerType.ForeColor = Color.White;
                btnLogout.BackColor = Color.FromArgb(163, 128, 209);
                btnLogout.ForeColor = Color.White;
                btnShowShiftSchedule.BackColor = Color.FromArgb(163, 128, 209);
                btnShowShiftSchedule.ForeColor = Color.White;

                //tab
                tabPage2.BackColor = Color.FromArgb(39, 38, 40);
                lBoxSenderList.BackColor = Color.FromArgb(71, 70, 72);
                lBoxSenderList.ForeColor = Color.DarkGray;
                tBoxMessage.BackColor = Color.FromArgb(71, 70, 72);
                tBoxMessage.ForeColor = Color.White;
                lblMessage.ForeColor = Color.DarkGray;
                lblSelectMessage.ForeColor = Color.DarkGray;

            }

        }

        private void lBoxSenderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemHolder selectedItem = (ItemHolder)lBoxSenderList.SelectedItem;
            Model.Message messageToShow = (Model.Message)selectedItem.value;
            tBoxMessage.Text = messageToShow.MessageContent;
        }

        private void btnShowShiftSchedule_Click(object sender, EventArgs e)
        {
            new ShiftScheduleForm(loggedInWorker, selectedLanguage, selectedTheme).ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (!selectedTheme.Equals(loggedInWorker.Theme))
            {
                loggedInWorker.Theme = selectedTheme;
                workerDA.UpdateWorker(loggedInWorker);
            }
            this.Close();
        }
    }
}
