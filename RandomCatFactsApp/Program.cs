using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);
builder.Configuration.AddJsonFile("Configuration/appsettings.json");
builder.Services.AddHttpClient();

var host = builder.Build();
await host.RunAsync();