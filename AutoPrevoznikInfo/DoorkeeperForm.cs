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
    public partial class DoorkeeperForm : Form
    {
        private Worker loggedInWorker;
        private string selectedLanguage;
        private string selectedTheme="W";
        WorkerRecordAccesData workerRecordDA = new WorkerRecordAccesData();
        public DoorkeeperForm(Worker w,string l)
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
            List<Model.Message> messageToShow = messageDA.GetWorkerMessages(loggedInWorker);
            foreach (Model.Message mess in messageToShow)
            {
                ItemHolder iHolder = new ItemHolder { value = mess, text = mess.FromWorker.FirstName + " " + mess.FromWorker.LastName + " " + mess.Date };
                lBoxSenderList.Items.Add(iHolder);
            }
            FillGridWorkerRecords();
            SetTheme();
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
                tabPage2.Text = "Obavjestenja";
                lblWorkerType.Text = "Portir";
                btnLogout.Text = "Odjava";
                tabPage1.Text = "Evidencija radnika";
                firstNameColumn.HeaderText = "Ime";
                lastNameColumn.HeaderText = "Prezime";
                dateColumn.HeaderText = "Datum";
                enterTimeColumn.HeaderText = "Vrijeme ulaska";
                exitTimeColumn.HeaderText = "Vrijeme izlaska";
                btnAddEntry.Text = "Zabiljezi ulazak";
                btnAddExitTime.Text = "Zabiljezi izlazak";
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
                lblWorkerType.Text = "Doorkeeper";
                btnLogout.Text = "Logout";
                tabPage1.Text = "Employee records";
                firstNameColumn.HeaderText = "First name";
                lastNameColumn.HeaderText = "Last name";
                dateColumn.HeaderText = "Date";
                enterTimeColumn.HeaderText = "Entry time";
                exitTimeColumn.HeaderText = "Exit time";
                btnAddEntry.Text = "Add entry time";
                btnAddExitTime.Text = "Add exit time";
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
                btnAddEntry.BackColor = Color.Silver;
                btnAddEntry.ForeColor = Color.Black;
                btnAddExitTime.BackColor = Color.Silver;
                btnAddExitTime.ForeColor = Color.Black;

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
                btnAddEntry.BackColor = Color.FromArgb(163, 128, 209);
                btnAddEntry.ForeColor = Color.White;
                btnAddExitTime.BackColor = Color.FromArgb(163, 128, 209);
                btnAddExitTime.ForeColor = Color.White;

                setDataGridColorTab1();
            }

        }
        private void setDataGridColorTab1()
        {
            if (selectedTheme.Equals("W"))
            {
                dGVWorkerRecord.BackgroundColor = Color.White;
                dGVWorkerRecord.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
                dGVWorkerRecord.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dGVWorkerRecord.ColumnHeadersDefaultCellStyle.SelectionBackColor = dGVWorkerRecord.ColumnHeadersDefaultCellStyle.BackColor;
                dGVWorkerRecord.ForeColor = Color.Black;
                for (int i = 0; i < dGVWorkerRecord.RowCount; i++)
                {
                    for (int j = 0; j < dGVWorkerRecord.ColumnCount; j++)
                        dGVWorkerRecord.Rows[i].Cells[j].Style.BackColor = Color.White;
                }

            }
            else
            {
                dGVWorkerRecord.BackgroundColor = Color.FromArgb(39, 38, 40);
                dGVWorkerRecord.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(39, 38, 40);
                dGVWorkerRecord.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(163, 128, 209);
                dGVWorkerRecord.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 38, 40);
                dGVWorkerRecord.ForeColor = Color.White;
                for (int i = 0; i < dGVWorkerRecord.RowCount; i++)
                {
                    for (int j = 0; j < dGVWorkerRecord.ColumnCount; j++)
                        dGVWorkerRecord.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(51, 51, 53);
                }
            }

        }

        private void lBoxSenderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemHolder selectedItem = (ItemHolder)lBoxSenderList.SelectedItem;
            Model.Message messageToShow = (Model.Message)selectedItem.value;
            tBoxMessage.Text = messageToShow.MessageContent;
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            new AddWorkerEntryForm(selectedLanguage, selectedTheme).ShowDialog();
            FillGridWorkerRecords();
        }
        private void FillGridWorkerRecords()
        {
            List<WorkerRecord> records = workerRecordDA.GetWorkerRecords();
            dGVWorkerRecord.Rows.Clear();
            string exitTime;
            foreach (WorkerRecord record in records)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = record
                };
                exitTime = record.ExitTime;
                if (record.ExitTime.Equals("00:00:00"))
                    exitTime = "-";
                row.CreateCells(dGVWorkerRecord, record.Worker.FirstName, record.Worker.LastName, record.Date, record.EnterTime, exitTime);
                dGVWorkerRecord.Rows.Add(row);
            }
            setDataGridColorTab1();
        }

        private void btnAddExitTime_Click(object sender, EventArgs e)
        {
            string exitTime = DateTime.Now.ToString("HH:mm:ss");
            WorkerRecord selectedWorkerRecord = (WorkerRecord)dGVWorkerRecord.SelectedRows[0].Tag;
            if (selectedWorkerRecord.ExitTime.Equals("00:00:00"))
            {
                string messageText, headText;
                if (selectedLanguage.Equals("S"))
                {
                    messageText = selectedWorkerRecord.Worker.FirstName + " " + selectedWorkerRecord.Worker.LastName + ", vrijeme izlaska:" + exitTime;
                    headText = "Izlazak";
                }
                else
                {
                    messageText = selectedWorkerRecord.Worker.FirstName + " " + selectedWorkerRecord.Worker.LastName + ", exit time:" + exitTime;
                    headText = "Exit";
                }
                DialogResult dr = MessageBox.Show(messageText, headText, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    selectedWorkerRecord.ExitTime = exitTime;
                    selectedWorkerRecord.Date = DateTime.Now.ToString("yyyy-MM-dd");
                    workerRecordDA.AddExitTime(selectedWorkerRecord);
                    FillGridWorkerRecords();

                }
            }
            


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
