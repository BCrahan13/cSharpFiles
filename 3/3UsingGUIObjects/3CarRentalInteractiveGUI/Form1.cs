using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3CarRentalInteractiveGUI
{
    public partial class CarRentalForm : Form
    {
        public CarRentalForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            const double COSTPERDAY = 20.00;
            const double COSTPERMILE = 0.25;

            double days = Convert.ToDouble(daysTxtBx.Text);
            double daysPrice = days * COSTPERDAY;

            double miles = Convert.ToDouble(milesTxtBx.Text);
            double milesPrice = miles * COSTPERMILE;

            double totalPrice = daysPrice + milesPrice;

            resultLbl.Text = String.Format("For {0} days and {1} miles the total cost is {2}",days,miles,totalPrice.ToString("C"));

        }
    }
}
