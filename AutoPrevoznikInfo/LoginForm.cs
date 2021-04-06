using AutoPrevoznikInfo.DataAccess;
using AutoPrevoznikInfo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPrevoznikInfo
{
    public partial class LoginForm : Form
    {
        private List<Worker> workers;
        private Worker loggedInWorker = null;
        //private string ConfigFileName = "ConfigFile.txt";
        private string selectedLanguage = "S";
        public LoginForm()
        {
            InitializeComponent();
            InitializeWorm();


        }

        private void InitializeWorm()
        {
            WorkerDataAccess workerDA = new WorkerDataAccess();
            workers = workerDA.GetWorkers();
            /*if (!File.Exists(ConfigFileName)) {
                File.Create(ConfigFileName);
                File.WriteAllText(ConfigFileName, "Language;S" + "\n" + "Theme;W");               
            }*/
               
        }

        private void OnLanguageChanged(object sender, EventArgs e)
        {
            string language = (sender as RadioButton).Tag.ToString();
            if (language.Equals("S"))
            {
                selectedLanguage = "S";
                rBtnSerbian.Text = "Srpski";
                rBtnEnglish.Text = "Engleski";
                lblDobroDosli.Text = "Dobro dosli";
                gBoxLanguage.Text = "Izaberite jezik";
                lblUsername.Text = "Korisnicko ime";
                lblPassword.Text = "Lozinka";
                btnLogin.Text = "Prijava";
            }
            else
            {
                selectedLanguage = "E";
                rBtnSerbian.Text = "Serbian";
                rBtnEnglish.Text = "English";
                lblDobroDosli.Text = "Welcome";
                gBoxLanguage.Text = "Select a language";
                lblUsername.Text = "Username";
                lblPassword.Text = "Password";
                btnLogin.Text = "Login";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //za pravljenje lozinke
            /*string password1 = tBoxPassword.Text;
            byte[] salt1;
            new RNGCryptoServiceProvider().GetBytes(salt1 = new byte[16]);
            var pbkdf21 = new Rfc2898DeriveBytes(password1, salt1, 100000);
            byte[] hash1 = pbkdf21.GetBytes(20);
            byte[] hashBytes1 = new byte[36];
            Array.Copy(salt1, 0, hashBytes1, 0, 16);
            Array.Copy(hash1, 0, hashBytes1, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes1);
            Console.WriteLine("");*/


            string username = tBoxUsername.Text;
            string password = tBoxPassword.Text;
            bool check = false;
            foreach (Worker worker in workers)
            {
                if (worker.Username.Equals(username))
                {
                    check = true;
                    try
                    {
                        byte[] hashBytes = Convert.FromBase64String(worker.Password);
                        byte[] salt = new byte[16];
                        Array.Copy(hashBytes, 0, salt, 0, 16);
                        var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
                        byte[] hash = pbkdf2.GetBytes(20);
                        for (int i = 0; i < 20; i++)
                            if (hashBytes[i + 16] != hash[i])
                                throw new UnauthorizedAccessException("Pogresna lozinka");

                        loggedInWorker = worker;
                        Form m = null;
                        if ("S".Equals(worker.WorkerType))//sef saobracaja
                        {
                            m = new TrafficMenagerForm(loggedInWorker,selectedLanguage);
                        }
                        else if ("O".Equals(worker.WorkerType))//sef obezbjedjenja
                        {
                           m = new DoorkeeperMenagerForm(loggedInWorker, selectedLanguage);
                        }
                        else if("V".Equals(worker.WorkerType))// vozac
                        {
                            m = new DriverForm(loggedInWorker, selectedLanguage);
                        }
                        else if ("P".Equals(worker.WorkerType))//portir
                        {
                            m = new DoorkeeperForm(loggedInWorker, selectedLanguage);
                        }
                        //this.Hide();
                        m.ShowDialog();
                        tBoxUsername.Clear();
                        tBoxPassword.Clear();
                        //this.Close();
                        /*tbUserName.Clear();
                        tbPassword.Clear();
                        tbUserName.Text = "Korisničko Ime";
                        tbUserName.ForeColor = SystemColors.WindowFrame;
                        tbPassword.UseSystemPasswordChar = false;
                        tbPassword.Text = "Lozinka";
                        tbPassword.ForeColor = SystemColors.WindowFrame;
                        btnLogin.Focus();*/
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        //new WarningMessageForm("Pogrešna lozinka", "Unešena lozinka je pogrešna. Molimo pokušajte ponovo.").ShowDialog();
                        MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (!check)
            {
                //new WarningMessageForm("Nepostojeće korisničko ime", "Uneseno korisničko ime ne postoji. Molimo pokušajte ponovo.").ShowDialog();
                MessageBox.Show("nepostojece korisnicko ime", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
