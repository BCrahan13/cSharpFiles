using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7MonthNamesGUI
{
    public partial class MonthNamesForm : Form
    {

        enum Month
        {
            JANUARY = 1, FEBRURARY, MARCH, APRIL, MAY, JUNE, JULY, AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER
        }

        public MonthNamesForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            int monthNum = Convert.ToInt32(monthNumTxtBx.Text);
            Month month = (Month)monthNum;
            resultLbl.Text = "You were born in: " + month;
        }
    }
}
