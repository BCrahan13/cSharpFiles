using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _12WebAddressRedo
{
    class WebAddress
    {
        static void Main(string[] args)
        {
            //int x;
            //string userInput;
            string webAddress = "";
            Write("What is your business name? ");
            string userInput = ReadLine();

            for (int x = 0; x < userInput.Length; ++x)
            {
                if (userInput.Substring(x, 1) != " ")
                    webAddress += userInput.Substring(x, 1);
            }
            WriteLine("\nwww.{0}.com", webAddress);
        }
    }
}
