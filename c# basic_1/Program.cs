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
            Book book = new Book { title= "clean code", pages = 200 };
            object obj = book;
            Console.WriteLine(obj.ToString());
            #endregion
        }
    }
}
