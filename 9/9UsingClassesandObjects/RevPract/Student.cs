using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevPract
{
    public class Student
    {
        //Fields
        private int studentId;
        private string firstName;
        private string lastName;
        private double gpa;

        private string gender;

        //Constructor
        //Parameterless constructor
        public Student()
        {

        }
        //2 param (overloaded) constructor
        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        //5 param (overloaded) constructor
        public Student(int studentId, string firstName, string lastName, double gpa, string gender)
        {
            this.studentId = studentId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gpa = gpa;
            this.gender = gender;
        }


        //Prop for gender field
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value != "Male" || value != "Female" || value != "They")
                {
                    this.gender = "";
                }
                else
                {
                    this.gender = value;
                }
            }
        }

        //auto implemented properties
        public double Height { get; set; }
        public int Age { get; set; }

        //Public instance field
        public const string RANKENMOTTO = "Are you Ranken Material?";

        //Class Collaboration
        private Book CSharp;

        //Mutator
        public void SetStudentID(int id)
        {
            if(id < 0)
            {
                studentId = 0;
            }
            else
            {
                studentId = id;
            }
        }
        public void SetFirstName(string firstName)
        {
            //instance field = param val
            this.firstName = firstName;
        }
        public void SetLastName(string lastName)
        {
            //instance field = param val
            this.lastName = lastName;
        }
        public void SetGpa(double gpa)
        {
            //instance field = param val
            this.gpa = gpa;
        }

        //Accessor
        public int GetStudentId()
        {
            return studentId;
        }
        public string GetFirstName()
        {
            return firstName;
        }
        public string GetLastName()
        {
            return lastName;
        }
        public double GetGpa()
        {
            return gpa;
        }

        public override string ToString()
        {
            return String.Format("The student {0} {1} with an id of {2} is a {3} with a GPA of {4}", this.firstName, this.lastName, this.studentId, this.gender, this.gpa);
        }

    }
}
