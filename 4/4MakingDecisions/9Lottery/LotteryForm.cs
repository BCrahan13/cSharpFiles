using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9Lottery
{
    public partial class LotteryForm : Form
    {
        public LotteryForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            const int min = 1;
            const int max = 5;

            int guess1 = Convert.ToInt32(guess1TxtBx.Text);
            int guess2 = Convert.ToInt32(guess2TxtBx.Text);
            int guess3 = Convert.ToInt32(guess3TxtBx.Text);

            Random randomNumGenerator1 = new Random();
            int randomNum1 = randomNumGenerator1.Next(min, max);

            Random randomNumGenerator2 = new Random();
            int randomNum2 = randomNumGenerator2.Next(min, max);

            Random randomNumGenerator3 = new Random();
            int randomNum3 = randomNumGenerator3.Next(min, max);

            resultLbl.Text = "guess1=" + guess1
                           + "\nguess2=" + guess2
                           + "\nguess3=" + guess3
                           + "\nrand1=" + randomNum1
                           + "\nrand2=" + randomNum2
                           + "\nrand3=" + randomNum3;

            //switch (guess)
            //{
            //    case 1:
                    
            //        break;
            //    case 2:
                    
            //        break;
            //    case 3:
                    
            //        break;
            //    case 4:

            //        break;
            //}


        }
    }
}
