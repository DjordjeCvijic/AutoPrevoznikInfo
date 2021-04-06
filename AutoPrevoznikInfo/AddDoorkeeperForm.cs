using AutoPrevoznikInfo.DataAccess;
using AutoPrevoznikInfo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AutoPrevoznikInfo
{
    public partial class AddDoorkeeperForm : Form
    {
        private Worker doorkeeperToUpdate;
        private WorkerDataAccess workerDA = new WorkerDataAccess();
        public AddDoorkeeperForm(Worker doorkeeperToUpdate,string language,string theme)
        {
            InitializeComponent();
            SetLanguage(language);
            SetTheme(theme);
            this.doorkeeperToUpdate = doorkeeperToUpdate;
            InitializeForm();
        }

        private void InitializeForm()
        {
            if (doorkeeperToUpdate != null)
            {
                tBoxFirstName.Text = doorkeeperToUpdate.FirstName;
                tBoxLastName.Text = doorkeeperToUpdate.LastName;
                tBoxUsername.Text = doorkeeperToUpdate.Username;
                tBoxPhoneNumber.Text = doorkeeperToUpdate.PhoneNumber;
            }
        }

        private void SetTheme(string theme)
        {
            
        }

        private void SetLanguage(string selectedLanguage)
        {
            if (selectedLanguage.Equals("S"))
            {
                lblFirstName.Text = "Ime:";
                lblLastName.Text = "Prezime:";
                lblUsername.Text = "Korisnicko ime:";
                lblPassword.Text = "Lozinka:";
                lblPhone.Text = "Broj telefona:";
                btnSave.Text = "Sacuvaj";
            }
            else
            {

                lblFirstName.Text = "First name:";
                lblLastName.Text = "Last name:";
                lblUsername.Text = "Username:";
                lblPassword.Text = "Password:";
                lblPhone.Text = "Phone number:";
                btnSave.Text = "Save";

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tBoxFirstName.TextLength == 0 || tBoxLastName.TextLength == 0 || tBoxUsername.TextLength == 0 ||
                    tBoxPassword.TextLength == 0 || tBoxPhoneNumber.TextLength == 0)
                    throw new ArgumentException("Neka polja nisu unesena. Molimo pokušajte ponovo. ");

                string firstName = tBoxFirstName.Text;
                string lastName = tBoxLastName.Text;
                string userName = tBoxUsername.Text;
                string enteredPassword = tBoxPassword.Text;
                string phoneNumber = tBoxPhoneNumber.Text;
                if (!workerDA.CheckIfUsernameUnique(userName) && doorkeeperToUpdate == null)
                    throw new ArgumentException("Korisnicko ime zauzeto. Molimo pokušajte ponovo. ");
                

                byte[] salt1;
                new RNGCryptoServiceProvider().GetBytes(salt1 = new byte[16]);
                var pbkdf21 = new Rfc2898DeriveBytes(enteredPassword, salt1, 100000);
                byte[] hash1 = pbkdf21.GetBytes(20);
                byte[] hashBytes1 = new byte[36];
                Array.Copy(salt1, 0, hashBytes1, 0, 16);
                Array.Copy(hash1, 0, hashBytes1, 16, 20);
                string passwordToSave = Convert.ToBase64String(hashBytes1);

                if (doorkeeperToUpdate == null)
                {
                    int countOfWorkers = workerDA.CountWorkers();
                    string workerCodeToSave = "W" + (countOfWorkers + 1);
                    Worker newDoorkeeper = new Worker
                    {
                        WorkerID = countOfWorkers + 1,
                        WorkerCode = workerCodeToSave,
                        FirstName = firstName,
                        LastName = lastName,
                        Username = userName,
                        Password = passwordToSave,
                        PhoneNumber = phoneNumber,
                        WorkerType = "P"

                    };
                    workerDA.AddDoorkeeper(newDoorkeeper);
                }
                else
                {
                    doorkeeperToUpdate.FirstName = firstName;
                    doorkeeperToUpdate.LastName = lastName;
                    doorkeeperToUpdate.Username = userName;
                    if (!enteredPassword.Equals(""))
                        doorkeeperToUpdate.Password = passwordToSave;
                    doorkeeperToUpdate.PhoneNumber = phoneNumber;

                    workerDA.UpdateDoorkeeper(doorkeeperToUpdate);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
