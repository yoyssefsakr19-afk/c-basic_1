using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace c__basic_1
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            #region quesion 1
            //1:
            // solve task 1 
            //Book book = new Book { title= "clean code", pages = 200 };
            //object obj = book;
            //Console.WriteLine(obj.ToString());
            #endregion
            #region quesion 2

            /// Book book = new Book { title= "clean code", pages = 200 };

            /// Console.WriteLine(book.ToString());
            ///Console.WriteLine(book.Equals(book));
            ///Console.WriteLine(book.GetHashCode());
            ///Console.WriteLine(book.GetType());

            #endregion
            #region quesion 3
            //3
            int pages = 464;
            Console.WriteLine(pages);
            #endregion
            #region quesion 4
            int a = 10;
            int b = 0;
            try
            {
                int result = a / b;
                Console.WriteLine(result);
            }
            catch (Exception)
            {
                Console.WriteLine("can not divided by zero ");
            }
            finally
            {
                Console.WriteLine("done");
#endregion
                #region quesion 5
                //5
                //int Pages = 300;
                //double pagesAsDouble = Pages;

                //Console.WriteLine(pagesAsDouble);
                #endregion
                #region quesion6    
                // 6
                double price = 49.99;
                int priceAsInt =(int)price;
                Console.WriteLine(priceAsInt);
                #endregion
            }
        }
    }
}
