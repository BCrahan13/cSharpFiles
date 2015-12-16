using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB7AveragesRedo
{
    class AveragesRedo
    {
        static void Main(string[] args)
        {
            Write("Input list of words separated by spaces: ");
            string listOfWords = Console.ReadLine();
            string[] words = listOfWords.Split(' ');
            Array.Sort(words);

                int number;

                bool result = Int32.TryParse(words, out number);
                if (result)
                    WriteLine("Converted {0} to {1}", words, number);
                else
                    WriteLine("Attempted conversion of {0} failed");

            foreach (var word in words)
            {
                WriteLine(number);
            }
        }
    }
}
