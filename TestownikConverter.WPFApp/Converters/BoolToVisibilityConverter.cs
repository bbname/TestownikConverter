using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using TestownikConverter.WPFApp.Resources.Exceptions;

namespace TestownikConverter.WPFApp.Converters
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                var _value = (bool)value;

                return _value ? Visibility.Visible : Visibility.Hidden;
            }
            catch (NullReferenceException e)
            {
                throw new BoolToVisibilityConverterNullValueException("The value passed to BoolVisibilityConverter was null.", e);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}