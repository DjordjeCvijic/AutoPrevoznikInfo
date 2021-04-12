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
        private BusDataAccess busDA = new BusDataAccess();
        private ShiftScheduleDataAccess shiftScheduleDA = new ShiftScheduleDataAccess();
        private BusLineHasBusDataAccess busLineHasBusDA = new BusLineHasBusDataAccess();
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
            FillGridBuses();
            selectedTheme = loggedInWorker.Theme;
            SetLanguage();
            this.dGVDrivers.ColumnHeadersDefaultCellStyle.SelectionBackColor = this.dGVDrivers.ColumnHeadersDefaultCellStyle.BackColor;

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
                lblWorkerType.Text = "Menadžer saobraćaja";
                tabPage1.Text = "Vozači";
                tabPage2.Text = "Autobusi";
                tabPage3.Text = "Raspored smjena";
                firstNameColumn.HeaderText = "Ime";
                lastNameColumn.HeaderText = "Prezime";
                userNameColumn.HeaderText = "Korisničko ime";
                phoneNumberColumn.HeaderText = "Telefon";
                workerCodeColumn.HeaderText = "Šifra";
                btnAddWorker.Text = "Dodaj vozača";
                btnDelete.Text = "Obriši podatke";
                btnUpdateDriver.Text = "Izmijeni podatke";
                btnSendMessage.Text = "Pošalji poruku";

                btnAddBus.Text = "Dodaj autobus";
                btnEditBus.Text = "Izmijeni podatke";
                btnDeleteBus.Text = "Izbriši podatke";
                busGarageNumberColumn.HeaderText = "Garažni broj";
                busTypeColumn.HeaderText = "Tip autobusa";
                numberOfSeatsColumn.HeaderText = "Broj sjedista";
                numberOfDoorsColumn.HeaderText = "Broj vrata";
                busCapacityComun.HeaderText = "Kapacitet";

                lblSelectDate.Text = "Izaberi datum:";
                btnAddShift.Text = "Dodaj smjenu";
                firstNameColumn2.HeaderText = "Ime";
                lastNameColumn2.HeaderText = "Prezime";
                workerCodeColumn2.HeaderText = "Šifra";
                startTimeColumn2.HeaderText = "Početak smjene";
                endTimeColumn2.HeaderText = "Kraj smjene";
                busColumn.HeaderText = "Autobus";
                busLineColumn.HeaderText = "Linija";
                btnDeleteShift.Text = "Izbriši smjenu";

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
                tabPage3.Text = "Shift schedule";
                firstNameColumn.HeaderText = "First name";
                lastNameColumn.HeaderText = "Last name";
                userNameColumn.HeaderText = "User name";
                phoneNumberColumn.HeaderText = "Phone";
                workerCodeColumn.HeaderText = "Code";
                btnAddWorker.Text = "Add driver";
                btnDelete.Text = "Delete data";
                btnUpdateDriver.Text = "Update data";
                btnSendMessage.Text = "Send message";
                btnAddBus.Text = "Add bus";
                btnEditBus.Text = "Edit data";
                btnDeleteBus.Text = "Delete data";
                busGarageNumberColumn.HeaderText = "Garage number";
                busTypeColumn.HeaderText = "Bus type";
                numberOfSeatsColumn.HeaderText = "Number of seats";
                numberOfDoorsColumn.HeaderText = "Number od doors";
                busCapacityComun.HeaderText = "Capacity";

                lblSelectDate.Text = "Choose date:";
                btnAddShift.Text = "Add shift";
                firstNameColumn2.HeaderText = "First name";
                lastNameColumn2.HeaderText = "Last name";
                workerCodeColumn2.HeaderText = "Code";
                startTimeColumn2.HeaderText = "Start time";
                endTimeColumn2.HeaderText = "End time";
                busColumn.HeaderText = "Buses";
                busLineColumn.HeaderText = "Bus lines";
                btnDeleteShift.Text = "Delete shift";
            }
            FillGridBuses();
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

                //desni panel tab2:
                tabPage2.BackColor = Color.White;
                btnAddBus.BackColor = Color.Silver;
                btnAddBus.ForeColor = Color.Black;
                btnEditBus.BackColor = Color.Silver;
                btnEditBus.ForeColor = Color.Black;
                btnDeleteBus.BackColor = Color.Silver;
                btnDeleteBus.ForeColor = Color.Black;

                //desni panel tab3
                tabPage3.BackColor = Color.White;
                calendar.BackColor = Color.White;
                calendar.ForeColor = Color.Black;
                lblSelectDate.ForeColor = Color.Black;
                btnAddShift.BackColor = Color.Silver;
                btnAddShift.ForeColor = Color.Black;
                btnDeleteShift.BackColor = Color.Silver;
                btnDeleteShift.ForeColor = Color.Black;

                setDataGridColorTab1();
                setDataGridColorTab2();
                setDataGridColorTab3();

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

                //desni panel tab2:
                tabPage2.BackColor = Color.FromArgb(39, 38, 40);
                btnAddBus.BackColor = Color.FromArgb(163, 128, 209);
                btnAddBus.ForeColor = Color.White;
                btnEditBus.BackColor = Color.FromArgb(163, 128, 209);
                btnEditBus.ForeColor = Color.White;
                btnDeleteBus.BackColor = Color.FromArgb(163, 128, 209);
                btnDeleteBus.ForeColor = Color.White;
                //desni panel tab3:
                tabPage3.BackColor = Color.FromArgb(39, 38, 40);
                calendar.BackColor = Color.FromArgb(71, 70, 72);
                calendar.ForeColor = Color.White;
                lblSelectDate.ForeColor = Color.DarkGray;
                btnAddShift.BackColor = Color.FromArgb(163, 128, 209);
                btnAddShift.ForeColor = Color.White;
                btnDeleteShift.BackColor = Color.FromArgb(163, 128, 209); ;
                btnDeleteShift.ForeColor = Color.White;

                setDataGridColorTab1();
                setDataGridColorTab2();
                setDataGridColorTab3();
            }
           
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
                messageText = "Da li želite izbrisati vozača ?";
                headText = "Brisanje";
            }
            else
            {
                messageText = "Do you want to delete the driver ?";
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

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            new AddBusForm(null, selectedLanguage,selectedTheme).ShowDialog();
            FillGridBuses();
        }

        private void btnEditBus_Click(object sender, EventArgs e)
        {
            Bus selectedBus = (Bus)dGVBus.SelectedRows[0].Tag;
            new AddBusForm(selectedBus, selectedLanguage, selectedTheme).ShowDialog();
            FillGridBuses();
        }

        private void btnDeleteBus_Click(object sender, EventArgs e)
        {
            Bus selectedBus = (Bus)dGVBus.SelectedRows[0].Tag;
            string messageText, headText;
            if (selectedLanguage.Equals("S"))
            {
                messageText = "Da li želite izbrisati autobus ?";
                headText = "Brisanje";
            }
            else
            {
                messageText = "Do you want to delete the bus ?";
                headText = "Delete";
            }
            DialogResult dr = MessageBox.Show(messageText, headText, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                busDA.DeleteBus(selectedBus);
                FillGridBuses();
            }
        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            string selectedDate = calendar.SelectionRange.Start.ToString("yyyy-MM-dd");

            FillGridShifts(selectedDate);
        }

        private void FillGridDrivers()
        {

            List<Driver> drivers = workerDA.GetDrivers();
            dGVDrivers.Rows.Clear();
            foreach (Driver d in drivers)
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
        private void FillGridShifts(string selectedDate)
        {
            List<BusLineHasBus> list =busLineHasBusDA.GetBusLineHasBus();
           
            List<BusLineHasBus> listToShow = new List<BusLineHasBus>();
            foreach (BusLineHasBus s in list)
            {
                if (DateTime.Compare(DateTime.Parse(selectedDate), DateTime.Parse(s.Date)) == 0)
                {
                    listToShow.Add(s);
                }
            }

            dGVSchedule.Rows.Clear();
            foreach (BusLineHasBus s in listToShow)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = s
                };
                row.CreateCells(dGVSchedule, s.Driver.FirstName,s.Driver.LastName,s.Driver.WorkerCode,s.StartTime,s.EndTime,s.Bus.GarageNumber,s.BusLine.Name);
                dGVSchedule.Rows.Add(row);
            }

            setDataGridColorTab3();
        }
        private void FillGridBuses()
        {
            List<Bus> buses = busDA.GetBuses();

            dGVBus.Rows.Clear();
            foreach (Bus b in buses)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = b
                };
                string type = null;
                if (selectedLanguage.Equals("S"))
                {
                    if (b.BusType.Equals("G"))
                        type = "Gradski";
                    else type = "Prigradski";
                }
                else
                {
                    if (b.BusType.Equals("G"))
                        type = "Urban";
                    else type = "Suburban";
                }
                row.CreateCells(dGVDrivers, b.GarageNumber, type, b.NumberOfSeats, b.NumberOfDoors, b.Capacity);
                dGVBus.Rows.Add(row);
            }
            setDataGridColorTab2();
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
        private void setDataGridColorTab2()
        {
            if (selectedTheme.Equals("W"))
            {
                dGVBus.BackgroundColor = Color.White;
                dGVBus.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
                dGVBus.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dGVBus.ColumnHeadersDefaultCellStyle.SelectionBackColor = dGVBus.ColumnHeadersDefaultCellStyle.BackColor;
                dGVBus.ForeColor = Color.Black;
                for (int i = 0; i < dGVBus.RowCount; i++)
                {
                    for (int j = 0; j < dGVBus.ColumnCount; j++)
                        dGVBus.Rows[i].Cells[j].Style.BackColor = Color.White;
                }

            }
            else
            {
                dGVBus.BackgroundColor = Color.FromArgb(39, 38, 40);
                dGVBus.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(39, 38, 40);
                dGVBus.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(163, 128, 209);
                dGVBus.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 38, 40);
                dGVBus.ForeColor = Color.White;
                for (int i = 0; i < dGVBus.RowCount; i++)
                {
                    for (int j = 0; j < dGVBus.ColumnCount; j++)
                        dGVBus.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(51, 51, 53);
                }
            }
        }
        private void setDataGridColorTab3()
        {
            if (selectedTheme.Equals("W"))
            {
                dGVSchedule.BackgroundColor = Color.White;
                dGVSchedule.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
                dGVSchedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dGVSchedule.ColumnHeadersDefaultCellStyle.SelectionBackColor = dGVSchedule.ColumnHeadersDefaultCellStyle.BackColor;
                dGVSchedule.ForeColor = Color.Black;
                for (int i = 0; i < dGVSchedule.RowCount; i++)
                {
                    for (int j = 0; j < dGVSchedule.ColumnCount; j++)
                        dGVSchedule.Rows[i].Cells[j].Style.BackColor = Color.White;
                }

            }
            else
            {
                dGVSchedule.BackgroundColor = Color.FromArgb(39, 38, 40);
                dGVSchedule.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(39, 38, 40);
                dGVSchedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(163, 128, 209);
                dGVSchedule.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 38, 40);
                dGVSchedule.ForeColor = Color.White;
                for (int i = 0; i < dGVSchedule.RowCount; i++)
                {
                    for (int j = 0; j < dGVSchedule.ColumnCount; j++)
                        dGVSchedule.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(51, 51, 53);
                }
            }
        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            string selectedDate = calendar.SelectionRange.Start.ToString("yyyy-MM-dd");
            new AddDriverShiftScheduleForm(selectedDate, selectedLanguage, selectedTheme).ShowDialog();
            FillGridShifts(selectedDate);
        }

        private void btnDeleteShift_Click(object sender, EventArgs e)
        {
            BusLineHasBus shiftToDelete = (BusLineHasBus)dGVSchedule.SelectedRows[0].Tag;
            string messageText, headText;
            if (selectedLanguage.Equals("S"))
            {
                messageText = "Da li želite izbrisati izabranu smjenu ?";
                headText = "Brisanje";
            }
            else
            {
                messageText = "Do you want to delete selected shift ?";
                headText = "Delete";
            }
            DialogResult dr = MessageBox.Show(messageText, headText, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                busLineHasBusDA.DeleteBusLineHasBus(shiftToDelete);
                string selectedDate = calendar.SelectionRange.Start.ToString("yyyy-MM-dd");

                FillGridShifts(selectedDate);
            }
        }
    }
}
