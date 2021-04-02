using AutoPrevoznikInfo.DataAccess;
using AutoPrevoznikInfo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPrevoznikInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BusDataAccess busDA = new BusDataAccess();
            List<Bus> buses = busDA.GetBuses();

            Console.Write("");


        }

    }
}
