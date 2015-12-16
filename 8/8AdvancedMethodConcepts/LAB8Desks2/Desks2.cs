using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB8Desks2
{
    class Desks2
    {
        static void Main(string[] args)
        {
            int drawers = CountDrawers();

            string wood = GetWood();

            int totalPrice = 0;
            totalPrice = GetTotal(drawers, wood);

            WriteLine("The total cost for a {0} desk containing {1} drawers is {2:c}", wood, drawers, totalPrice);
        }

        private static int CountDrawers()
        {
            Write("Enter number of drawers: ");
            int drawers = Convert.ToInt32(ReadLine());
            while (drawers < 0)
            {
                Write("Error\nEnter number of drawers: ");
                drawers = Convert.ToInt32(ReadLine());
            }
            return drawers;
        }

        private static string GetWood()
        {
            Write("\n(M)ahogany\n(O)ak\n(P)ine\nEnter wood type: ");
            string wood = ReadLine().ToLower();
            return wood;
        }

        private static int GetTotal(int drawers, string wood)
        {
            int totalPrice = 0;
            if (wood == "m")
                totalPrice += 180;
            else if (wood == "o")
                totalPrice += 140;
            else if (wood == "p")
                totalPrice += 100;
            else
                totalPrice += 180;
            totalPrice += drawers * 30;
            return totalPrice;
        }

    }
}
