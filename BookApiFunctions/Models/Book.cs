using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApiServerless.Models
{
    public class Book
    {

        public string id { get; set; }

        public string title { get; set; }

        public string publisher { get; set; }

        public string year { get; set; }

        public string price { get; set; }

        public List<Author> author { get; set; }
    }
}
