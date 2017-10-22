Azure Functions HTTP Get Demo

In the function.json 
    - authLevel to "anonymous"
    - route httpdemoget/{id}

Our function will now expect the id as a parameter in the route after httpdemoget. 

Our Function binding will look like this

    "bindings": [
      {
        "authLevel": "anonymous",
        "name": "req",
        "type": "httpTrigger",
        "direction": "in",
        "route": "httpdemoget/{id}"
      },


In our function we then have to add a parameter of id


public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, string id, TraceWriter log)


See https://serversncode.com/ for more information