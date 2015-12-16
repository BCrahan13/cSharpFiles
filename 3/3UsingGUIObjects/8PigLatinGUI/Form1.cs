using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8PigLatinGUI
{
    public partial class PigLatinForm : Form
    {
        public PigLatinForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            string input = inputTxtBx.Text;
            string firstLetter = input.Substring(0, 1);
            string restWord = input.Substring(1);
            resultLbl.Text = "PigLatin conversion: " + restWord + firstLetter + "ay";
        }
    }
}
