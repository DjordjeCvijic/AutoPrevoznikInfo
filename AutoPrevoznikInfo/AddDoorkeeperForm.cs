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
            if (theme.Equals("W"))
            {
                this.BackColor = Color.White;
                lblFirstName.ForeColor = Color.Black;
                lblLastName.ForeColor = Color.Black;
                lblUsername.ForeColor = Color.Black;
                lblPassword.ForeColor = Color.Black;
                lblPhone.ForeColor = Color.Black;
                tBoxFirstName.BackColor = Color.White;
                tBoxFirstName.ForeColor = Color.Black;
                tBoxLastName.BackColor = Color.White;
                tBoxLastName.ForeColor = Color.Black;
                tBoxUsername.BackColor = Color.White;
                tBoxUsername.ForeColor = Color.Black;
                tBoxPassword.BackColor = Color.White;
                tBoxPassword.ForeColor = Color.Black;
                tBoxPhoneNumber.BackColor = Color.White;
                tBoxPhoneNumber.ForeColor = Color.Black;
                btnSave.BackColor = Color.Silver;
                btnSave.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.FromArgb(39, 38, 40);
                lblFirstName.ForeColor = Color.DarkGray;
                lblLastName.ForeColor = Color.DarkGray;
                lblUsername.ForeColor = Color.DarkGray;
                lblPassword.ForeColor = Color.DarkGray;
                lblPhone.ForeColor = Color.DarkGray;
                tBoxFirstName.BackColor = Color.FromArgb(71, 70, 72);
                tBoxFirstName.ForeColor = Color.White;
                tBoxLastName.BackColor = Color.FromArgb(71, 70, 72);
                tBoxLastName.ForeColor = Color.White;
                tBoxUsername.BackColor = Color.FromArgb(71, 70, 72);
                tBoxUsername.ForeColor = Color.White;
                tBoxPassword.BackColor = Color.FromArgb(71, 70, 72);
                tBoxPassword.ForeColor = Color.White;
                tBoxPhoneNumber.BackColor = Color.FromArgb(71, 70, 72);
                tBoxPhoneNumber.ForeColor = Color.White;
                btnSave.BackColor = Color.FromArgb(163, 128, 209);
                btnSave.ForeColor = Color.White;
            }
            
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
                    int lastID = workerDA.GetLastID();
                    string workerCodeToSave = "W" + (lastID + 1);
                    Worker newDoorkeeper = new Worker
                    {
                       
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

                    workerDA.UpdateWorker(doorkeeperToUpdate);
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
