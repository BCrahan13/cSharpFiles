using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassExample
{
    class School : Building
    {
        public override void LockBuilding()
        {
            WriteLine("Make sure to lock all school doors");
        }
    }
}
