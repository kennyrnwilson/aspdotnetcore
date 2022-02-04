# Kestrel Standalone
Runs a minimal web server inside Kestrel standlone configuration.


**Kestrel Standalone**

![Kestrel Standalone](./docs/kestrel-standalone.png "Kestrel Standalone")

The key aspects of this setup are **UseKestrel** in the [Program.cs](./Program.cs)

```cs
var host = new WebHostBuilder()
                .UseKestrel()
                .Configure(appBuilder => appBuilder.Run(async ctx =>
                    await ctx.Response.WriteAsync("Hello World")))
                .Build();
```

and the [launchSettings.json](./Properties/launchSettings.json)

```json
{
    "$schema": "http://json.schemastore.org/launchsettings.json",
    "profiles": {
      "KestrelStandalone": {
        "commandName": "Project",
        "launchBrowser": true,
        "environmentVariables": {
          "ASPNETCORE_ENVIRONMENT": "Development"
        },
        "applicationUrl": "https://localhost:5000;http://localhost:5001"
      }
    }
  }
```

# Build, run and connect

To build the application enter the command 

```
dotnet build
```

To run the application enter the command


```
dotnet run --launch-profile KestrelStandalone
```

Finally to connect to the http endpoint [http://localhost:5001](http://localhost:5001)