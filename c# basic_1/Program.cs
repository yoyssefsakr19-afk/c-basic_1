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
            //int pages = 464;
            //Console.WriteLine(pages);
            #endregion
            #region quesion 4
            //int a = 10;
            //int b = 0;
            //try
            //{
            //    int result = a / b;
            //    Console.WriteLine(result);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("can not divided by zero ");
            //}
            //finally
            //{
            //    Console.WriteLine("done");
            //}
            #endregion
            #region quesion 5
            //5
            //int Pages = 300;
            //double pagesAsDouble = Pages;

            //Console.WriteLine(pagesAsDouble);
            #endregion
            #region quesion6    
            // 6
            //double price = 49.99;
            //int priceAsInt =(int)price;
            //Console.WriteLine(priceAsInt);
            #endregion
            #region quesion 7
            //7
            //string pagesText = "464";
            //Console.WriteLine(pagesText);

            #endregion
            #region quesion 8
            //8
            //string yearText = "2023";
            //int year = int.Parse(yearText);
            // Console.WriteLine(year);

            //string badtext = "abc";
            //if (int.TryParse(badtext, out int namber))
            //  Console.WriteLine(namber);
            // else
            // {
            //  Console.WriteLine("invalid number");
            // }

            #endregion
            #region quesion 9
            //9..
            //int Pages = 464;
            //string pagestext = pages.ToString();
            //Console.WriteLine(pagestext);
            //Console.WriteLine(pagestext.GetType());


            #endregion
            #region quesion 10
            // int copies = 100;

            //object boxed = copies;
            //Console.WriteLine(boxed);

            //int unboxed =(int)boxed;
            // Console.WriteLine(unboxed);

            #endregion
            #region quesion 11
            //Q11 
            //int? year = null;
            //Console.WriteLine(year.HasValue);

            //year = 2026;
            //Console.WriteLine(year.HasValue);





            #endregion
            #region quesion 12
            //string reviewer = null;

            //Console.WriteLine(reviewer is null);
            #endregion
            #region quesion 13
            //Q13
            //Book book = null;

            //string title = book.title;
            //Console.WriteLine(title);




            #endregion
            #region quesion 14
            //Console.WriteLine(title ?? "Untitled");
            //title = "Untitled";

            //Console.WriteLine(title);
            #endregion
            #region QUESION 15
            //Q15
            string name = "youssef";

            string confirmedName = name;
            Console.WriteLine(confirmedName);
            #endregion

        }
    }
    }

