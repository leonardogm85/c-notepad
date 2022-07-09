using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Notepad.Converter
{
    // Converte um booleano para TextWrapping.Wrap ou TextWrapping.NoWrap
    [ValueConversion(typeof(bool), typeof(TextWrapping))]
    public class BoolToLineWrapConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool b = (bool)value;
            return b ? TextWrapping.Wrap : TextWrapping.NoWrap;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
