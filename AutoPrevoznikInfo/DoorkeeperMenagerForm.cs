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

    public partial class DoorkeeperMenagerForm : Form
    {
        private Worker loggedInWorker;
        private string selectedLanguage;
        private string selectedTheme="W";
        private WorkerDataAccess workerDA=new WorkerDataAccess();
        public DoorkeeperMenagerForm(Worker w,string l)
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
            SetLanguage();
            FillGridDrivers();
            this.dGVDoorkeepers.ColumnHeadersDefaultCellStyle.SelectionBackColor = this.dGVDoorkeepers.ColumnHeadersDefaultCellStyle.BackColor;
            SetTheme();
        }

        private void FillGridDrivers()
        {
            List<Worker> doorkeepers = workerDA.GetDoorkeeper();
            dGVDoorkeepers.Rows.Clear();
            foreach (Worker w in doorkeepers)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = w
                };
                row.CreateCells(dGVDoorkeepers, w.FirstName, w.LastName, w.Username, w.PhoneNumber, w.WorkerCode);
                dGVDoorkeepers.Rows.Add(row);
            }
            setDataGridColorTab1();
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
                btnLogout.Text = "Odjava";
                lblWorkerType.Text = "Sef portira";
                tabPage1.Text = "Portiri";
                tabPage2.Text = "Autobusi";//
                firstNameColumn.HeaderText = "Ime";
                lastNameColumn.HeaderText = "Prezime";
                userNameColumn.HeaderText = "Korisnicko ime";
                phoneNumberColumn.HeaderText = "Telefon";
                workerCodeColumn.HeaderText = "Sifra";
                btnAddDoorkeeper.Text = "Dodaj portira";
                btnUpdateDoorkeeper.Text = "Izmijeni portira";
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
                lblWorkerType.Text = "Doorkeeper Menager";
                tabPage1.Text = "Doorkeepers";
                tabPage2.Text = "Autobusi";//
                firstNameColumn.HeaderText = "First name";
                lastNameColumn.HeaderText = "Last name";
                userNameColumn.HeaderText = "User name";
                phoneNumberColumn.HeaderText = "Phone";
                workerCodeColumn.HeaderText = "Code";
                btnAddDoorkeeper.Text = "Add doorkeeper";
                btnUpdateDoorkeeper.Text = "Update doorkeeper";
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
                btnLogout.BackColor = Color.Silver;
                btnLogout.ForeColor = Color.Black;

                //desni panel 1:
                tabPage1.BackColor = Color.White;
                btnAddDoorkeeper.BackColor = Color.Silver;
                btnAddDoorkeeper.ForeColor = Color.Black;
                btnDeleteDoorkeeper.BackColor = Color.Silver;
                btnDeleteDoorkeeper.ForeColor = Color.Black;
                btnUpdateDoorkeeper.BackColor = Color.Silver;
                btnUpdateDoorkeeper.ForeColor = Color.Black;
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
                tabPage1.BackColor = Color.FromArgb(39, 38, 40);
                btnAddDoorkeeper.BackColor = Color.FromArgb(163, 128, 209);
                btnAddDoorkeeper.ForeColor = Color.White;
                btnDeleteDoorkeeper.BackColor = Color.FromArgb(163, 128, 209);
                btnDeleteDoorkeeper.ForeColor = Color.White;
                btnUpdateDoorkeeper.BackColor = Color.FromArgb(163, 128, 209);
                btnUpdateDoorkeeper.ForeColor = Color.White;
                btnSendMessage.BackColor = Color.FromArgb(163, 128, 209);
                btnSendMessage.ForeColor = Color.White;
                setDataGridColorTab1();


            }
        }

        private void setDataGridColorTab1()
        {
            if (selectedTheme.Equals("W"))
            {
                dGVDoorkeepers.BackgroundColor = Color.White;
                dGVDoorkeepers.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
                dGVDoorkeepers.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dGVDoorkeepers.ColumnHeadersDefaultCellStyle.SelectionBackColor = dGVDoorkeepers.ColumnHeadersDefaultCellStyle.BackColor;
                dGVDoorkeepers.ForeColor = Color.Black;
                for (int i = 0; i < dGVDoorkeepers.RowCount; i++)
                {
                    for (int j = 0; j < dGVDoorkeepers.ColumnCount; j++)
                        dGVDoorkeepers.Rows[i].Cells[j].Style.BackColor = Color.White;
                }

            }
            else
            {
                dGVDoorkeepers.BackgroundColor = Color.FromArgb(39, 38, 40);
                dGVDoorkeepers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(39, 38, 40);
                dGVDoorkeepers.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(163, 128, 209);
                dGVDoorkeepers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 38, 40);
                dGVDoorkeepers.ForeColor = Color.White;
                for (int i = 0; i < dGVDoorkeepers.RowCount; i++)
                {
                    for (int j = 0; j < dGVDoorkeepers.ColumnCount; j++)
                        dGVDoorkeepers.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(51, 51, 53);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddDoorkeeper_Click(object sender, EventArgs e)
        {
            new AddDoorkeeperForm(null, selectedLanguage, selectedTheme).ShowDialog();
            FillGridDrivers();

        }

        private void btnUpdateDoorkeeper_Click(object sender, EventArgs e)
        {
            Worker selectedDoorkeeper = (Worker)dGVDoorkeepers.SelectedRows[0].Tag;
            new AddDoorkeeperForm(selectedDoorkeeper, selectedLanguage, selectedTheme).ShowDialog();
            FillGridDrivers();
        }

        private void btnDeleteDoorkeeper_Click(object sender, EventArgs e)
        {
            Worker selectedDoorkeeper = (Worker)dGVDoorkeepers.SelectedRows[0].Tag;
            string messageText, headText;
            if (selectedLanguage.Equals("S"))
            {
                messageText = "Da li zelite izbrisati portira?";
                headText = "Brisanje";
            }
            else
            {
                messageText = "Do you want to delete the doorkeeper?";
                headText = "Delete";
            }
            DialogResult dr = MessageBox.Show(messageText, headText, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                workerDA.DeleteDoorkeeper(selectedDoorkeeper);
                FillGridDrivers();
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            Worker selectWorker = (Worker)dGVDoorkeepers.SelectedRows[0].Tag;
            new SendMessageForm(loggedInWorker, selectWorker, selectedLanguage, selectedTheme).ShowDialog();
        }
    }
}
