using Common;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);


await builder.Build().RunAsync();
builder.Services.AddSingleton<CalcService>();
builder.Services.AddSingleton< CalcHistoryService>();