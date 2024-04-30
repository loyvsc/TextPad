using System.Windows;
using TextPad.ViewModels;

namespace TextPad.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowViewModel mainWindowViewModel)
        {
            InitializeComponent();
            DataContext = mainWindowViewModel;
            mainWindowViewModel.Notes.Add(new Models.Note() { Text= "123456789123456789123456789123456789123456789123456789" });
        }
    }
}