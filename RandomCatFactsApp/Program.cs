using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RandomCatFactsApp.Controller;
using RandomCatFactsApp.Services;

var builder = Host.CreateApplicationBuilder(args);
builder.Configuration.AddJsonFile("Configuration/appsettings.json");
builder.Services.AddHttpClient<IApiService,ApiService>();
builder.Services.AddScoped<FileTxtSaver>();

var host = builder.Build();
var fileTxtSaver = host.Services.GetRequiredService<FileTxtSaver>();
await fileTxtSaver.SaveToFileAsync();
