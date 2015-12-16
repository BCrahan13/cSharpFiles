using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB04AOrderExceptionDemo
{
    class Order
    {
        //3 Fields
        public int ItemNumber { get; set; }
        public int Quantity { get; set; }
        public int DaysOrdered { get; set; }

        //Constructors
        public Order()
        {
            ItemNumber = 0;
            Quantity = 0;
            DaysOrdered = 0;
        }
        public Order (int itemNumber, int quantity, int daysOrdered)
        {
            ItemNumber = itemNumber;
            Quantity = quantity;
            DaysOrdered = daysOrdered;
        }
        public override string ToString()
        {
            return string.Format("Item Number = {0}\tQuantity = {1}\tDays Ordered = {2}", ItemNumber, Quantity, DaysOrdered);
        }
    }
}
