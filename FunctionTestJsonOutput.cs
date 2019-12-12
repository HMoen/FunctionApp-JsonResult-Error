namespace FunctionAppJsonError
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.Http;
    using Microsoft.Extensions.Logging;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public static class FunctionTestJsonOutput
    {
        [FunctionName("FunctionTestJsonOutput")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            var foo = new Foo("Has value");
            var settings = new JsonSerializerSettings()
                               {
                                   NullValueHandling = NullValueHandling.Ignore
                               };
            return new JsonResult(foo, settings);
        }

        public enum Status
        {
            Pending,

            Completed
        }

        public class Foo
        {
            public Foo(string withValue)
            {
                this.WithValue = withValue;
            }

            [JsonConverter(typeof(StringEnumConverter))]
            public Status Status { get; set; }

            public string WithValue { get; set; }

            public string NullValue { get; set; }
        }
    }
}
