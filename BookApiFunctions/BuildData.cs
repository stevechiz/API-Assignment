using System;
using System.Collections.Generic;
using System.Text;

namespace BooksApiServerless
{
    public static class BuildData
    {
        /// <summary>
        /// Create sample data in memory
        /// </summary>
        public static void Initialise ()
        {
            if (Data.Books  == null)
            {
                var author = new Models.Author
                {
                    id = "1",
                    name = "Mary Kipper",
                    dateOfBirth = "03-May-1963",
                    dateOfDeath = "29-Mar-2017",
                    placeOfBirth = "London",
                    placeOfDeath = "Cardiff"
                };

                var authors = new List<Models.Author>();

                authors.Add(author);

                Data.Books = new List<Models.Book>();

                Data.Books.Add(new Models.Book
                {
                    id = "1",
                    title = "Book One",
                    publisher = "Rabble house",
                    price = "9.99",
                    year = "2001",
                    author = authors
                });

                Data.Books.Add(new Models.Book
                {
                    id = "2",
                    title = "Book Two",
                    publisher = "Argos Factor Zen",
                    price = "12.49",
                    year = "2007",
                    author = authors
                });

            }
        }
    }
}
