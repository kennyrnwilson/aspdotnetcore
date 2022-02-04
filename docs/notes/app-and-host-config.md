# Application and Host Configuration
If we want to use environment variables to override host configuration in ASP.NET Core we use the prefix **ASPNETCORE**. So, if we want to set the host configuration option **“Kestrel:Certificates:Default:Password”** we set the environment variable **ASPNETCORE_Kestrel__Certificates__Default__Password**. 

> Note we do not prefix environment variables that are used to override application configuration. So to set
**“Logging:LogLevel:Microsoft”** we set the environment variable **Logging__LogLevel__Microsoft**. 

 Also note that we use **__** rather than **:** when specifying the path separators as : is not supported by all platforms. 