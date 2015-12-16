using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SumInts
{
    public partial class SumIntsForm : Form
    {
        public SumIntsForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int count = 0;
            int endNum = 0;
            while (endNum != 1)
            {
                count = Convert.ToInt32(inputTxtBx.Text);
                sum += count;
                if (count == 999)
                {
                    endNum = 1;
                    sum = sum += count;
                }
            }
            
            resultLbl.Text = "sum = " + sum;
                

        }
    }
}
