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
    public partial class AddWorkerEntryForm : Form
    {
        private string selectedLanguage;
        private string selectedTheme;
        private WorkerDataAccess workerDA = new WorkerDataAccess();
        private WorkerRecordAccesData workerRecordDA = new WorkerRecordAccesData();
        public AddWorkerEntryForm(string language,string theme)
        {
            InitializeComponent();
            selectedLanguage = language;
            selectedTheme = theme;
            setLanguage();
            setTheme();
            InitializeForm();
        }

        private void InitializeForm()
        {

            List<Worker> workers = workerDA.GetWorkers();
            foreach (Worker w in workers)
            {
                ItemHolder iHolder = new ItemHolder { value = w, text = w.FirstName+" "+w.LastName+ " "+ w.WorkerCode };
                lBoxSelectWorker.Items.Add(iHolder);
            }
            lblEntryTime1.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void setTheme()
        {
            if (selectedTheme.Equals("W"))
            {

            }
            else
            {

            }
        }

        private void setLanguage()
        {
            if (selectedLanguage.Equals("S"))
            {
                lblSelectWorker.Text = "Izaberi radnika:";
                lblEntryTime.Text = "Vrijeme ulaska:";
                lblNote.Text = "Napomena:";
                btnSave.Text = "Sacuvaj";
            }
            else
            {
                lblSelectWorker.Text = "Select worker:";
                lblEntryTime.Text = "Enty time:";
                lblNote.Text = "Note:";
                btnSave.Text = "Save";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ItemHolder selectedItem = (ItemHolder)lBoxSelectWorker.SelectedItem;
            Worker worker = (Worker)selectedItem.value;
            WorkerRecord workerRecord = new WorkerRecord
            {
                Worker = worker,
                Date = DateTime.Now.ToString("yyy-MM-dd"),
                EnterTime=lblEntryTime1.Text,
                Note=tBoxNote.Text
            };
            workerRecordDA.AddEntry(workerRecord);
            this.Close();
        }
    }
}
