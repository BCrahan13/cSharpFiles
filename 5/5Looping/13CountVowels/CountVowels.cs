﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _13CountVowels
{
    class CountVowels
    {
        static void Main(string[] args)
        {
            int total = 0;
            Write("Input a string: ");
            string userInput = ReadLine().ToLower();

            for (int x = 0; x < userInput.Length; ++x)
            {
                if (userInput.Substring(x, 1) == "a")
                    ++total;
                else if (userInput.Substring(x, 1) == "e")
                    ++total;
                else if (userInput.Substring(x, 1) == "i")
                    ++total;
                else if (userInput.Substring(x, 1) == "o")
                    ++total;
                else if (userInput.Substring(x, 1) == "u")
                    ++total;
            }
            WriteLine("\n{0} contains {1} vowels", userInput, total);
        }
    }
}
