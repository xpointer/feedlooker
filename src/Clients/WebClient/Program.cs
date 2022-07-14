using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FeedLooker.WebClient;

var builder = WebAssemblyHostBuilder.CreateDefault();
builder.RootComponents.Add<App>("#app");

var host = builder.Build();
await host.RunAsync();