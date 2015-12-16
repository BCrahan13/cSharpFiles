using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOT2_GPA
{
    public partial class GPAForm : Form
    {
        public GPAForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double gpa = Convert.ToDouble(gpaTxtBx.Text);

            if (gpa < 0.00 || gpa > 4.00)
                resultLbl.Text = "Entry must be between 0.00 and 4.00";
            else if (gpa <= 0.00)
                resultLbl.Text = "F";
            else if (gpa <= 1.00)
                resultLbl.Text = "D";
            else if (gpa <= 2.00)
                resultLbl.Text = "C";
            else if (gpa <= 3.00)
                resultLbl.Text = "B";
            else
                resultLbl.Text = "A";
        }
    }
}
