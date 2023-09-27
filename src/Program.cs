using Apipedia;
using Apipedia.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using MudExtensions.Services;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        ConfigureServices(builder);

        await builder.Build().RunAsync();
    }

    private static void ConfigureServices(WebAssemblyHostBuilder builder)
    {
        builder.Services.AddLocalization();
        builder.Services.AddMudServices(config =>
        {
        });
        builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
        builder.Services.AddSingleton<DefinitionService>();
        builder.Services.AddMudExtensions();

    }

}
