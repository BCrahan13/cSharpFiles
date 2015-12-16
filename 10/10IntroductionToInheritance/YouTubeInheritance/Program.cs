using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace YouTubeInheritance
{
    public class ParentClass
    {
        public ParentClass()
        {
            WriteLine("ParentClass Constructor called");
        }
        public ParentClass(string message)
        {
            WriteLine(message);
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Derived class controlling parent class")
        {
            WriteLine("ChildClass Constructor called");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChildClass cc = new ChildClass();
            //ParentClass pc = new ParentClass();
        }
    }
}
