var host = new WebHostBuilder()
                .UseKestrel()
                .Configure(appBuilder => appBuilder.Run(async ctx =>
                    await ctx.Response.WriteAsync("Hello World")))
                .Build();

host.Run();