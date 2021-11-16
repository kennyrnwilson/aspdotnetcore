# .NET Core Client and Server
This example shows how to wire together a .NET Core WebAPI Server and a .NET core WebAPI Client and using nswag to generate the client API.

## Running the examples 
We have two solutions. First run up the server from Visual Studio using the **Docker** target. Now run the client. For the client use the **client** target. Note we do not use the Docker target for the client as we are using HTTPS and taking default credentials from the windows machine. 

Details on how to configure docker targets is [Container Launch Settings](https://docs.microsoft.com/en-us/visualstudio/containers/container-launch-settings?view=vs-2022)

