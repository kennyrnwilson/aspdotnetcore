# ASP.NET Core Hosting Models

An ASP.NET Core application contains an in-process HTTP Server which listens for HTTP requests and passes them to the application code as a **HTTPContext** object. All platforms (Linux, MacOS and Windows) ship with Kestrel, which is a high performance, cross platform HTTP Server. If Kestrel is used as the HTTP Server it can either directly serve clients or it can sit behind a reverse proxy such as IIS, NGINX or Apache.

In addition to Kestrel, Windows also ships with two other in-process HTTP servers.
 * IIS Server – in-process server for IIS
 * HTTP.sys server is based on HTTP.sys kernel driver and HTTP Server API

Neither of these two servers work in reverse proxy configuration. 

## Hosting Options 
The following examples describe how to set up the various hosting models

 * [Kestrel Standalone](../examples/hosting-models/kestrel-standalone/README.MD)