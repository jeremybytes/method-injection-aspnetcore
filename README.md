# Method Injection in API Controllers vs MVC Controllers  

## Description  
Method Injection in ASP.NET Core got a little bit easier in .NET 7. Before .NET 7, we had to use the [FromServices] attribute on a method parameter in order for the parameter to be injected from the services collection / dependency injection container. Starting with .NET 7, the [FromServices] parameter became optional, but only in some places.  

Description of the code can be found here:  
[Method Injection in ASP.NET Core: API Controllers vs MVC Controllers](https://jeremybytes.blogspot.com/2024/02/method-injection-in-aspnet-core-api.html)

Other Documentation:  
* Microsoft New in .NET 7: [https://learn.microsoft.com/en-us/aspnet/core/release-notes/aspnetcore-7.0?view=aspnetcore-8.0#api-controllers](https://learn.microsoft.com/en-us/aspnet/core/release-notes/aspnetcore-7.0?view=aspnetcore-8.0#api-controllers)
* Microsoft FromServicesAttribute: [https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.fromservicesattribute?view=aspnetcore-8.0](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.fromservicesattribute?view=aspnetcore-8.0)

---