using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB05aBookExceptionDemo
{
    class BookExceptionDemo
    {
        static void Main(string[] args)
        {
            bool whileDone = false;
            string title = "";
            string author = "";
            double price = 0.00;
            int numPages = 0;
            const double MaxPricePerPage = 0.10;
            double priceToPagesRatio = 0.00;
            //Construct at least 5 Book objs
            Book[] bookArray = new Book[1];
            for(int i = 0; i < bookArray.Length; i++)
            {
                //reset
                title = "";
                author = "";
                price = 0.00;
                numPages = 0;
                priceToPagesRatio = 0.00;
                whileDone = false;
                WriteLine("\nBook {0}", i + 1);
                Write("Book title: ");
                title = ReadLine();
                Write("\n{0} author: ", title);
                author = ReadLine();
                while (whileDone == false)
                {
                    try
                    {
                        if(price == 0.00)
                        {
                            Write("\nBook price: ");
                            price = Convert.ToDouble(ReadLine());
                        }

                        if(numPages == 0)
                        {
                            Write("\nBook pages: ");
                            numPages = Convert.ToInt32(ReadLine());
                        }

                        WriteLine();
                        
                        priceToPagesRatio = price / numPages;

                        if(priceToPagesRatio > MaxPricePerPage)
                        {
                            whileDone = true;
                            priceToPagesRatio = 0.10;
                            throw new BookException(string.Format("Title = {0}\tAuthor = {1}\tPrice = {2:c}\tPages = {3}"), title, author, price, numPages);
                        }
                        //ends loop
                        else
                        {
                            whileDone = true;
                        }
                    }
                    catch (BookException ex)
                    {
                        WriteLine("Low ratio");

                        price = 0.00;
                        numPages = 0;
                        priceToPagesRatio = 0.00;
                    }
                    catch (Exception ex)
                    {
                        WriteLine("High ratio");
                        //WriteLine("For {0}, ratio is invalid.", title);
                    }
                }//end while
                bookArray[i] = new Book(title, author, price, numPages);
            }//end for
            for(int i = 0; i < bookArray.Length; i++)
            {
                Write("\nBook {0}:\t{1}", i + 1, bookArray[i]);
                //WriteLine("\tPrice to pages ratio = {0}", priceToPagesRatio);
            }
        }//end main
    }
}
