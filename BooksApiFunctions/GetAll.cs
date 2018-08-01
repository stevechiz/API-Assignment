
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;

namespace BooksApiServerless
{
    public static class GetAll
    {
        [FunctionName("GetAll")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "books")]HttpRequest req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Populate sample book data:
            BuildData.Initialise();

            return new OkObjectResult(Data.Books);
        }
    }
}
