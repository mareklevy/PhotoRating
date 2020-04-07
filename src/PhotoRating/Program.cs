﻿using System.Threading.Tasks;

using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace PhotoRating
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services
                .AddBlazorise(options =>
                  {
                      options.ChangeTextOnKeyPress = true;
                  })
                  .AddBootstrapProviders()
                  .AddFontAwesomeIcons();

            builder.RootComponents.Add<App>("app");

            builder.Services.AddBaseAddressHttpClient();

            var host = builder.Build();

            host.Services
              .UseBootstrapProviders()
              .UseFontAwesomeIcons();

            await host.RunAsync();
        }
    }
}
