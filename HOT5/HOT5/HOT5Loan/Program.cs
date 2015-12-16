using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HOT5Loan
{
    class Program
    {
        static void Main(string[] args)
        {
            const double INTEREST_RATE = 0.05;


            BankLoan bankLoan = new BankLoan();

            Write("What was the total bank loan amount?\t");
            bankLoan.LoanAmount = Convert.ToDouble(ReadLine());
            while(bankLoan.LoanAmount < 0)
            {
                Write("Please enter a valid number\nWhat was the total bank loan amount?\t");
                bankLoan.LoanAmount = Convert.ToDouble(ReadLine());
            }
            WriteLine("\nThe original bank loan was {0:c}", bankLoan.LoanAmount);
            double bankLoanTotal = bankLoan.LoanAmount - 200.00;
            WriteLine("After 1 payment the bank loan is down to {0:c}", bankLoanTotal);
            double bankLoanAfterInterest = bankLoanTotal + (bankLoanTotal * INTEREST_RATE);
            WriteLine("After 1 interest fee accumulation of {0:c} the loan is now {1:c}", bankLoanTotal * INTEREST_RATE, bankLoanAfterInterest);


            CarLoan carLoan = new CarLoan();

            Write("\nWho was the auto dealer for your car loan?\t");
            carLoan.AutoDealerName = ReadLine();
            Write("What was the total car loan amount at {0}?\t", carLoan.AutoDealerName);
            carLoan.CarLoanAmount = Convert.ToDouble(ReadLine());
            while (carLoan.CarLoanAmount < 0)
            {
                Write("Please enter a valid number.\nWhat was the total car loan amount at {0}\t", carLoan.AutoDealerName);
                carLoan.CarLoanAmount = Convert.ToDouble(ReadLine());
            }
            WriteLine("\nThe auto dealer was {0}\nThe original car loan was {1:c}", carLoan.AutoDealerName, carLoan.CarLoanAmount);
            double carLoanTotal = carLoan.CarLoanAmount - 450.00;
            WriteLine("After 1 payment the car loan is down to {0:c}", carLoanTotal);
            double carLoanAfterInterest = carLoanTotal + (carLoanTotal * INTEREST_RATE);
            WriteLine("After 1 interest fee accumulation of {0:c} the loan is now {1:c}", carLoanTotal * INTEREST_RATE, carLoanAfterInterest);
        }
    }
}
