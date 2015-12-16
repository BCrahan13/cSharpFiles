using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HOT4_2
{
    class Program2
    {
        static void Main(string[] args)
        {
            string[] UserInputArray = { };

            Random randomNumOfValues = new Random();
            int i = randomNumOfValues.Next();
            ConvertToDouble(UserInputArray[i]);
        }

        //private static void ConvertToDouble(string v)
        //{
        //    throw new NotImplementedException();
        //}

        private static void ConvertToDouble(params double[] numbers)
        {
            foreach (double num in numbers)
                Write("{0}", num);
        }
    }
}
