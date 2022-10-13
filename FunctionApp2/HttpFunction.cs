using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace FunctionApp2
{
    public static class HttpFunction
    {
        [FunctionName("HttpStart")]
        public static string Run([HttpTrigger(AuthorizationLevel.Function, methods: "get", Route = "myfunction")] HttpRequestMessage req, ILogger log)
        {
            return "Hello World!";
        }
    }
}
