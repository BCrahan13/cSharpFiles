using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB1ArrayDemo
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            int[] scores = new int[8];
            int x;
            string inputString;
            string sentinalValue = "x";
            string inputOrder = "";

            //Ask user for input
            for (x = 0; x < scores.Length; ++x)
            {
                Write("Enter your score on test {0}: ", x + 1);
                inputString = ReadLine().ToLower();

                while (inputString == sentinalValue)
                {
                    WriteLine("Sort in:"
                            + "\n(1) Original order"
                            + "\n(2) Ascending order"
                            + "\n(3) Descending order");
                    inputOrder = ReadLine();

                    //Original order
                    if (inputOrder == "1")
                    {
                        WriteLine("\n-----------------------------");
                        WriteLine("Scores in original order: ");
                        for (x = 0; x < scores.Length; ++x)
                            Write("{0,6}", scores[x]);
                    }

                    //Ascending order
                    if (inputOrder == "2")
                    {
                        WriteLine("\n-----------------------------");
                        Array.Sort(scores);
                        WriteLine("Scores in sorted order: ");
                        for (x = 0; x < scores.Length; ++x)
                            Write("{0,6}", scores[x]);
                    }

                    //Descending order
                    if (inputOrder == "3")
                    {
                        WriteLine("\n------------------------------");
                        Array.Reverse(scores);
                        WriteLine("Scores in reverse order: ");
                        for (x = 0; x < scores.Length; ++x)
                            Write("{0,6}", scores[x]);
                    }

                    //inputString = "";

                } 
                    scores[x] = Convert.ToInt32(inputString);
            }

            WriteLine("Sort in:"
                            + "\n(1) Original order"
                            + "\n(2) Ascending order"
                            + "\n(3) Descending order");
            inputOrder = ReadLine();

            //Original order
            if (inputOrder == "1")
            {
                WriteLine("\n-----------------------------");
                WriteLine("Scores in original order: ");
                for (x = 0; x < scores.Length; ++x)
                    Write("{0,6}", scores[x]);
            }

            //Ascending order
            if (inputOrder == "2")
            {
                WriteLine("\n-----------------------------");
                Array.Sort(scores);
                WriteLine("Scores in sorted order: ");
                for (x = 0; x < scores.Length; ++x)
                    Write("{0,6}", scores[x]);
            }

            //Descending order
            if (inputOrder == "3")
            {
                WriteLine("\n------------------------------");
                Array.Reverse(scores);
                WriteLine("Scores in reverse order: ");
                for (x = 0; x < scores.Length; ++x)
                    Write("{0,6}", scores[x]);
            }

            //WriteLine("Sort in:"
            //                + "\n(1) Original order"
            //                + "\n(2) Ascending order"
            //                + "\n(3) Descending order");
            //inputOrder = ReadLine();

            ////Original order
            //WriteLine("\n-----------------------------");
            //WriteLine("Scores in original order: ");
            //for (x = 0; x < scores.Length; ++x)
            //    Write("{0,6}", scores[x]);

            ////Ascending order
            //WriteLine("\n-----------------------------");
            //Array.Sort(scores);
            //WriteLine("Scores in sorted order: ");
            //for (x = 0; x < scores.Length; ++x)
            //    Write("{0,6}", scores[x]);

            ////Descending order
            //WriteLine("\n------------------------------");
            //Array.Reverse(scores);
            //WriteLine("Scores in reverse order: ");
            //for (x = 0; x < scores.Length; ++x)
            //    Write("{0,6}", scores[x]);
        }
    }
}
