YARP is designed as a library that provides the core proxy functionality, which you can customize by adding or replacing modules. YARP is currently provided as a NuGet package and code samples. We plan on providing a project template and prebuilt executable (.exe) in the future.
Add the YARP Middleware
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));
var app = builder.Build();
app.MapReverseProxy();
app.Run();
Configuration
{
 "Logging": {
   "LogLevel": {
     "Default": "Information",
     "Microsoft": "Warning",
     "Microsoft.Hosting.Lifetime": "Information"
   }
 },
 "AllowedHosts": "*",
 "ReverseProxy": {
   "Routes": {
     "route1" : {
       "ClusterId": "cluster1",
       "Match": {
         "Path": "{**catch-all}"
       }
     }
   },
   "Clusters": {
     "cluster1": {
       "Destinations": {
         "destination1": {
           "Address": "https://example.com/"
         }
       }
     }
   }
 }
}
