using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using nmayes.dev.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.Configure<ProjectLinksOptions>(
    builder.Configuration.GetSection("ProjectLinks"));

await builder.Build().RunAsync();
