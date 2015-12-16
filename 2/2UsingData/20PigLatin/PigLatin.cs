using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _20PigLatin
{
    class PigLatin
    {
        static void Main(string[] args)
        {
            Write("Enter word: ");
            string inputString = Console.ReadLine();
            string firstLetter = inputString.Substring(0, 1);
            string restWord = inputString.Substring(1);
            WriteLine("PigLatin = {0}{1}ay", restWord, firstLetter);
        }
    }
}
