using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1CheckCredit
{
    public partial class CheckCreditForm : Form
    {
        public CheckCreditForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            const double CREDIT_LIMIT = 5000;
            double purchasePrice = Convert.ToDouble(purchasePriceTxtBx.Text);
            if (purchasePrice > CREDIT_LIMIT)
                resultLbl.Text = string.Format("The purchase price of {0:c}.\nExceeds the {1:c} credit limit.", purchasePrice, CREDIT_LIMIT);
            else if (purchasePrice >= 0.00)
                resultLbl.Text = string.Format("Approved\nThe purchase price is {0:c}.", purchasePrice);
            else
                errorLbl.Text = string.Format("Cannot have a negative purchase price");
        }
    }
}
