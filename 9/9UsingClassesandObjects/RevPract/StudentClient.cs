using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RevPract
{
    class StudentClient
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student("Jill", "Anderson");
            Student s5 = new Student(22695,"Jack", "Anderson",3.2,"They");

            WriteLine(s5.ToString());

            //Student[] rankenStudents = new Student[2500];

            //for(int i = 0; i < rankenStudents.Length; i++)
            //{
            //    rankenStudents[i] = new Student();
            //}
            //rankenStudents[0].SetFirstName("Billy");
            //WriteLine(rankenStudents[0].GetFirstName());

            s1.SetStudentID(22691);
            s1.SetFirstName("Joe");
            s1.SetLastName("Anderson");
            s1.SetGpa(1.1);

            s2.SetStudentID(22692);
            s2.SetFirstName("John");
            s2.SetLastName("Anderson");
            s2.SetGpa(4.0);

            s3.Gender = "Male";
            s3.Height = 6.2;
            s3.Age = 22;

            WriteLine(s3.Gender);
            WriteLine(s3.Height);
            WriteLine(s3.Age);

            //WriteLine("The first student {0} {1} has a student id of {2} and a gpa of {3}", s1.GetFirstName(), s1.GetLastName(), s1.GetStudentId(), s1.GetGpa());
            //WriteLine("The second student {0} {1} has a student id of {2} and a gpa of {3}", s2.GetFirstName(), s2.GetLastName(), s2.GetStudentId(), s2.GetGpa());

        }
    }
}
