
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BooksApiServerless
{
    public static class GetById
    {
        [FunctionName("GetBooksById")]
        [HttpGet]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "books/{id}")]HttpRequest req, string id, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Populate sample book data:
            BuildData.Initialise();

            //string name = req.Query["name"];

            //string requestBody = new StreamReader(req.Body).ReadToEnd();
            //dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;

            var book = Data.Books.Find(q => q.id == id);

            return new OkObjectResult(book);
        }
    }
}
