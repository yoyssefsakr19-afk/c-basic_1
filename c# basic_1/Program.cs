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

        }
    }
}
