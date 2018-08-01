
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;

namespace BooksApiServerless
{
    public static class Insert
    {
        static Insert()
        {
            ApplicationHelper.Startup();
        }

        [FunctionName("Insert")]
        [HttpPost]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = "books")]HttpRequest req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Populate sample book data:
            BuildData.Initialise();

            string requestBody = new StreamReader(req.Body).ReadToEnd();
            dynamic book = JsonConvert.DeserializeObject(requestBody, typeof(Models.Book));

            Data.Books.Add(book);

            return new OkResult();
        }
    }
}
