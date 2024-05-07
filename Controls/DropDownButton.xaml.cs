using System.Collections;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace TextPad.Controls;

public partial class DropdownButton : UserControl
{
    public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register(
        nameof(Header), typeof(string), typeof(DropdownButton), new PropertyMetadata(default(string)));
    
    public string Header
    {
        get => (string)GetValue(HeaderProperty);
        set => SetValue(HeaderProperty, value);
    }

    public static readonly DependencyProperty DropDownButtonItemsProperty = DependencyProperty.Register(
        nameof(DropDownButtonItems), typeof(ObservableCollection<DropDownButtonItem>), typeof(DropdownButton), new PropertyMetadata(new ObservableCollection<DropDownButtonItem>()));
    
    public ObservableCollection<DropDownButtonItem> DropDownButtonItems
    {
        get => (ObservableCollection<DropDownButtonItem>)GetValue(DropDownButtonItemsProperty);
        set => SetValue(DropDownButtonItemsProperty, value);
    }
    
    public DropdownButton()
    {
        InitializeComponent();
    }
}