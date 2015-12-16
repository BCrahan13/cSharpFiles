using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8RPS
{
    public partial class RPSForm : Form
    {
        public RPSForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            const int min = 1;
            const int max = 4;
            Random randomNumGenerator = new Random();
            int randomNum = randomNumGenerator.Next(min, max);
            string play = inputTxtBx.Text;
            //string play = "&nbsp;";

            randomLbl.Text = "random = " + randomNum;
            
            switch (play)
            {
                case "R":
                    if (randomNum == 1)
                        resultLbl.Text = "Tie";
                    else if (randomNum == 2)
                        resultLbl.Text = "You lose";
                    else
                        resultLbl.Text = "You win";
                    break;
                case "P":
                    if (randomNum == 1)
                        resultLbl.Text = "You win";
                    else if (randomNum == 2)
                        resultLbl.Text = "Tie";
                    else
                        resultLbl.Text = "You lose";
                    break;
                case "S":
                    if (randomNum == 1)
                        resultLbl.Text = "You lose";
                    else if (randomNum == 2)
                        resultLbl.Text = "You win";
                    else
                        resultLbl.Text = "Tie";
                    break;
            }


        }
    }
}
