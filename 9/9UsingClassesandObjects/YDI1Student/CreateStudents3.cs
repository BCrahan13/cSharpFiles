using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace YDI1Student
{
    class CreateStudents3
    {
        static void Main()
        {
            Student[] students = new Student[8];
            int x, id;
            string name;
            double gpa;

            for (x = 0; x < students.Length; ++x)
            {
                GetData(out id, out name, out gpa);
                students[x] = new Student(id, name, gpa);
            }
            Array.Sort(students);
            WriteLine("Sorted List:");
            for (x = 0; x < students.Length; ++x)
                Display(students[x]);


            //Student first = new Student();
            //Student second = new Student();

            ////YDI2 additions
            //Student third = new Student(456, "Macro", 2.4);
            //Student fourth = new Student();

            //first.IdNumber = 123;
            //first.LastName = "Anderson";
            //first.GradePointAverage = 3.5;
            //second.IdNumber = 789;
            //second.LastName = "Daniels";
            //second.GradePointAverage = 4.1;

            //Display(first);
            //Display(second);

            ////YDI2 additions
            //Display(third);
            //Display(fourth);
        }

        private static void GetData(out int id, out string name, out double gpa)
        {
            //string inString;
            Write("Please enter student ID number >> ");
            string inString = ReadLine();
            int.TryParse(inString, out id);
            Write("Please enter last name for student {0} >> ", id);
            name = ReadLine();
            Write("Please enter grade point average >> ");
            inString = ReadLine();
            double.TryParse(inString, out gpa);
        }

        static void Display(Student stu)
        {
            WriteLine("{0,5} {1, -10} {2, 6}", stu.IdNumber, stu.LastName, stu.GradePointAverage.ToString("F1"));
        }
    }
}
