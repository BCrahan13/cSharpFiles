using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class LottoForm : Form
    {
        public LottoForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            const int ONE_MATCH = 10;
            const int TWO_MATCH = 100;
            const int THREE_MATCH_NO_ORDER = 1000;
            const int THREE_MATCH_IN_ORDER = 10000;
            const int NO_MATCH = 0;

            Random randomNum1 = 
        }
    }
}
