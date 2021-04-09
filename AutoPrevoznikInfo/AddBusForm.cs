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
    public partial class AddBusForm : Form
    {
        private Bus busToUpdate;
        private BusDataAccess busDA = new BusDataAccess();
        private string selectedTheme;
        public AddBusForm(Bus bus, string language, string theme)
        {
            InitializeComponent();
            SetLanguage(language);
            SetTheme(theme);
            busToUpdate = bus;
            selectedTheme = theme;
            InitializeForm(language);
        }

        private void InitializeForm(string language)
        {
            string type1 = null;
            string type2 = null;
            if (language.Equals("S"))
            {
                type1 = "Gradski";
                type2 = "Prigradsi";
            }else
            {
                type1 = "Urban";
                type2 = "Suburban";
            }
            cBoxSelectBusType.Items.Add(new ItemHolder { value = "G", text = type1 });
            cBoxSelectBusType.Items.Add(new ItemHolder { value = "P", text = type2 });


            if (busToUpdate != null)
            {
                tBoxNumOfSeats.Text = busToUpdate.NumberOfSeats.ToString();
                tBoxNumOfDoors.Text = busToUpdate.NumberOfDoors.ToString();
                tBoxCapacity.Text = busToUpdate.Capacity.ToString();
                foreach(ItemHolder itemH in cBoxSelectBusType.Items)
                {
                    if (((string)itemH.value).Equals(busToUpdate.BusType))
                    {
                        cBoxSelectBusType.SelectedItem = itemH;
                    }
                }

            }
        }

        private void SetLanguage(string language)
        {
            if (language.Equals("S"))
            {
                this.BackColor = Color.White;
                lblSelectType.Text = "Tip vozila";
                lblNumOfSeats.Text = "Broj sjedista";
                lblNumOfDoors.Text = "Broj vrata";
                lblSelectType.Text = "Kapacitet autobusa";
                btnSave.Text = "Sacuvaj";
            }
            else
            {
                lblSelectType.Text = "Type of bus";
                lblNumOfSeats.Text = "Number od seats";
                lblNumOfDoors.Text = "Number of doors";
                lblSelectType.Text = "Bus capacity";
                btnSave.Text = "Save";
            }
        }

        private void SetTheme(string theme)
        {
            if (theme.Equals("W"))
            {
                this.BackColor = Color.White;
                lblSelectType.ForeColor = Color.Black;
                lblCapacity.ForeColor = Color.Black;
                lblNumOfDoors.ForeColor = Color.Black;
                lblNumOfSeats.ForeColor = Color.Black;
                tBoxCapacity.BackColor = Color.White;
                tBoxCapacity.ForeColor = Color.Black;
                tBoxNumOfDoors.BackColor = Color.White;
                tBoxNumOfDoors.ForeColor = Color.Black;
                tBoxNumOfSeats.BackColor = Color.White;
                tBoxNumOfSeats.ForeColor = Color.Black;
                btnSave.BackColor = Color.Silver;
                btnSave.ForeColor = Color.Black;


                cBoxSelectBusType.BackColor = Color.White;
                cBoxSelectBusType.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.FromArgb(39, 38, 40);
                lblSelectType.ForeColor = Color.DarkGray;
                lblCapacity.ForeColor = Color.DarkGray;
                lblNumOfDoors.ForeColor = Color.DarkGray;
                lblNumOfSeats.ForeColor = Color.DarkGray;
                tBoxCapacity.BackColor = Color.FromArgb(71, 70, 72);
                tBoxCapacity.ForeColor = Color.White;
                tBoxNumOfDoors.BackColor = Color.FromArgb(71, 70, 72);
                tBoxNumOfDoors.ForeColor = Color.White;
                tBoxNumOfSeats.BackColor = Color.FromArgb(71, 70, 72);
                tBoxNumOfSeats.ForeColor = Color.White;
                btnSave.BackColor = Color.FromArgb(163, 128, 209);
                btnSave.ForeColor = Color.White;

                cBoxSelectBusType.BackColor = Color.FromArgb(71, 70, 72);
                cBoxSelectBusType.ForeColor = Color.White;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cBoxSelectBusType.SelectedIndex == -1 || tBoxNumOfSeats.TextLength == 0 || tBoxNumOfDoors.TextLength == 0 ||
                    tBoxCapacity.TextLength == 0 )
                    throw new ArgumentException("Neka polja nisu unesena. Molimo pokušajte ponovo. ");

                int numOfSeats = int.Parse(tBoxNumOfSeats.Text);
                int numOfDoors = int.Parse(tBoxNumOfDoors.Text);
                int capacity = int.Parse(tBoxCapacity.Text);
                string selectedType = ((ItemHolder)cBoxSelectBusType.SelectedItem).value.ToString();
                
                if (busToUpdate == null)//dodavanje novog
                {

                    int lastBusID = busDA.GetLastID();
                    string garegeCodeToSave = "G" + (lastBusID + 1);
                    Bus newBus = new Bus
                    {
                        GarageNumber=garegeCodeToSave,
                        BusType = selectedType,
                        NumberOfSeats = numOfSeats,
                        NumberOfDoors = numOfDoors,
                        Capacity=capacity
                    };
                    busDA.AddBus(newBus);


                }
                else
                {

                    busToUpdate.BusType = selectedType;
                    busToUpdate.NumberOfSeats = numOfSeats;
                    busToUpdate.NumberOfDoors = numOfDoors;
                    busToUpdate.Capacity = capacity;

                    busDA.UpdateBus(busToUpdate);

                }
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cBoxSelectBusType_DrawItem(object sender, DrawItemEventArgs e)
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
