using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OrderDemo
{
    class OrderDemo2
    {
        static void Main(string[] args)
        {
            //ArrayList
            List<Order> orders = new List<Order>();

            while(orders.Count != 5)
            {
                string input = "";
                bool exist = false;
                int orderNumber = 0;
                string customerName = "";
                int quantity = 0;

                Write("\nEnter an order number: ");
                input = ReadLine();
                orderNumber = Int32.Parse(input);

                foreach(Order existing in orders)
                {
                    if (existing.OrderNumber == orderNumber)
                        exist = true;
                }

                if(!exist)
                {
                    Write("Enter a Customer Name: ");
                    customerName = ReadLine();
                    Write("Enter a Quantity: ");
                    quantity = Int32.Parse(ReadLine());
                    Order newOrder = new Order(orderNumber, customerName, quantity);
                    orders.Add(newOrder);
                }
                else
                    WriteLine("Order Number exists.\nTry again\n\n");
            }

            double quant = 0;
            double cost = 0.00;
            foreach(Order order in orders)
            {
                WriteLine("\nOrder Number: " + order.OrderNumber + "\nCustomer Name: " + order.CustomerName + "\nQuantity Ordered: " + order.QuantityOrdered + "\nPrice: " + order.Price);
                quant += order.QuantityOrdered;
                cost += order.TotalPrice;
            }
            WriteLine("\n\nTotal orders: " + quant + "\nTotal Price: " + cost);
        }

        protected static void CompareOrders(Order first, Order second)
        {
            if(first.Equals(second))
            {
                WriteLine("Order Numbers are equal: " + first.CustomerName + " & " + second.CustomerName);
            }
        }
    }
}
