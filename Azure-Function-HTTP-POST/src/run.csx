using System.Net;
using Newtonsoft.Json;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info("C# HTTP trigger function processed a request.");
    
    dynamic body = await req.Content.ReadAsStringAsync();
    var e = JsonConvert.DeserializeObject<Person>(body as string);
 
    int iID = 1523;


    return req.CreateResponse(HttpStatusCode.OK, iID);
}

public class Person{
    public string id { get; set; }    
    public string firstname {get;set;}
    public string lastname {get;set;}
    public string email {get;set;}
}

