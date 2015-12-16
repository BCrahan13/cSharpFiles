using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB05aBookExceptionDemo
{
    class BookException : Exception
    {
        public BookException() { }
        public BookException(string message, string title, string author, double price, int pages) : base(message) { }
    }
}
