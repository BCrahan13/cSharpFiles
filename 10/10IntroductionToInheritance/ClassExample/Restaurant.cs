using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassExample
{
    public class Restaurant : Building
    {
        public int NumTables { get; set; }
        public string Name { get; set; }
        public double AvgCost { get; set; }


        public Restaurant()
        {
            WriteLine("This is the parent class constructor");
        }
        public Restaurant(int numTables, string name, double avgCost)
        {
            NumTables = numTables;
            Name = name;
            AvgCost = avgCost;
        }

        public override void LockBuilding()
        {
            WriteLine("Remember to lock all restaurant doors");
        }
    }
}
