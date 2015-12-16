using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB09SalespersonDemo
{
    abstract class SalesPerson 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public SalesPerson(string first, string last)
        {
            FirstName = first;
            LastName = last;    
        }

        public string getFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
