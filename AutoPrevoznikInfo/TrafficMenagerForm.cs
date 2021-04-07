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
    public partial class TrafficMenagerForm : Form
    {
        private Worker loggedInWorker;
        private string selectedLanguage;
        private string selectedTheme = "W";
        private WorkerDataAccess workerDA = new WorkerDataAccess();
        public TrafficMenagerForm(Worker w,string l)
        {
            InitializeComponent();
            loggedInWorker = w;
            selectedLanguage = l;
            InitializeForm();
        }

        private void InitializeForm()
        {
            

            lblWorkerName.Text = loggedInWorker.FirstName + " " + loggedInWorker.LastName;
            tsmiSerbian.Click += new System.EventHandler(this.SetSerbianLanguage);//dodavanje hendlera i metode
            tsmiEnglish.Click += new System.EventHandler(this.SetEnglishLanguage);
            tsmiWhiteTheme.Click += new System.EventHandler(this.SetWhiteTheme);
            tsmiDarkTheme.Click += new System.EventHandler(this.SetDarkTheme);
            FillGridDrivers();
            SetLanguage();
            this.dGVDrivers.ColumnHeadersDefaultCellStyle.SelectionBackColor = this.dGVDrivers.ColumnHeadersDefaultCellStyle.BackColor;

            /*btnAddWorker.TabStop = false;
            btnAddWorker.FlatStyle = FlatStyle.Flat;
            btnAddWorker.FlatAppearance.BorderSize = 0;*/
            SetTheme();

           
        }
        private void SetSerbianLanguage(object sender,EventArgs e)
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
                btnLogout.Text = "Odjava";
                lblWorkerType.Text = "Menadzer saobracaja";
                tabPage1.Text = "Vozaci";
                tabPage2.Text = "Autobusi";
                firstNameColumn.HeaderText = "Ime";
                lastNameColumn.HeaderText = "Prezime";
                userNameColumn.HeaderText = "Korisnicko ime";
                phoneNumberColumn.HeaderText = "Telefon";
                workerCodeColumn.HeaderText = "Sifra";
                btnAddWorker.Text = "Dodaj vozaca";
                btnUpdateDriver.Text = "Izmijeni podatke";
                btnSendMessage.Text = "Posalji poruku";
            }
            else
            {
                
                tSMILanguage.Text = "Language";
                tSMTheme.Text = "Theme";
                tsmiDarkTheme.Text = "Dark";
                tsmiWhiteTheme.Text = "White";
                tsmiEnglish.Text = "English";
                tsmiSerbian.Text = "Serbian";
                btnLogout.Text = "Logout";
                lblWorkerType.Text = "Traffic manager";
                tabPage1.Text = "Drivers";
                tabPage2.Text = "Buses";
                firstNameColumn.HeaderText = "First name";
                lastNameColumn.HeaderText = "Last name";
                userNameColumn.HeaderText = "User name";
                phoneNumberColumn.HeaderText = "Phone";
                workerCodeColumn.HeaderText = "Code";
                btnAddWorker.Text = "Add driver";
                btnUpdateDriver.Text = "Update driver";
                btnSendMessage.Text = "Send message";
            }
        }
        private void SetTheme()
        {
            if (selectedTheme.Equals("W"))
            {
                //meni na vrhu:
                menuStrip1.BackColor = Color.Silver;
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
                btnLogout.BackColor =Color.Silver;
                btnLogout.ForeColor = Color.Black;

                //desni panel 1:
                tabPage1.BackColor = Color.White;
                btnAddWorker.BackColor = Color.Silver;
                btnAddWorker.ForeColor = Color.Black;
                btnDelete.BackColor = Color.Silver;
                btnDelete.ForeColor = Color.Black;
                btnUpdateDriver.BackColor = Color.Silver;
                btnUpdateDriver.ForeColor = Color.Black;
                btnSendMessage.BackColor = Color.Silver;
                btnSendMessage.ForeColor = Color.Black;
                setDataGridColorTab1();

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

                //desni panel1:
                tabPage1.BackColor= Color.FromArgb(39, 38, 40);
                btnAddWorker.BackColor = Color.FromArgb(163, 128, 209);
                btnAddWorker.ForeColor = Color.White;
                btnDelete.BackColor = Color.FromArgb(163, 128, 209);
                btnDelete.ForeColor = Color.White;
                btnUpdateDriver.BackColor = Color.FromArgb(163, 128, 209);
                btnUpdateDriver.ForeColor = Color.White;
                btnSendMessage.BackColor = Color.FromArgb(163, 128, 209);
                btnSendMessage.ForeColor = Color.White;
                setDataGridColorTab1();
                }
            }

        private void setDataGridColorTab1()
        {
            if (selectedTheme.Equals("W"))
            {
                dGVDrivers.BackgroundColor = Color.White;
                dGVDrivers.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
                dGVDrivers.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dGVDrivers.ColumnHeadersDefaultCellStyle.SelectionBackColor = dGVDrivers.ColumnHeadersDefaultCellStyle.BackColor;
                dGVDrivers.ForeColor = Color.Black;
                for (int i = 0; i < dGVDrivers.RowCount; i++)
                {
                    for (int j = 0; j < dGVDrivers.ColumnCount; j++)
                        dGVDrivers.Rows[i].Cells[j].Style.BackColor = Color.White;
                }

            }
            else
            {
                dGVDrivers.BackgroundColor = Color.FromArgb(39, 38, 40);
                dGVDrivers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(39, 38, 40);
                dGVDrivers.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(163, 128, 209);
                dGVDrivers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 38, 40);
                dGVDrivers.ForeColor = Color.White;
                for (int i = 0; i < dGVDrivers.RowCount; i++)
                {
                    for (int j = 0; j < dGVDrivers.ColumnCount; j++)
                        dGVDrivers.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(51, 51, 53);
                }
            }
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillGridDrivers()
        {
           
            List<Driver> drivers = workerDA.GetDrivers();
            dGVDrivers.Rows.Clear();
            foreach(Driver d in drivers)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = d
                };
                row.CreateCells(dGVDrivers, d.FirstName, d.LastName, d.Username, d.PhoneNumber, d.WorkerCode);
                dGVDrivers.Rows.Add(row);
            }
            setDataGridColorTab1();
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            new AddDriverForm(null, selectedLanguage, selectedTheme).ShowDialog();
            FillGridDrivers();
        }

        private void btnUpdateDriver_Click(object sender, EventArgs e)
        {
            Driver selectedDriver = (Driver)dGVDrivers.SelectedRows[0].Tag;
            new AddDriverForm(selectedDriver, selectedLanguage, selectedTheme).ShowDialog();
            FillGridDrivers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Driver selectedDriver = (Driver)dGVDrivers.SelectedRows[0].Tag;
            string messageText, headText;
            if (selectedLanguage.Equals("S"))
            {
                messageText = "Da li zelite izbrisati vozaca?";
                headText = "Brisanje";
            }
            else
            {
                messageText = "Do you want to delete the driver?";
                headText = "Delete";
            }
            DialogResult dr = MessageBox.Show(messageText, headText, MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                workerDA.DeleteDriver(selectedDriver);
                FillGridDrivers();
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            Driver selectedDriver = (Driver)dGVDrivers.SelectedRows[0].Tag;
            new SendMessageForm(loggedInWorker, selectedDriver, selectedLanguage, selectedTheme).ShowDialog();
        }
    }
}
