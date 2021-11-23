# Service to Service HTTP
This simple example shows how to connect one .NET core service to another using HTTP. The front service is just a router which routes requests to the API. 

![Server-Server HTTP](/docs/images/server-server-http.png)

The sample consists of two solutions that run up the two processes

* api
* router 


Open each in visual studio and run up them up. The code in the router that initializes the HTTPClient is as follows

```csharp
builder.Services.AddHttpClient<IServiceClient, ServiceClient>(client =>
{
    client.BaseAddress = new Uri("http://localhost:8600");
});

```

And the ServiceClient.cs looks like this 

[ServiceClient.cs](./router/ServiceClient.cs)

We simply inject the service client into the controller and use it

[HelloController.cs](./router/Controllers/HelloController.cs)

