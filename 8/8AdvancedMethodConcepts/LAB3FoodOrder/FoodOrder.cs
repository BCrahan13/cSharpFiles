using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB3FoodOrder
{
    class FoodOrder
    {
        static void Main(string[] args)
        {
            Write("Item Number\tDescription\n\n\t20\tEnchilada\n\t23\tButtito\n\t25\tTaco\n\t31\tTostada\n\nChoose an item number or description: ");

            int itemNumber = 0;
            string description = ReadLine().ToLower();
            int.TryParse(description, out itemNumber);
            if (!int.TryParse(description, out itemNumber))
                GetDetail(description);
            GetDetails(itemNumber);
        }

        private static void GetDetail(string description)
        {
            int itemNumber = 0;
            double price = 0.00;
            if(description == "enchilada")
            {
                itemNumber = 20;
                price = 2.95;
            } else if(description == "buttito")
            {
                itemNumber = 23;
                price = 1.95;
            } else if(description == "taco")
            {
                itemNumber = 25;
                price = 2.25;
            } else if(description == "tostada")
            {
                itemNumber = 31;
                price = 3.10;
            }
            WriteLine("You chose {0}, which is {1:c}", itemNumber, price);
        }

        private static void GetDetails(int itemNumber)
        {
            string description = "";
            double price = 0;
            if (itemNumber == 20)
            {
                description = "enchilada";
                price = 2.95;
            } else if (itemNumber == 23)
            {
                description = "burrito";
                price = 1.95;
            } else if (itemNumber == 25)
            {
                description = "taco";
                price = 2.25;
            } else if (itemNumber == 31)
            {
                description = "tostada";
                price = 3.10;
            }
            WriteLine("You chose {0}, which is {1:c}", description, price);
        }
    }
}
