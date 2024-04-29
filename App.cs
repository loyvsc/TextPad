using System.Windows;
using TextPad.Views;

namespace TextPad
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        readonly MainWindow mainWindow;

        public App(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            mainWindow.Show();
            base.OnStartup(e);
        }
    }
}
