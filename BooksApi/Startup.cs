using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BooksApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            // Populate sample book data
            PopulateData();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

        /// <summary>
        /// Popluate sample book data
        /// </summary>
        private void PopulateData()
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
