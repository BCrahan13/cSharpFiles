using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB8ResortPrices
{
    class ResortPrices
    {
        static void Main(string[] args)
        {
                               //numNights 1, 2    3, 4   5, 6, 7   8+
            double[] nightlyRateArray = { 200.00, 180.00, 160.00, 145.00 };

            Write("Enter number of days for a resort stay: ");
            int numDays = Convert.ToInt32(ReadLine());
            double totalPrice = 0.00;

            if (numDays <= 0)
                WriteLine("You can't stay at a place less than 0 days");
            else if (numDays == 1 || numDays == 2)
                WriteLine("Nightly price for {0} days is {1:c}"
                        + "\nTotal cost: {2:c}", numDays, nightlyRateArray[0], numDays * nightlyRateArray[0]);
            else if (numDays == 3 || numDays == 4)
                WriteLine("Nightly price for {0} days is {1:c}"
                        + "\nTotal cost: {2:c}", numDays, nightlyRateArray[1], numDays * nightlyRateArray[1]);
            else if (numDays == 5 || numDays == 6 || numDays == 7)
                WriteLine("Nightly price for {0} days is {1:c}"
                        + "\nTotal cost: {2:c}", numDays, nightlyRateArray[2], numDays * nightlyRateArray[2]);
            else
                WriteLine("Nightly price for {0} days is {1:c}"
                    + "\nTotal cost: {2:c}", numDays, nightlyRateArray[3], numDays * nightlyRateArray[3]);





            //int[] ticketPriceArray = { 25, 40, 55, 70 };

            //Write("Distance traveled: ");
            //string distanceEntered = ReadLine();

            //int Distance = Convert.ToInt32(distanceEntered);

            //if (Distance < 100 && Distance >= 0)
            //    WriteLine("Your price will be {0:c}", ticketPriceArray[0]);
            //else if (Distance >= 100 && Distance < 300)
            //    WriteLine("Your price will be {0:c}", ticketPriceArray[1]);
            //else if (Distance >= 300 && Distance < 500)
            //    WriteLine("Your price will be {0:c}", ticketPriceArray[2]);
            //else if (Distance >= 500)
            //    WriteLine("Your price will be {0:c}", ticketPriceArray[3]);
        }
    }
}
