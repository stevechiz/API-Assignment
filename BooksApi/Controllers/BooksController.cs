using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BooksApi.Models;

namespace BooksApi.Controllers
{
    [Route("v1/[controller]")]
    public class BooksController : Controller
    {
        // GET v1/books
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return Data.Books;
        }

        // GET v1/books/5
        [HttpGet("{id}")]
        public Book Get(string id)
        {
            return Data.Books.FirstOrDefault(q=>q.id.Equals(id,StringComparison.OrdinalIgnoreCase));
        }

        // POST v1/books
        [HttpPost]
        public void Post([FromBody]Book value)
        {
            Data.Books.Add(value);
        }

        // PUT v1/books/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Book value)
        {
            var book = Data.Books.FirstOrDefault(q=>q.id.Equals(id,StringComparison.OrdinalIgnoreCase));

            if ( book != null)
            {
                Data.Books[book.GetHashCode()] = value;
            }
        }

        // PATCH v1/books/5
        [HttpPatch("{id}")]
        public void Patch(string id, [FromBody]string value)
        {
        }

        // DELETE v1/books/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var book = Data.Books.FirstOrDefault(q=>q.id.Equals(id,StringComparison.OrdinalIgnoreCase));

            if (book != null)
            {
                Data.Books.Remove(book);
            }
        }
    }
}
