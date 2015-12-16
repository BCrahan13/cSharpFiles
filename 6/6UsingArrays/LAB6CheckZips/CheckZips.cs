using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB6CheckZips
{
    class CheckZips
    {
        static void Main(string[] args)
        {
            int[] zipCodeArray = {63011, 63021, 63025, 63031, 63034, 63105, 63110, 63131, 63141, 63376};
            string inputString;
            bool isValidZipCode = false;

            Write("Enter your zipcode: ");
            int zip = Convert.ToInt32(ReadLine());

            for (int x = 0; x < zipCodeArray.Length; ++x)
            {
                if (zip == zipCodeArray[x])
                {
                    isValidZipCode = true;
                    zip = zipCodeArray[x];
                }
            }
            if (isValidZipCode)
                WriteLine("{0} IS valid", zip);
            else
                WriteLine("{0} NOT valid", zip);
        }
    }
}
