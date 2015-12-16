using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB9SortWords
{
    class SortWords
    {
        static void Main(string[] args)
        {
            Write("Enter words separated by spaces: ");
            string listOfWords = ReadLine();
            string[] words = listOfWords.Split(' ');
            Array.Sort(words);
            foreach (var word in words)
                WriteLine(word);
        }
    }
}
