using BlazorApp1;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// User data
builder.Services.AddSingleton<IJSInProcessRuntime>(services =>
    (IJSInProcessRuntime)services.GetRequiredService<IJSRuntime>());
builder.Services.AddSingleton<IGlobal, Global>();
builder.Services.AddAntDesign();

// Header Adder
builder.Services.AddTransient<HeaderAdder>();
builder.Services.AddHttpClient("GameServer", client =>
{
    client.BaseAddress = new Uri("http://localhost:11500/");
}).AddHttpMessageHandler<HeaderAdder>();
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>()
    .CreateClient("GameServer"));

builder.Services.AddHttpClient<HiveServer>("HiveServer", client => client.BaseAddress = new Uri("http://localhost:11501/"));
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>()
	.CreateClient("HiveServer"));
await builder.Build().RunAsync();
