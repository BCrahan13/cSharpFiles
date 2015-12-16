using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6PayrollGUI
{
    public partial class PayrollForm : Form
    {
        public PayrollForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            const double FEDTAX = 0.15;
            const double STATETAX = 0.05;

            string name = nameTxtBx.Text;
            string ssn = ssnTxtBx.Text;
            double payRate = Convert.ToDouble(payRateTxtBx.Text);
            double hoursWorked = Convert.ToDouble(hoursWorkedTxtBx.Text);

            double grossPay = payRate * hoursWorked;
            double fedTax = grossPay * FEDTAX;
            double stateTax = grossPay * STATETAX;
            double netPay = grossPay - (fedTax + stateTax);

            resultLbl.Text = "Name: " + name
                           + "\nSSN: " + ssn
                           + "\nGross Pay: $" + grossPay
                           + "\nFed Tax: $" + fedTax
                           + "\nState Tax: $" + stateTax
                           + "\nNet Pay: $" + netPay; 
        }
    }
}
