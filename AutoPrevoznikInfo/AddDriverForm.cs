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
        public AddDriverForm(Driver driver,string language,string theme)
        {
            InitializeComponent();
            SetLanguage(language);
            SetTheme(theme);
            driverToUpdate = driver;
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
                lblUsername.Text = "Korisnicko ime:";
                lblPassword.Text = "Lozinka:";
                lblPhone.Text = "Broj telefona:";
                lblTakeBus.Text = "Zaduzi autobuse:";
                btnSave.Text = "Sacuvaj";
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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(tBoxFirstName.TextLength==0 || tBoxLastName.TextLength == 0 || tBoxUsername.TextLength == 0 ||
                    tBoxPassword.TextLength == 0 || tBoxPhoneNumber.TextLength == 0  )
                    throw new ArgumentException("Neka polja nisu unesena. Molimo pokušajte ponovo. ");

                string firstName = tBoxFirstName.Text;
                string lastName = tBoxLastName.Text;
                string userName = tBoxUsername.Text;
                string enteredPassword = tBoxPassword.Text;
                string phoneNumber = tBoxPhoneNumber.Text;
                if(workerDA.CheckIfUsernameUnique(userName) && !userName.Equals(driverToUpdate.Username))
                    throw new ArgumentException("Korisnicko ime zauzeto. Molimo pokušajte ponovo. ");
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
                    int countOfWorkers = workerDA.CountWorkers();
                    string workerCodeToSave = "W" + (countOfWorkers + 1);
                    Driver newDriver = new Driver
                    {
                        WorkerID = countOfWorkers + 1,
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

                    workerDA.updateDriver(driverToUpdate);
                }
                
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
