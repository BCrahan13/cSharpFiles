using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo
{
    class Order
    {
        //4 instance fields
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public int QuantityOrdered { get; set; }
        //Readonly(set in constructor)
        private double price;
        private double totalPrice;
        public double Price
        {
            get
            {
                return price;
            }
        }
        public double TotalPrice
        {
            get
            {
                return totalPrice;
            }
        }

        public Order(int orderNumber, string customerName, int quantityOrdered)
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            QuantityOrdered = quantityOrdered;
            //set price in constructor to return price field to the get block of the property
            price = quantityOrdered * 19.95;
            totalPrice += price;
        }
        
        public bool Equals(Order isEqual)
        {
            if(OrderNumber == isEqual.OrderNumber)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return OrderNumber;
        }

        public override string ToString()
        {
            return "\nOrder Number = " + OrderNumber + "\nCustomer Name = " + CustomerName + "\nQuantity Ordered = " + QuantityOrdered + "\nPrice = " + Price;
        }

    }
}
