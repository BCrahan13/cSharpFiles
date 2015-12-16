using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02PhotoDemo
{
    class FramedPhoto : Photo
    {
        private string material;
        private string style;

        public FramedPhoto(double w, double h, string material, string style) : base(w, h)
        {
            price += 25;
            this.material = material;
            this.style = style;
        }
        public override string ToString()
        {
            return base.ToString() + "\nThe material is: " + material + "\nThe style is: " + style;
        }
    }
}
