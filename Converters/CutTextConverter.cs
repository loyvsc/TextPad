using System.Windows;
using System.Windows.Data;

namespace TextPad.Converters
{
    public class CutTextConverter : IValueConverter
    {
        public const int MaxTextLength = 50;
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is string text)
            {
                if (text.Length > MaxTextLength)
                {
                    return text.Substring(0, MaxTextLength) + "...";
                }
                else
                {
                    return text;
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) => DependencyProperty.UnsetValue;
    }
}
