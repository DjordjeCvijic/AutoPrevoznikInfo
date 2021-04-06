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
            }
        }
        private void SetTheme()
        {

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
    }
}
