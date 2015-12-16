using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02PhotoDemo
{
    class Photo
    {
        //in inches
        public double Width { get; set; }
        public double Height { get; set; }
        protected double price;
        public const double FRAME_COST = 9.99;
        public double Price
        {
            get
            {
                return price;
            }
        }
        public Photo()
        {
            Width = 0.00;
            Height = 0.00;
        }
        public Photo(double w, double h)
        {
            Width = w;
            Height = h;
            if (w == 8.00 && h == 10.00)
                price = 3.99;
            else if (w == 10.00 && h == 12.00)
                price = 5.99;
            else
                price = FRAME_COST;
        }
        public override string ToString()
        {
            return (GetType() + "\nThe Width is: " + Width + "\nThe Height is: " + Height + "\nThe Price is: " + Price);
        }

    }
}
