using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassExample
{
    class FastFood : Restaurant
    {
        public double  AvgDriveThroughTime { get; set; }


        public FastFood()
        {
            WriteLine("This is the child class constructor");
        }
        public FastFood(int tables, string name, double avgCost, double avgDriveThroughTime) : base(tables,name,avgCost)
        {
            AvgDriveThroughTime = avgDriveThroughTime;
        }
    }
}
