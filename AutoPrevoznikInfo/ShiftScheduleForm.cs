using AutoPrevoznikInfo.Model;
using AutoPrevoznikInfo.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoPrevoznikInfo
{
    public partial class ShiftScheduleForm : Form
    {
        private Worker loggedInWorker;
        private string selectedLanguage;
        private string selectedTheme;
        private ShiftScheduleDataAccess shiftScheduleDA = new ShiftScheduleDataAccess();
        public ShiftScheduleForm(Worker worker, string language,string theme)
        {
            InitializeComponent();
            loggedInWorker = worker;
            selectedLanguage = language;
            selectedTheme = theme;
            InitializeForm();
        }

        private void InitializeForm()
        {
            setLanguage();
            FillGridShiftSchedule();
            setTheme();
        }

        private void setLanguage()
        {
            if (selectedLanguage.Equals("S"))
            {
                lblShiftScedule.Text = "Raspored smjena:";
                dateColumn.HeaderText = "Datum";
                startTimeColumn.HeaderText = "Početak smjene";
                endTimeColumn.HeaderText = "Kraj smjene";
                
            }
            else
            {
                lblShiftScedule.Text = "Shift schedule:";
                dateColumn.HeaderText = "Date";
                startTimeColumn.HeaderText = "Start time";
                endTimeColumn.HeaderText = "End time";
            }
        }
        private void setTheme()
        {
            if (selectedTheme.Equals("W"))
            {
                this.BackColor = Color.White;
                lblShiftScedule.ForeColor = Color.Black;
                btnOk.BackColor = Color.Silver;
                btnOk.ForeColor = Color.Black;
                setDataGridColor();
            }
            else
            {
                this.BackColor = Color.FromArgb(39, 38, 40);
                lblShiftScedule.ForeColor = Color.DarkGray;
                btnOk.BackColor = Color.FromArgb(163, 128, 209);
                btnOk.ForeColor = Color.White;
                setDataGridColor();
            }
        }
        private void FillGridShiftSchedule()
        {
            List<ShiftSchedule> shifts = shiftScheduleDA.GetShiftScheduleByWorkerID(loggedInWorker.WorkerID);
            dGVShiftSchedule.Rows.Clear();
            //string exitTime;
            foreach (ShiftSchedule s in shifts)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = s
                };
                string date = s.Date.Split(" ")[0];
                
                row.CreateCells(dGVShiftSchedule, date,s.StartTime,s.EndTime);
                dGVShiftSchedule.Rows.Add(row);
            }
            
        }
        private void setDataGridColor()
        {
            if (selectedTheme.Equals("W"))
            {
                dGVShiftSchedule.BackgroundColor = Color.White;
                dGVShiftSchedule.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
                dGVShiftSchedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dGVShiftSchedule.ColumnHeadersDefaultCellStyle.SelectionBackColor = dGVShiftSchedule.ColumnHeadersDefaultCellStyle.BackColor;
                dGVShiftSchedule.ForeColor = Color.Black;
                for (int i = 0; i < dGVShiftSchedule.RowCount; i++)
                {
                    for (int j = 0; j < dGVShiftSchedule.ColumnCount; j++)
                        dGVShiftSchedule.Rows[i].Cells[j].Style.BackColor = Color.White;
                }

            }
            else
            {
                dGVShiftSchedule.BackgroundColor = Color.FromArgb(39, 38, 40);
                dGVShiftSchedule.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(39, 38, 40);
                dGVShiftSchedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(163, 128, 209);
                dGVShiftSchedule.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 38, 40);
                dGVShiftSchedule.ForeColor = Color.White;
                for (int i = 0; i < dGVShiftSchedule.RowCount; i++)
                {
                    for (int j = 0; j < dGVShiftSchedule.ColumnCount; j++)
                        dGVShiftSchedule.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(51, 51, 53);
                }
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
