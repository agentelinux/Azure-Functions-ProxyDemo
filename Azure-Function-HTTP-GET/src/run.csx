using System.Net;
using Newtonsoft.Json;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, string id, TraceWriter log)
{
    log.Info("C# HTTP trigger function processed a request.");
    
    Person _record = new Person{
        id = id,
        firstname = "Demo",
        lastname = "GET",
        email = "itworks@serversncode.com"
    };
 
    return req.CreateResponse(HttpStatusCode.OK, _record);
}

public class Person{
    public string id { get; set; }
    public string firstname {get;set;}
    public string lastname {get;set;}
    public string email {get;set;}
}

