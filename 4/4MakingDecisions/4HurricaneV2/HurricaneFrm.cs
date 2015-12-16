using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4HurricaneV2
{
    public partial class HurricaneFrm : Form
    {
        public HurricaneFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double windSpeed = Convert.ToDouble(windSpeedTxtBx.Text);
            if (windSpeed >= 157.00)
                resultLbl.Text = "A storm with " + windSpeed + " MPH winds is a Category 5 Hurricane.";
            else if (windSpeed >= 130.00)
                resultLbl.Text = "A storm with " + windSpeed + " MPH winds is a Category 4 Hurricane.";
            else if (windSpeed >= 111.00)
                resultLbl.Text = "A storm with " + windSpeed + " MPH winds is a Category 3 Hurricane.";
            else if (windSpeed >= 96.00)
                resultLbl.Text = "A storm with " + windSpeed + " MPH winds is a Category 2 Hurricane.";
            else if (windSpeed >= 74.00)
                resultLbl.Text = "A storm with " + windSpeed + " MPH winds is a Category 1 Hurricane.";
            else
                resultLbl.Text = "A storm with " + windSpeed + " MPH winds is not a hurricane.";
        }
    }
}
