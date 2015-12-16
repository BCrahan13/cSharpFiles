using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB04AOrderExceptionDemo
{
    class OrderExceptionDemo
    {
        static void Main(string[] args)
        {
            bool whileDone = false;
            int itemNumber = 0, quantity = 0, daysOrdered = 0;
            //Array of 2 orders
            Order[] orderArray = new Order[5];
            for (int i = 0; i < orderArray.Length; i++)
            {
                //reset
                itemNumber = 0;
                quantity = 0;
                daysOrdered = 0;
                whileDone = false;
                //get user input
                WriteLine("\nOrder {0}", i + 1);
                while (whileDone == false)
                {
                    try
                    {
                        if (itemNumber == 0)
                        {
                            Write("Item Number (100-999): ");
                            itemNumber = Convert.ToInt32(ReadLine());
                        }

                        if (quantity == 0)
                        {
                            Write("Quantity (1-12): ");
                            quantity = Convert.ToInt32(ReadLine());
                        }

                        if (daysOrdered == 0)
                        {
                            Write("Days Ordered (1-31): ");
                            daysOrdered = Convert.ToInt32(ReadLine());
                        }

                        //invalid var
                        if (itemNumber < 100 || itemNumber > 999 || quantity < 1 || quantity > 12 || daysOrdered < 1 || daysOrdered > 31)
                        {
                            throw new ArgumentException();
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        if (itemNumber < 100 || itemNumber > 999)
                            WriteLine("\nItem Number must be 100-999!");

                        if (quantity < 1 || quantity > 12)
                            WriteLine("\nQuantity must be 1-12!");

                        if (daysOrdered < 1 || daysOrdered > 31)
                            WriteLine("\nDays Ordered must be 1-31!");

                        itemNumber = 0;
                        quantity = 0;
                        daysOrdered = 0;
                        whileDone = true;
                    }
                    catch (Exception ex)
                    {
                        WriteLine(ex.Message);
                    }
                    if (itemNumber == 0)
                    {
                        orderArray[i] = new Order();
                    }
                    else if (daysOrdered > 0)
                    {
                        orderArray[i] = new Order(itemNumber, quantity, daysOrdered);
                        whileDone = true;
                    }
                }//end while
            }//end for 
            //print Order objects
            for (int i = 0; i < orderArray.Length; i++)
            {
                WriteLine("\nOrder {0}:\t{1}", i + 1, orderArray[i]);
            }
        }//end main()
    }
}
