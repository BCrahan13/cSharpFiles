using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOT2_Lawn
{
    public partial class LawnForm : Form
    {
        public LawnForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            const double WEEKS = 20.00;
            double totalCost = 0.00;
            double cost = 0.00;
            double paymentCost = 0.00;
            double length = Convert.ToDouble(lengthTxtBx.Text);
            double width = Convert.ToDouble(widthTxtBx.Text);
            double payments = Convert.ToDouble(paymentsTxtBx.Text);

            double size = length * width;

            if (length < 0.00 || width < 0.00)
                resultLbl.Text = "length and width must be a positive number";

            if (size < 400)
            {
                cost = 25.00;
            }
            else if (size < 600)
                cost = 35.00;
            else
                cost = 50.00;

            totalCost = cost * WEEKS;

            if (payments == 1.00)
                paymentCost = totalCost;
            else if (payments == 2.00)
            {
                paymentCost = (totalCost / 2.00) + 5.00;
                totalCost += 10.00;
            }
            else if (payments == 20.00)
            {
                paymentCost = (totalCost / payments) + 3.00;
                totalCost += (payments * 3.00);
            }  



            resultLbl.Text = string.Format("Lawn Size: {0}\nWeekly Cost: {1:c}\nPayments: {2}\n\nCost per payment: {3:c}\nTotal Cost: {4:c}", size, cost, payments, paymentCost, totalCost);
            

            

            

        }
    }
}
