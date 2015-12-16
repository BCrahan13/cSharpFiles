using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14GuessingGame2
{
    public partial class GuessingGame2Form : Form
    {
        public GuessingGame2Form()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            const int MIN = 1;
            const int MAX = 11;
            Random randomNumGenerator = new Random();
            int randomNum = randomNumGenerator.Next(MIN, MAX);



            int inputNum = Convert.ToInt32(inputTxtBx.Text);

            for (int count = 1; count < 10;)
            {
                if (inputNum == randomNum)
                {
                    resultLbl.Text = "Correct";
                    randomNumLbl.Text = string.Format("randomNum = {0}\nAttempts = {1}", randomNum, count);
                }
                else if (inputNum > randomNum)
                    resultLbl.Text = "Too high";
                else if (inputNum < randomNum)
                    resultLbl.Text = "Too low";
                ++count;
            }

            
        }
    }
}
