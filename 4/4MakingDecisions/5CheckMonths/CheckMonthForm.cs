using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5CheckMonths
{
    public partial class CheckMonthForm : Form
    {
        public CheckMonthForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            int birthMonth = Convert.ToInt32(birthMonthTxtBx.Text);
            if (birthMonth > 12 || birthMonth < 1)
                resultLbl.Text = "Error";
            else
                resultLbl.Text = +birthMonth + " is a valid month.";
        }
    }
}
