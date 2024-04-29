using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TextPad.HostHelpers;

namespace TextPad
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            var host = Host.CreateDefaultBuilder()
                .AddSingeltons()
                .AddViewModels()
                .Build();

            var app = host.Services.GetService<App>();            

            app?.Run();
        }
    }
}
