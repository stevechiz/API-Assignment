using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksApiServerless.Models;

namespace BooksApiServerless
{
    /// <summary>
    /// In-memory data store to hold sample data
    /// </summary>
    public static class Data
    {
        public static List<Book> Books {get; set;}

    }
}
