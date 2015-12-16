using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _5HomeSalesConsole
{
    class HomeSales
    {
        static void Main(string[] args)
        {

//initial == "D" || initial == "d" || initial == "E" || initial == "e" || initial == "F" || initial == "f"

            WriteLine("Holiday Homes Salespeople include:\nDanielle\nEdward\nFrancis");
            string initial = "";
            //WriteLine("initial={0}" ,initial);

            double dAmount = 0.00;
            double eAmount = 0.00;
            double fAmount = 0.00;
            double grandTotal = 0.00;

            while (initial != "z")
            {
                Write("\nEnter a salesperson's first initial: ");
                initial = ReadLine().ToLower();

                if (initial == "d" || initial == "e" || initial == "f")
                {
                    Write("Enter sales amount: ");
                    double salesAmount = Convert.ToDouble(ReadLine());

                    if (initial == "d")
                        dAmount += salesAmount;
                    else if (initial == "e")
                        eAmount += salesAmount;
                    else if (initial == "f")
                        fAmount += salesAmount;

                    grandTotal = dAmount + eAmount + fAmount;
                }
                
            }

            WriteLine("\nDanielle's Amount: {0:c}"
                    + "\nEdward's Amount: {1:c}"
                    + "\nFrancis' Amount: {2:c}"
                    + "\n\nGrand Total: {3:c}", dAmount, eAmount, fAmount, grandTotal);

        }
    }
}
