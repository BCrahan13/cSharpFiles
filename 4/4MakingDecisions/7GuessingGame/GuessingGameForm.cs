using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7GuessingGame
{
    public partial class GuessingGameForm : Form
    {
        public GuessingGameForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            const int min = 1;
            const int max = 11;
            Random randomNumGenerator = new Random();
            int randomNum = randomNumGenerator.Next(min, max);

            int inputNum = Convert.ToInt32(inputTxtBx.Text);

            if (inputNum == randomNum)
                resultLbl.Text = "Correct";
            else if (inputNum > randomNum)
                resultLbl.Text = "Too high";
            else
                resultLbl.Text = "Too low";

            randomNumLbl.Text = "Random number: " + randomNum;

        }
    }
}
