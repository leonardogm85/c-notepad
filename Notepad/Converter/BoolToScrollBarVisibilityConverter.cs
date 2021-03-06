using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace Notepad.Converter
{
    // Converte um booleano para ScrollBarVisibility.Visible ou ScrollBarVisibility.Disabled
    [ValueConversion(typeof(bool), typeof(ScrollBarVisibility))]
    public class BoolToScrollBarVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool b = (bool)value;
            return b ? ScrollBarVisibility.Visible : ScrollBarVisibility.Disabled;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
