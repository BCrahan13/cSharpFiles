using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public static class Extension
    {
        //extend int class
        public static int AddCheckDigit(this int num)
        {
            num = 5;
            int first = num / 10;//0
            int second = num % 10;//0
            int third = (first + second) % 10;//1
            int result = num * 10 + third;//1011
            return result;
        }
    }
}
