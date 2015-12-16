using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5TestsInteractiveGUI
{
    public partial class TestsInteractiveForm : Form
    {
        public TestsInteractiveForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            const double NUMTESTS = 5.0;
            double testSum = 0.0;
            double test1 = Convert.ToDouble(test1TxtBx.Text);
            testSum += test1;
            double test2 = Convert.ToDouble(test2TxtBx.Text);
            testSum += test2;
            double test3 = Convert.ToDouble(test3TxtBx.Text);
            testSum += test3;
            double test4 = Convert.ToDouble(test4TxtBx.Text);
            testSum += test4;
            double test5 = Convert.ToDouble(test5TxtBx.Text);
            testSum += test5;
            double testAverage = testSum / NUMTESTS;
            resultLbl.Text = "Average Test Scores: " + testAverage + "%";
        }
    }
}
