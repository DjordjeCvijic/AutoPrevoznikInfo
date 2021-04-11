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
    public partial class AddDriverShiftScheduleForm : Form
    {
        private string selectedDate;
        private string selectedTheme;
        private string selectedLanguage;
        public AddDriverShiftScheduleForm(string date, string language, string theme)
        {
            InitializeComponent();
            selectedDate = date;
            InitializeForm();
            SetTheme(theme);
            selectedTheme = theme;
            selectedLanguage = language;
            SetLanguage(language);
        }

        private void InitializeForm()
        {
            WorkerDataAccess workerDA = new WorkerDataAccess();
            List<Driver> drivers = workerDA.GetDrivers();
            foreach (Driver d in drivers)
            {
                cBoxWorker.Items.Add(new ItemHolder { value = d, text = d.FirstName + " " + d.LastName + " " +d.WorkerCode });
            }
            dTPStartTime.Value = DateTime.Parse("00:00:00");
            dTPEndTime.Value = DateTime.Parse("00:00:00");
            BusLineDataAccess busLineDA = new BusLineDataAccess();
            List<BusLine> lines = busLineDA.GetBusLine();
            foreach(BusLine bLine in lines)
            {
                cBoxSelectBusLine.Items.Add(new ItemHolder { value = bLine, text = bLine.Name+" "+bLine.BusLineCode });
            }

        }
        private void SetLanguage(string language)
        {
            if (language.Equals("S"))
            {
                lblSelectDriver.Text = "Izaberi portira:";
                lblStartTime.Text = "Početak smjene:";
                lblEndTime.Text = "Kraj smjene:";
                btnSave.Text = "Sačuvaj";
                lblSelectBus.Text = "Izaberi autobus:";
                lblSelectBusLine.Text = "Izaberi liniju";
            }
            else
            {
                lblSelectDriver.Text = "Select doorkeeper:";
                lblStartTime.Text = "Start time:";
                lblEndTime.Text = "End time:";
                btnSave.Text = "Save";
                lblSelectBus.Text = "Izaberi autobus:";
                lblSelectBusLine.Text = "Izaberi liniju";
            }
        }

        private void SetTheme(string theme)
        {
            if (theme.Equals("W"))
            {
                this.BackColor = Color.White;
                lblSelectDriver.ForeColor = Color.Black;
                lblSelectBus.ForeColor = Color.Black;
                lblSelectBusLine.ForeColor = Color.Black;
                lblStartTime.ForeColor = Color.Black;
                lblEndTime.ForeColor = Color.Black;

                cBoxWorker.BackColor = Color.White;
                cBoxWorker.ForeColor = Color.Black;
                cBoxSelectBus.BackColor = Color.White;
                cBoxSelectBus.ForeColor = Color.Black;
                cBoxSelectBusLine.BackColor = Color.White;
                cBoxSelectBusLine.ForeColor = Color.Black;

                btnSave.BackColor = Color.Silver;
                btnSave.ForeColor = Color.Black;
            }
            else
            {

                this.BackColor = Color.FromArgb(39, 38, 40);
                lblSelectDriver.ForeColor = Color.DarkGray;
                lblSelectBus.ForeColor = Color.DarkGray;
                lblSelectBusLine.ForeColor = Color.DarkGray;
                lblStartTime.ForeColor = Color.DarkGray;
                lblEndTime.ForeColor = Color.DarkGray;

                cBoxWorker.BackColor = Color.FromArgb(71, 70, 72);
                cBoxWorker.ForeColor = Color.White;
                cBoxSelectBus.BackColor = Color.FromArgb(71, 70, 72);
                cBoxSelectBus.ForeColor = Color.White;
                cBoxSelectBusLine.BackColor = Color.FromArgb(71, 70, 72);
                cBoxSelectBusLine.ForeColor = Color.White;

                btnSave.BackColor = Color.FromArgb(163, 128, 209);
                btnSave.ForeColor = Color.White;

            }
        }

        private void cBoxWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ItemHolder selectedItem = (ItemHolder)cBoxWorker.SelectedItem;
            Driver selectedDriver = (Driver)selectedItem.value;
            cBoxSelectBus.Items.Clear();
            foreach(Bus b in selectedDriver.Buses)
            {
                cBoxSelectBus.Items.Add(new ItemHolder { value = b, text = b.GarageNumber });
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cBoxWorker.SelectedIndex == -1 || cBoxSelectBus.SelectedIndex == -1 || cBoxSelectBusLine.SelectedIndex == -1)
                {
                    string message = null;
                    if (selectedLanguage.Equals("S"))
                        message = "Neka polja nisu popunjena. Molimo pokušajte ponovo. ";
                    else
                        message = "Some fields are not filled. Please try again. ";
                    throw new ArgumentException(message);
                }
               
                    ItemHolder selectedDriver = (ItemHolder)cBoxWorker.SelectedItem;
                    ItemHolder selectedBus = (ItemHolder)cBoxSelectBus.SelectedItem;
                    ItemHolder selectedBusLine = (ItemHolder)cBoxSelectBusLine.SelectedItem;
                    BusLineHasBus element = new BusLineHasBus
                    {
                        BusLine = (BusLine)selectedBusLine.value,
                        Bus = (Bus)selectedBus.value,
                        Driver = (Worker)selectedDriver.value,
                        Date = selectedDate,
                        StartTime = dTPStartTime.Value.ToString("HH:mm:ss"),
                        EndTime = dTPEndTime.Value.ToString("HH:mm:ss")
                    };
                    BusLineHasBusDataAccess busLineHasBusDA = new BusLineHasBusDataAccess();
                    busLineHasBusDA.AddBusLineHasBus(element);

                    this.Close();
                
            }
            catch(Exception ex)
            {
                string message = null;
                if (selectedLanguage.Equals("S"))
                    message = "Greška ";
                else
                    message = "Error";
                MessageBox.Show(ex.Message, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (selectedTheme.Equals("W"))
            {
                if (e.Index < 0)
                    return;

                ComboBox combo = sender as ComboBox;
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    e.Graphics.FillRectangle(new SolidBrush(Color.Silver),
                                             e.Bounds);
                else
                    e.Graphics.FillRectangle(new SolidBrush(combo.BackColor),
                                             e.Bounds);

                e.Graphics.DrawString(combo.Items[e.Index].ToString(), e.Font,
                                      new SolidBrush(combo.ForeColor),
                                      new Point(e.Bounds.X, e.Bounds.Y));

                e.DrawFocusRectangle();
            }
            else
            {
                if (e.Index < 0)
                    return;

                ComboBox combo = sender as ComboBox;
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(163, 128, 209)),
                                             e.Bounds);
                else
                    e.Graphics.FillRectangle(new SolidBrush(combo.BackColor),
                                             e.Bounds);

                e.Graphics.DrawString(combo.Items[e.Index].ToString(), e.Font,
                                      new SolidBrush(combo.ForeColor),
                                      new Point(e.Bounds.X, e.Bounds.Y));

                e.DrawFocusRectangle();
            }
        }
    }
}
