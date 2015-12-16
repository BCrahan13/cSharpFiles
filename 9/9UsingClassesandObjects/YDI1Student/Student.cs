using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace YDI1Student
{
    class Student : IComparable
    {
        //private int idNumber;
        //private string lastName;
        private double gradePointAverage;

        public const double HIGHEST_GPA = 4.0;
        public const double LOWEST_GPA = 0.0;

        public int IdNumber { get; set; }
        public string LastName { get; set; }
        //public int IdNumber
        //{
        //    get
        //    {
        //        return idNumber;
        //    }
        //    set
        //    {
        //        idNumber = value;
        //    }
        //}
        //public string LastName
        //{
        //    get
        //    {
        //        return lastName;
        //    }
        //    set
        //    {
        //        lastName = value;
        //    }
        //}
        public double GradePointAverage
        {
            get
            {
                return gradePointAverage;
            }
            set
            {
                if (value >= LOWEST_GPA && value <= HIGHEST_GPA)
                    gradePointAverage = value;
                else
                    gradePointAverage = LOWEST_GPA;
            }
        }
        //static void Main()
        //{
        //    Student first = new Student();
        //    Student second = new Student();
        //    first.IdNumber = 123;
        //    first.LastName = "Anderson";
        //    first.GradePointAverage = 3.5;
        //    second.IdNumber = 789;
        //    second.LastName = "Daniels";
        //    second.GradePointAverage = 4.1;

        //    Display(first);
        //    Display(second);
        //}

        //static void Display(Student stu)
        //{
        //    WriteLine("{0,5} {1, -10} {2, 6}", stu.IdNumber, stu.LastName, stu.GradePointAverage.ToString("F1"));
        //}

        public Student(int id, string name, double gpa)
        {
            IdNumber = IdNumber;
            LastName = name;
            GradePointAverage = gpa;
        }
        public Student() : this(0, "XXX", 0.0)
        {

        }

        int IComparable.CompareTo(Object o)
        {
            int returnVal;
            Student temp = (Student)o;
            if (this.IdNumber > temp.IdNumber)
                returnVal = 1;
            else
                if (this.IdNumber < temp.IdNumber)
                    returnVal = -1;
                else
                    returnVal = 0;
            return returnVal;
        }
    }
}
