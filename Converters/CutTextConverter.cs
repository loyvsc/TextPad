using System.Windows;
using System.Windows.Data;

namespace TextPad.Converters
{
    public class CutTextConverter : IValueConverter
    {
        private const int MaxTextLength = 50;
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is string text)
            {
                return text.Length > MaxTextLength ? text.Substring(0, MaxTextLength) + "..." : text;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) => DependencyProperty.UnsetValue;
    }
}
