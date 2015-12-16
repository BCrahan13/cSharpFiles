using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Twitter
{
    public partial class TwitterForm : Form
    {
        public TwitterForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            const int MAX_LENGTH = 140;
            int count = tweetTxtBx.TextLength;

            if (count > MAX_LENGTH)
            {
                errorLbl.Text = "Error" + count + " is too many characters";
                resultLbl.Text = " ";
            }
            else
                errorLbl.ForeColor = Color.DeepSkyBlue;
                resultLbl.Text = "The current Count " + count  + tweetTxtBx.Text;
        }
    }
}
