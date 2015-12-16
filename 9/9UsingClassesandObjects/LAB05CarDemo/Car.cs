using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05CarDemo
{
    class Car
    {
        //Auto-implemented fields
        public string Model { get; set; }
        public int Mpg { get; set; }

        public Car()
        {
            Model = "";
            Mpg = 0;
        }
        public Car(string Model, int Mpg)
        {
            this.Model = Model;
            this.Mpg = Mpg;
        }
        public Car(string Model)
        {
            this.Model = Model;
            Mpg = 20;
        }

        public static Car operator ++ (Car car)
        {
            ++car.Mpg;
            return car;
        }
    }
}
