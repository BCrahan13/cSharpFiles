using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Admission
{
    public partial class AdmissionForm : Form
    {
        public AdmissionForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double gpa = Convert.ToDouble(gpaTxtBx.Text);
            double testScore = Convert.ToDouble(testScoreTxtBx.Text);

            if (gpa < 0.00 || gpa > 4.00)
                resultLbl.Text = "GPA must be between 0.00 and 4.00";
            else if (gpa >= 3.00 && testScore >= 60.00)
                resultLbl.Text = "Accepted";
            else if (gpa < 3.00 && testScore >= 80.00)
                resultLbl.Text = "Accepted";
            else
                resultLbl.Text = "Rejected";
        }
    }
}
