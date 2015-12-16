using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _12EggsInteractive
{
    class EggsInteractive
    {
        static void Main(string[] args)
        {
            const int EGGCARTON = 12;
            int totalEggs = 0;

            WriteLine("Total eggs from chicken 1 this month: ");
            string chicken1String = ReadLine();
            int chicken1 = Convert.ToInt32(chicken1String);
            totalEggs += chicken1;

            WriteLine("Total eggs from chicken 2 this month: ");
            string chicken2String = ReadLine();
            int chicken2 = Convert.ToInt32(chicken2String);
            totalEggs += chicken2;

            WriteLine("Total eggs from chicken 3 this month: ");
            string chicken3String = ReadLine();
            int chicken3 = Convert.ToInt32(chicken3String);
            totalEggs += chicken3;

            WriteLine("Total eggs from chicken 4 this month: ");
            string chicken4String = ReadLine();
            int chicken4 = Convert.ToInt32(chicken4String);
            totalEggs += chicken4;
         
            int cartons = totalEggs / EGGCARTON;
            int eggsLeftOver = totalEggs % EGGCARTON;

            WriteLine("totalEggs = {0}"
                    + "\ncartons = {1}"
                    + "\neggsLeftOver = {2}", totalEggs, cartons, eggsLeftOver);
        }
    }
}
