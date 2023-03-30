using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TesteVTBSolutionsUm;
using TesteVTBSolutionsUm.Services;
using TesteVTBSolutionsUm.Services.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddIgniteUIBlazor();

builder.Services.AddScoped<IOportunidadesService, OportunidadesService>();

await builder.Build().RunAsync();
