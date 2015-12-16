using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MortgageApplication
{
    class Mortgage
    {
        public string Name { get; set; }
        public double CreditScore { get; set; }

        public Mortgage()
        {
            Name = "";
            CreditScore = 0;
        }
        public Mortgage(double creditScore)
        {
            WriteLine("creditScore = {0}", creditScore);
        }

    }
}
