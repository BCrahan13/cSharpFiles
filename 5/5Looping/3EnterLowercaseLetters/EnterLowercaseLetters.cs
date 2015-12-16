using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _3EnterLowercaseLetters
{
    class EnterLowercaseLetters
    {
        static void Main(string[] args)
        {
            string userInput = "";
            
            while (userInput != "!")
            {
                Write("Enter a lowercase letter: ");
                userInput = ReadLine();
                if (userInput != userInput.ToLower())
                    WriteLine("INCORRECT\n");
                else
                    WriteLine("OK\n");
            }
            WriteLine("PROGRAM TERMINATED");
        }
    }
}
