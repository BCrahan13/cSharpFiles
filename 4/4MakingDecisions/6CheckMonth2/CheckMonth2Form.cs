using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6CheckMonth2
{
    public partial class CheckMonth2Form : Form
    {
        public CheckMonth2Form()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt32(monthTxtBx.Text);
            int day = Convert.ToInt32(dayTxtBx.Text);

            if ( (month > 12 || month < 1) || (day > 31 || day < 1) )
                resultLbl.Text = "Error";
            else 
                switch (month)
                {
                    case 2:
                        if (day > 29)
                            resultLbl.Text = "Error";
                        else
                            resultLbl.Text = + month + "/" + day;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (day > 30)
                            resultLbl.Text = "Error";
                        else
                            resultLbl.Text = + month + "/" + day;
                        break;
                    default:
                        resultLbl.Text = + month + "/" + day;
                        break;
                }
        }
    }
}
