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

namespace HOT3_2
{
    public partial class HOT3_2Form : Form
    {
        public HOT3_2Form()
        {
            InitializeComponent();
        }

        double[] array = new double[] { 0, 8, 22, 1, 9, 43 };

        private void calcTotalBtn_Click(object sender, EventArgs e)
        {
            double total = array.Sum();
            totalLbl.Text = "total = " + total;
        }

        private void calcAvgBtn_Click(object sender, EventArgs e)
        {
            double average = array.Average();
            avgLbl.Text = "average = " + average;
        }

        private void calcHighestBtn_Click(object sender, EventArgs e)
        {
            double highest = array.Max();
            highestLbl.Text = "highest = " + highest;
        }

        private void calcLowestBtn_Click(object sender, EventArgs e)
        {
            double lowest = array.Min();
            lowestLbl.Text = "lowest = " + lowest;
        }
    }
}
