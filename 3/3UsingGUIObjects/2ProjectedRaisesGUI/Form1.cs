using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2ProjectedRaisesGUI
{
    public partial class ProjectedRaisesForm : Form
    {
        public ProjectedRaisesForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            const double PERCENT = 0.04;
            double empSalary = Convert.ToDouble(empSalaryTxtBx.Text);
            double empSalaryRaise = empSalary * PERCENT;
            double empSalary2 = empSalary + empSalaryRaise;
            resultLbl.Text = "Employee's salary was: " + empSalary
                            + "\nAfter a 4 percent raise of: " + empSalaryRaise
                            + "\nThe second year's salary is: " + empSalary2;
        }
    }
}
