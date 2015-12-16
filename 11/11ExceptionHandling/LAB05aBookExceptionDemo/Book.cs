using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05aBookExceptionDemo
{
    class Book
    {
        //3 auto implemented fields
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int NumPages { get; set; }

        //Constructors
        public Book()
        {
            Title = "";
            Author = "";
            Price = 0.00;
            NumPages = 0;
        }
        public Book(string title, string author, double price, int numPages)
        {
            Title = title;
            Author = author;
            Price = price;
            NumPages = numPages;
        }

        public override string ToString()
        {
            return string.Format("Title = {0}\tAuthor = {1}\tPrice = {2:c}\tPages = {3}\tRatio = 0.10", Title, Author, Price, NumPages);
        }
    }
}
