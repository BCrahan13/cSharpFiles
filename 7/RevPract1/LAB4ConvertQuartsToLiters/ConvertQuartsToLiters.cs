using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB4ConvertQuartsToLiters
{
    class ConvertQuartsToLiters
    {
        static void Main(string[] args)
        {
            Write("Quartz: ");
            double quartz = Convert.ToDouble(ReadLine());
            QuartzToLiters(quartz);
        }
        private static void QuartzToLiters(double quartz)
        {
            //Liters in 1 Quart
            const double LITERS = 0.966353;
            double liters = quartz * LITERS;
            WriteLine("There are {0} liters in {1} quartz", liters, quartz);
        }
    }
}
