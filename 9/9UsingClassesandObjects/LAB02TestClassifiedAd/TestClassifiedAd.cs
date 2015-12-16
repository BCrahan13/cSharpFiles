using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB02TestClassifiedAd
{
    class TestClassifiedAd
    {
        static void Main(string[] args)
        {
            ClassifiedAd ad1 = new ClassifiedAd("Used Cars", 2);

            WriteLine("The {0} Ad containing {1} words costs {2:c}", ad1.Category, ad1.NumWords, ad1.Price);
        }
    }
}
