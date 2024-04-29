using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TextPad.Views;

namespace TextPad.HostHelpers
{
    public static partial class HostHelpers
    {
        public static IHostBuilder AddSingeltons(this IHostBuilder hostBuilder)
        {
            return hostBuilder.ConfigureServices(services =>
            {
                services.AddSingleton<App>();
                services.AddSingleton<MainWindow>();
            }
            );
        }
    }
}
