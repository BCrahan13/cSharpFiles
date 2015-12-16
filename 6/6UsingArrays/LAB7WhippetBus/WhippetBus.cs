using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB7WhippetBus
{
    class WhippetBus
    {
        static void Main(string[] args)
        {
            int[] ticketPriceArray = { 25, 40, 55, 70 };

            Write("Distance traveled: ");
            string distanceEntered = ReadLine();

            int Distance = Convert.ToInt32(distanceEntered);

            if (Distance < 100 && Distance >= 0)
                WriteLine("Your price will be {0:c}", ticketPriceArray[0]);
            else if (Distance >= 100 && Distance < 300)
                WriteLine("Your price will be {0:c}", ticketPriceArray[1]);
            else if (Distance >= 300 && Distance < 500)
                WriteLine("Your price will be {0:c}", ticketPriceArray[2]);
            else if (Distance >= 500)
                WriteLine("Your price will be {0:c}", ticketPriceArray[3]);
        }
    }
}
