using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazored.Modal;
using Blazored.Toast;
using Blazored.Toast.Services;
using WebApp.Services;

namespace WebApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddScoped<IBookService, BookService>();
            builder.Services.AddScoped<IToastService, ToastService>();
            
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5001/") });
            builder.Services.AddBlazoredToast();
            builder.Services.AddBlazoredModal();
            await builder.Build().RunAsync();
        }
    }
}
