using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB2IntegerFacts
{
    class IntegerFacts
    {
        static void Main(string[] args)
        {
            Write("Enter vals separated by spaces: ");
            string listOfWords = ReadLine();
            string[] words = listOfWords.Split(' ');
            Array.Sort(words);
            foreach (var word in words)
                WriteLine(word);


            int[] intArray = new int[] { };
            GetArrayValues();
        }

        private static void GetArrayValues()
        {
            //for (int i = 0; i < intArray[].Length; ++i)
            {

            }
        }
    }
}
