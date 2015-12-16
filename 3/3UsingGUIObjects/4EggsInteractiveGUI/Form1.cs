using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4EggsInteractiveGUI
{
    public partial class EggsInteractiveForm : Form
    {
        public EggsInteractiveForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            int totalChicken = 0;
            int chicken1 = Convert.ToInt32(chicken1TxtBx.Text);
            totalChicken += chicken1;
            int chicken2 = Convert.ToInt32(chicken2TxtBx.Text);
            totalChicken += chicken2;
            int chicken3 = Convert.ToInt32(chicken3TxtBx.Text);
            totalChicken += chicken3;
            int chicken4 = Convert.ToInt32(chicken4TxtBx.Text);
            totalChicken += chicken4;
            int chicken5 = Convert.ToInt32(chicken5TxtBx.Text);
            totalChicken += chicken5;

            int cartons = totalChicken / 12;
            int remainingEggs = totalChicken - (cartons * 12);
            resultLbl.Text = "Total eggs: " + totalChicken
                           + "\nTotal cartons: " + cartons
                           + "\nEggs Remaining: " + remainingEggs;
        }
    }
}
