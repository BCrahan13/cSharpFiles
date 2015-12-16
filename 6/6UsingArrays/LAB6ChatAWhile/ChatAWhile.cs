using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB6ChatAWhile
{
    class ChatAWhile
    {
        static void Main(string[] args)
        {
            int[] areaCodeArray = {262, 414, 608, 715, 815, 920};
            double[] costPerMinArray = {.07, .10, .05, .16, .24, .14};
            //int areaCode;
            double costPerMin = 0.00;
            double minutes = 0.00;
            double totalCost = 0.00;
            bool isValidAreaCode = false;

            Write("Enter area code: ");
            int areaCode = Convert.ToInt32(ReadLine());

            WriteLine("Enter your minutes of talk time: ");
            minutes = Convert.ToDouble(ReadLine());

            for (int x = 0; x < areaCodeArray.Length; ++x)
            {
                if (areaCode == areaCodeArray[x])
                {
                    isValidAreaCode = true;
                    costPerMin = costPerMinArray[x];
                    totalCost = costPerMin * minutes;
                }
            }
            if (isValidAreaCode)
            {
                WriteLine("costPerMin = {0:c}", costPerMin);
                WriteLine("minutes = {0}", minutes);
                WriteLine("totalCost = {0:c}", totalCost);
            }
            else
                WriteLine("Sorry - area code not found.");
        }
    }
}
