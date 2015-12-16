using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB7Admission
{
    class Admission
    {
        static void Main(string[] args)
        {
            Write("Enter your high school GPA: ");
            double gpa = Convert.ToDouble(ReadLine());
            if (gpa > 4.0 || gpa < 0.00)
            {
                Write("Error\nEnter your high school GPA: ");
                gpa = Convert.ToDouble(ReadLine());
            }
            else
            {
                Write("Enter your admission test score: ");
                double testScore = Convert.ToDouble(ReadLine());
                TestScore(gpa, testScore);
            }
        }

        private static void TestScore(double gpa, double testScore)
        {
            if (gpa >= 3.00 && testScore >= 60.00)
                WriteLine("Accepted");
            else if (gpa < 3.00 && testScore >= 80.00)
                WriteLine("Accepted");
            else
                WriteLine("Rejected");
        }
    }
}
