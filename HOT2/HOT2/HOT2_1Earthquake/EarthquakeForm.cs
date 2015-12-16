using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOT2_1Earthquake
{
    public partial class EarthquakeForm : Form
    {
        public EarthquakeForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double magnitude = Convert.ToDouble(magnitudeTxtBx.Text);

            if (magnitude < 2.0)
                resultLbl.Text = "Micro";
            else if (magnitude < 4.0)
                resultLbl.Text = "Minor";
            else if (magnitude < 5.0)
                resultLbl.Text = "Light";
            else if (magnitude < 6.0)
                resultLbl.Text = "Moderate";
            else if (magnitude < 7.0)
                resultLbl.Text = "Strong";
            else if (magnitude < 8.0)
                resultLbl.Text = "Major";
            else
                resultLbl.Text = "Great";
        }
    }
}
