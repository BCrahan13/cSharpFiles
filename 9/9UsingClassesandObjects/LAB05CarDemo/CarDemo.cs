using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB05CarDemo
{
    class CarDemo
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Fusion", 28);
            Car car2 = new Car("Altima");

            WriteLine("Model: {0} Mpg: {1}", car1.Model, car1.Mpg);
            WriteLine("Model: {0} Mpg: {1}", car2.Model, car2.Mpg);

            ++car1;
            ++car2;

            WriteLine("\nAfter ++ operator");
            WriteLine("Model: {0} Mpg: {1}", car1.Model, car1.Mpg);
            WriteLine("Model: {0} Mpg: {1}", car2.Model, car2.Mpg);
        }
    }
}
