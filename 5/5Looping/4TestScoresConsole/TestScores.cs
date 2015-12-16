using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _4TestScoresConsole
{
    class TestScores
    {
        static void Main(string[] args)
        {
            string score = "";
            double dblScore = 0.00;
            double count = 0.00;
            double totalScore = 0.00;
            double average = 0.00;

            while (score != "!")
            {
                Write("Enter test score: ");
                score = ReadLine();
                if (score != "!")
                {
                    dblScore = Convert.ToDouble(score);
                    if (dblScore < 0.00 || dblScore > 100.00)
                    {
                        WriteLine("Error: score must be 0.00 - 100.00");
                    }
                    else
                    {
                        count++;
                        totalScore += dblScore;
                    }
                }
            }
            if (count != 0.00)
            {
                average = totalScore / count;
            }
            WriteLine("{0} tests at an average of {1}", count, average);
        }
    }
}
