using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB03SalesTransactionDemo
{
    class SalesTransaction
    {
        public string SalespersonName { get; set; }
        public double SalesAmount { get; set; }
        private double Commission { get; set; }
        //Readonly
        public double CommissionRate { get; }

        //Default Constructor
        public SalesTransaction()
        {
            SalespersonName = "None";
            SalesAmount = 0.00;
            Commission = 0.00;
            CommissionRate = 0.00;
        }
        //1
        public SalesTransaction(string salespersonName, double salesAmount, double commissionRate)
        {
            this.SalespersonName = salespersonName;
            this.SalesAmount = salesAmount;
            this.CommissionRate = commissionRate;
            Commission = salesAmount * commissionRate;
        }
        //2
        public SalesTransaction(string salespersonName, double salesAmount)
        {
            this.SalespersonName = salespersonName;
            this.SalesAmount = salesAmount;
            Commission = 0.00;
            CommissionRate = 0.00;
        }
        //3
        public SalesTransaction(string salespersonName)
        {
            this.SalespersonName = salespersonName;
            SalesAmount = 0.00;
            Commission = 0.00;
            CommissionRate = 0.00;
        }
        public override string ToString()
        {
            return string.Format("{0}'s made {1:c} commission on his {2:c} sale that totalled out to {3:c}", 
                this.SalespersonName, this.CommissionRate, this.SalesAmount, this.Commission);
        }
        //Overloaded + operator
        public static double operator +(SalesTransaction first, SalesTransaction second)
        {
            double newSalesAmount = first.SalesAmount + second.SalesAmount;
            return newSalesAmount;
        }
    }
}
