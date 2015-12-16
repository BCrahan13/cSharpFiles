using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB5DeliveryCharges
{
    class DeliveryCharges
    {
        static void Main(string[] args)
        {
            int[] zipCodeArray = { 63011, 63021, 63025, 63031, 63034, 63105, 63110, 63131, 63141, 63376 };
            double[] deliveryChargesArray = { 1.00, 2.00, 3.00, 4.00, 5.00, 6.00, 7.00, 8.00, 9.00, 10.00 };
            //string inputString;
            bool isValidZipCode = false;

            Write("Enter your zipcode: ");
            int zip = Convert.ToInt32(ReadLine());

            //Write("Enter delivery charge: ");
            //double deliveryCharge = Convert.ToDouble(ReadLine());

            for (int x = 0; x < zipCodeArray.Length; ++x)
            {
                if (zip == zipCodeArray[x])
                {
                    isValidZipCode = true;
                    zip = zipCodeArray[x];
                    double deliveryCharge = deliveryChargesArray[x];
                }
            }

            if (isValidZipCode)
                WriteLine("{0} IS valid and has a delivery charge of {1:c}", zip, deliveryCharge);
            else
                WriteLine("{0} NOT valid", zip);
        }
    }
}
