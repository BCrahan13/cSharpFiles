using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1MilesToKiloGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            const double CONVERSION = 1.6;
            double miles = Convert.ToDouble(milesTxtBx.Text);
            double kilometers = miles * CONVERSION;
            resultLbl.Text = "Kilometers: " + kilometers;
        }
    }
}
