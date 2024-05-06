using System.Collections.ObjectModel;
using TextPad.Models;

namespace TextPad.ViewModels
{
    public class MainWindowViewModel : NotifyPropertyChangedBase
    {
        #region Propertys
        public ObservableCollection<Note> Notes { get; set; } = [];
        #endregion

        public MainWindowViewModel()
        {
            Notes.Add(new Note() { Text= "123456789123456789123456789123456789123456789123456789" });
        }
    }
}
