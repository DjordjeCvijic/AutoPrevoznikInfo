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
    public partial class AddShiftScheduleForm : Form
    {
        private string selectedDate;
        private string selectedTheme;
        private string selectedLanguage;
        public AddShiftScheduleForm(string date,string language,string theme)
        {
            InitializeComponent();
            selectedDate = date;
            selectedTheme = theme;
            selectedLanguage = language;
            InitializeForm();
            SetTheme(theme);
            SetLanguage(language);
        }

        private void InitializeForm()
        {
            WorkerDataAccess workerDA = new WorkerDataAccess();
            List<Worker> doorkeepers = workerDA.GetDoorkeeper();
            foreach(Worker w in doorkeepers)
            {
                cBoxWorker.Items.Add(new ItemHolder { value = w, text = w.FirstName + " " + w.LastName + " " + w.WorkerCode });
            }
            dTPStartTime.Value = DateTime.Parse("00:00:00");
            dTPEndTime.Value = DateTime.Parse("00:00:00");
        }
        private void SetLanguage(string language)
        {
            if (language.Equals("S"))
            {
                lblSelectDoorkeeper.Text = "Izaberi portira:";
                lblStartTime.Text = "Početak smjene:";
                lblEndTime.Text = "Kraj smjene:";
                btnSave.Text = "Sačuvaj";

            }
            else
            {
                lblSelectDoorkeeper.Text = "Select doorkeeper:";
                lblStartTime.Text = "Start time:";
                lblEndTime.Text = "End time:";
                btnSave.Text = "Save";

            }
        }

        private void SetTheme(string theme)
        {
            if (theme.Equals("W"))
            {
                this.BackColor = Color.White;
                lblSelectDoorkeeper.ForeColor = Color.Black;
                lblStartTime.ForeColor = Color.Black;
                lblEndTime.ForeColor = Color.Black;

                btnSave.BackColor = Color.Silver;
                btnSave.ForeColor = Color.Black;

                cBoxWorker.BackColor = Color.White;
                cBoxWorker.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.FromArgb(39, 38, 40);
                lblSelectDoorkeeper.ForeColor = Color.DarkGray;
                lblStartTime.ForeColor = Color.DarkGray;
                lblEndTime.ForeColor = Color.DarkGray;

                btnSave.BackColor = Color.FromArgb(163, 128, 209);
                btnSave.ForeColor = Color.White;

                cBoxWorker.BackColor = Color.FromArgb(71, 70, 72);
                cBoxWorker.ForeColor = Color.White;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cBoxWorker.SelectedIndex == -1)
            {
                string headMessage = null;
                if (selectedLanguage.Equals("S"))
                    headMessage = "Greška ";
                else
                    headMessage = "Error";
                string message = null;
                if (selectedLanguage.Equals("S"))
                    message = "Neka polja nisu popunjena. Molimo pokušajte ponovo. ";
                else
                    message = "Some fields are not filled. Please try again. ";
                MessageBox.Show(message, headMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
            else
            {
                ItemHolder selectedDoorkeeper =(ItemHolder)cBoxWorker.SelectedItem;
                ShiftSchedule newShiftSchedule = new ShiftSchedule
                {
                    Worker = (Worker)selectedDoorkeeper.value,
                    Date = selectedDate,
                    StartTime=dTPStartTime.Value.ToString("HH:mm:ss"),
                    EndTime= dTPEndTime.Value.ToString("HH:mm:ss")

                };
                ShiftScheduleDataAccess shiftScheduleDA = new ShiftScheduleDataAccess();
                shiftScheduleDA.AddShiftSchedule(newShiftSchedule);
                this.Close();
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
