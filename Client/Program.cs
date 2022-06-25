using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SuperBasicWeatherApi;

namespace SuperBasicWeatherApi
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
           

    //        app.UseCors(policy =>
    //policy.WithOrigins("http://localhost:5000", "https://localhost:5001")
    //.AllowAnyMethod()
    //.WithHeaders(HeaderNames.ContentType));

            await builder.Build().RunAsync();
        }
    }
}