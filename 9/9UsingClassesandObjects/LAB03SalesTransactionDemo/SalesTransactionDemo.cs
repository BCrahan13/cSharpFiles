using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB03SalesTransactionDemo
{
    class SalesTransactionDemo
    {
        static void Main(string[] args)
        {
            SalesTransaction sale1 = new SalesTransaction("Joe", 1000.00, 3.00);
            SalesTransaction sale2 = new SalesTransaction("Jack", 500.00);
            SalesTransaction sale3 = new SalesTransaction("Jill");

            //SalesTransaction totalSalesAmount = new SalesTransaction(totalSalesAmount);
            WriteLine(sale1.ToString());
            WriteLine(sale2.ToString());
            WriteLine(sale3.ToString());
            //WriteLine("{0:c} + {1:c} = {2:c}", sale1.SalesAmount, sale2.SalesAmount, totalSalesAmount);
            
            double newSalesAmount = sale1 + sale2;
            WriteLine("The newSalesAmount = {0:c}", newSalesAmount);
        }
    }
}
