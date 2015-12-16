using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace LAB06ExceptionHandlingDemoGUI
{
    public partial class ExceptionHandlingForm : Form
    {
        public ExceptionHandlingForm()
        {
            InitializeComponent();
        }

        private void calcResultBtn_Click(object sender, EventArgs e)
        {
            int userInput = 0;
            try
            {
                userInput = Convert.ToInt32(userInputTxtBx.Text);
                resultLbl.Text = "Entered val = " + userInput;
            }
            catch (Exception)
            {
                resultLbl.Text = "Input must be an integer";
            }
            userInputTxtBx.Clear();
        }

        private void userInputTxtBx_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
