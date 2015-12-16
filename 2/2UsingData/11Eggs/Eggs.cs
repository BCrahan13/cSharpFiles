using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _11Eggs
{
    class Eggs
    {
        static void Main(string[] args)
        {
            const int EGGCARTON = 12;

            const int CHICKEN1 = 12;
            const int CHICKEN2 = 24;
            const int CHICKEN3 = 36;
            const int CHICKEN4 = 50;

            int totalEggs = CHICKEN1 + CHICKEN2 + CHICKEN3 + CHICKEN4;

            int cartons = totalEggs / EGGCARTON;
            int eggsLeftOver = totalEggs % EGGCARTON;

            WriteLine("totalEggs = {0}"
                    + "\ncartons = {1}"
                    + "\neggsLeftOver = {2}", totalEggs, cartons, eggsLeftOver);
        }
    }
}
