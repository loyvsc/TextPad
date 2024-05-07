using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TextPad.HostHelpers;
using TextPad.Views;

namespace TextPad;

public partial class App
{
    private readonly IHost _host;
    public App()
    {
        RenderOptions.ProcessRenderMode = RenderMode.Default;
        _host = CreateHostBuilder().Build();
    }

    private static IHostBuilder CreateHostBuilder(string[]? args = null)
    {
        return Host.CreateDefaultBuilder(args)
            .AddSingeltons()
            .AddViewModels();
    }
    
    protected override void OnStartup(StartupEventArgs e)
    {
        _host.Start();
        Window window = _host.Services.GetRequiredService<MainWindow>();
        window.Show();

        base.OnStartup(e);
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        await _host.StopAsync();
        _host.Dispose();

        base.OnExit(e);
    }
}