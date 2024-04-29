using System.Collections.ObjectModel;
using TextPad.Models;

namespace TextPad.ViewModels
{
    public class MainWindowViewModel : NotifyPropertyChangedBase
    {
        #region Propertys
        public ObservableCollection<Note> Notes { get; set; } = new ObservableCollection<Note>();
        #endregion

        public MainWindowViewModel()
        {

        }
    }
}
