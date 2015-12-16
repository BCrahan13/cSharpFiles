using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1SumFourInt
{
    public partial class SumFourIntForm : Form
    {
        public SumFourIntForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            int int1 = Convert.ToInt32(int1TxtBx.Text);
            int int2 = Convert.ToInt32(int2TxtBx.Text);
            int int3 = Convert.ToInt32(int3TxtBx.Text);
            int int4 = Convert.ToInt32(int4TxtBx.Text);
            int sum = int1 + int2 + int3 + int4;
            resultLbl.Text = "Sum= " + sum;
        }
    }
}
