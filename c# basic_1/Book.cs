using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__basic_1
{
    public class Book
    {
        public string title { get; set; } = "";
        public int pages { get; set; }
        public override string ToString()
        {
             return $"Book title : {title}, with pages {pages}";
        }

    }
}
