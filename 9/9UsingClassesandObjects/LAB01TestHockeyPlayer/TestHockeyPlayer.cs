using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB01TestHockeyPlayer
{
    class TestHockeyPlayer
    {
        static void Main(string[] args)
        {
            HockeyPlayer p1 = new HockeyPlayer("Joe Anderson", 24, 2);

            WriteLine("{0} is number {1} and scored {2} goal(s) last night.", p1.PlayerName, p1.JerseyNumber, p1.GoalsScored);
        }
    }
}
