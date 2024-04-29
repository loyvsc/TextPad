using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TextPad.ViewModels;

namespace TextPad.HostHelpers
{
    public static partial class HostHelpers
    {
        public static IHostBuilder AddViewModels(this IHostBuilder hostBuilder)
        {
            return hostBuilder.ConfigureServices(services =>
            {
                services.AddSingleton<MainWindowViewModel>();
            }
            );
        }
    }
}
