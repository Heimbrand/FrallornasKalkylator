using Common;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

//builder.Services.AddSingleton<CalcService>();
//builder.Services.AddSingleton<CalcHistoryService>();

builder.Services.AddMudServices();

await builder.Build().RunAsync();