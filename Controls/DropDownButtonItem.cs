using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace TextPad.Controls;

public class DropDownButtonItem
{
    public DrawingImage? Icon { get; set; } = Application.Current.Resources["AddImage"] as DrawingImage;
    public string? Text { get; set; }
    public ICommand? OnClick { get; set; }
}