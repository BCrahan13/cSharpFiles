using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB4Auction
{
    class Auction
    {
        static void Main(string[] args)
        {
            int bidInt;
            double bidDouble;

            //String
            Write("Enter a bid amount: ");
            string bidString = ReadLine();

            //Numeric
            double.TryParse(bidString, out bidDouble);
            int.TryParse(bidString, out bidInt);
            if (double.TryParse(bidString, out bidDouble))
                GetBid(bidDouble);
            else if (int.TryParse(bidString, out bidInt))
                GetBid(bidInt);
            else
                GetBid(bidString);
        }

        private static void GetBid(double bidDouble)
        {
            WriteLine("bidDouble = " + bidDouble);
        }

        private static void GetBid(int bidInt)
        {
            WriteLine("bidInt = " + bidInt);
        }

        private static void GetBid(string bidString)
        {
            WriteLine("bidString = " + bidString);
        }
        
    }
}
