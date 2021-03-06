using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UI.Brokers.Logging;
using UI.Brokers.API;
using UI.Services;
using UI.ViewModels;

namespace UI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration.GetValue<string>("ApiBaseURL")) });

            builder.Services.AddScoped<ILogger,Logger<LoggingBroker>>();
            builder.Services.AddScoped<ILoggingBroker,LoggingBroker>();
            builder.Logging.AddConfiguration(builder.Configuration.GetSection("Logging"));
            builder.Services.AddScoped<IApiBroker,ApiBroker>();
            builder.Services.AddTransient<IProductService,ProductService>();
            builder.Services.AddTransient<IProductSubcategoryService, ProductSubcategoryService>();
            builder.Services.AddTransient<IProductListView,ProductListView>();

            await builder.Build().RunAsync();
        }
    }
}
