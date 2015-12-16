using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02PhotoDemo
{
    class MattedPhoto : Photo
    {
        private string color;

        public MattedPhoto(double w, double h, string color) : base(w, h)
        {
            price += 10;
            this.color = color;
        }
        public override string ToString()
        {
            return base.ToString() + "\nThe color is: " + color;
        }
    }
}
