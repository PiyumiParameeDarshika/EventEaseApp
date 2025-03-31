using EventEaseApp;
using EventEaseApp.Services; // Add this using directive
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register HttpClient
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register UserSessionService for state management
builder.Services.AddSingleton<UserSessionService>(); // Add this line to register the service

await builder.Build().RunAsync();
