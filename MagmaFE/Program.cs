using Blazored.LocalStorage;
using RefreshApiClient;
using MagmaFE;
using MagmaFE.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new RefreshClientService(new Uri("https://lbp.littlebigrefresh.com")));
builder.Services.AddSingleton<LoadingService>();
builder.Logging.SetMinimumLevel(LogLevel.Debug);

await builder.Build().RunAsync();