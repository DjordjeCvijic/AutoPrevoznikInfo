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
    public partial class AddDriverForm : Form
    {
        private Driver driverToUpdate;
        private WorkerDataAccess workerDA = new WorkerDataAccess();
        private string selectedLanguage;
        public AddDriverForm(Driver driver,string language,string theme)
        {
            InitializeComponent();
            SetLanguage(language);
            SetTheme(theme);
            driverToUpdate = driver;
            selectedLanguage = language;
            InitializeForm();
        }

        private void InitializeForm()
        {
            BusDataAccess busDA = new BusDataAccess();
            List<Bus> buses = busDA.GetBuses();
            foreach(Bus b in buses)
            {
                ItemHolder iHolder = new ItemHolder { value = b, text = b.GarageNumber+ " "+b.BusType };
                lBoxTakeBus.Items.Add(iHolder);
                if (driverToUpdate != null)
                {
                    List<Bus> alreadySelected = driverToUpdate.Buses;
                    foreach (Bus alreadySelectedBus in alreadySelected)
                    {
                        if (b.BusId == alreadySelectedBus.BusId)
                        {
                            lBoxTakeBus.SetSelected(lBoxTakeBus.Items.IndexOf(iHolder), true);
                        }
                    }
                }
            }
            if (driverToUpdate != null)
            {
                tBoxFirstName.Text = driverToUpdate.FirstName;
                tBoxLastName.Text = driverToUpdate.LastName;
                tBoxUsername.Text = driverToUpdate.Username;
                tBoxPhoneNumber.Text = driverToUpdate.PhoneNumber;
            }
        }

        private void SetLanguage(string selectedLanguage)
        {
            if (selectedLanguage.Equals("S"))
            {
                lblFirstName.Text = "Ime:";
                lblLastName.Text = "Prezime:";
                lblUsername.Text = "Korisničko ime:";
                lblPassword.Text = "Lozinka:";
                lblPhone.Text = "Broj telefona:";
                lblTakeBus.Text = "Zaduži autobuse:";
                btnSave.Text = "Sačuvaj";
            }
            else
            {

                lblFirstName.Text = "First name:";
                lblLastName.Text = "Last name:";
                lblUsername.Text = "Username:";
                lblPassword.Text = "Password:";
                lblPhone.Text = "Phone number:";
                lblTakeBus.Text = "Take buses:";
                btnSave.Text = "Save";

            }
        }
        private void SetTheme(string selectedTheme)
        {
            if (selectedTheme.Equals("W"))
            {
                this.BackColor = Control.DefaultBackColor;
                lblFirstName.ForeColor = Color.Black;
                lblLastName.ForeColor = Color.Black;
                lblUsername.ForeColor = Color.Black;
                lblPassword.ForeColor = Color.Black;
                lblPhone.ForeColor = Color.Black;
                lblTakeBus.ForeColor = Color.Black;

                btnSave.BackColor = Color.Silver;
                btnSave.ForeColor = Color.Black;

                
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

                lBoxTakeBus.BackColor = Color.White;
                lBoxTakeBus.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.FromArgb(39, 38, 40);//tamnija crna
                lblFirstName.ForeColor = Color.DarkGray;
                lblLastName.ForeColor = Color.DarkGray;
                lblUsername.ForeColor = Color.DarkGray;
                lblPassword.ForeColor = Color.DarkGray;
                lblPhone.ForeColor = Color.DarkGray;
                lblTakeBus.ForeColor = Color.DarkGray;

                btnSave.BackColor = Color.FromArgb(163, 128, 209); //ljubicasta
                btnSave.ForeColor = Color.White;

                tBoxFirstName.BackColor = Color.FromArgb(71, 70, 72);//najsvijetlija siva
                tBoxFirstName.ForeColor = Color.White;
                tBoxLastName.BackColor = Color.FromArgb(71, 70, 72);
                tBoxLastName.ForeColor = Color.White;
                tBoxUsername.BackColor = Color.FromArgb(71, 70, 72);
                tBoxUsername.ForeColor = Color.White;
                tBoxPassword.BackColor = Color.FromArgb(71, 70, 72);
                tBoxPassword.ForeColor = Color.White;
                tBoxPhoneNumber.BackColor = Color.FromArgb(71, 70, 72);
                tBoxPhoneNumber.ForeColor = Color.White;

                lBoxTakeBus.BackColor = Color.FromArgb(71, 70, 72);
                lBoxTakeBus.ForeColor = Color.White;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(tBoxFirstName.TextLength==0 || tBoxLastName.TextLength == 0 || tBoxUsername.TextLength == 0 ||
                    tBoxPassword.TextLength == 0 || tBoxPhoneNumber.TextLength == 0  )
                {
                    string message = null;
                    if (selectedLanguage.Equals("S"))
                        message = "Neka polja nisu popunjena. Molimo pokušajte ponovo. ";
                    else
                        message = "Some fields are not filled. Please try again. ";
                    throw new ArgumentException(message);
                }

                string firstName = tBoxFirstName.Text;
                string lastName = tBoxLastName.Text;
                string userName = tBoxUsername.Text;
                string enteredPassword = tBoxPassword.Text;
                string phoneNumber = tBoxPhoneNumber.Text;
                if (!workerDA.CheckIfUsernameUnique(userName) && driverToUpdate == null)
                {
                    string message = null;
                    if (selectedLanguage.Equals("S"))
                        message = "Korisnicko ime zauzeto. Molimo pokušajte ponovo. ";
                    else
                        message = "Another user already has this username. Please try again. ";
                    throw new ArgumentException(message);
                }
                List<Bus> buses = new List<Bus>();
                foreach (ItemHolder selectedItem in lBoxTakeBus.SelectedItems)
                {
                    buses.Add((Bus)selectedItem.value);
                }

                byte[] salt1;
                new RNGCryptoServiceProvider().GetBytes(salt1 = new byte[16]);
                var pbkdf21 = new Rfc2898DeriveBytes(enteredPassword, salt1, 100000);
                byte[] hash1 = pbkdf21.GetBytes(20);
                byte[] hashBytes1 = new byte[36];
                Array.Copy(salt1, 0, hashBytes1, 0, 16);
                Array.Copy(hash1, 0, hashBytes1, 16, 20);
                string passwordToSave = Convert.ToBase64String(hashBytes1);

                
                
                if (driverToUpdate == null)
                {
                    int lastID = workerDA.GetLastID();
                    string workerCodeToSave = "W" + (lastID + 1);
                    Driver newDriver = new Driver
                    {
                       
                        WorkerCode = workerCodeToSave,
                        FirstName = firstName,
                        LastName = lastName,
                        Username = userName,
                        Password = passwordToSave,
                        PhoneNumber = phoneNumber,
                        WorkerType = "V",
                        Buses = buses

                    };
                    workerDA.AddDriver(newDriver);
                }
                else
                {
                    driverToUpdate.FirstName = firstName;
                    driverToUpdate.LastName = lastName;
                    driverToUpdate.Username = userName;
                    if (!enteredPassword.Equals(""))
                        driverToUpdate.Password = passwordToSave;
                    driverToUpdate.PhoneNumber = phoneNumber;
                    driverToUpdate.Buses = buses;

                    workerDA.UpdateDriver(driverToUpdate);
                }
                
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
    }
}
