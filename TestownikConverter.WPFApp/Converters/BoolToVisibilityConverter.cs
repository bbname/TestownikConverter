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
                var boolValue = (bool)value;

                return boolValue ? Visibility.Visible : Visibility.Hidden;
            }
            catch (NullReferenceException e)
            {
                throw new BoolToVisibilityConverterNullValueException("The value passed to BoolVisibilityConverter was null.", e);
            }
            catch (Exception e)
            {
                throw new BoolToVisibilityConverterException("Unexpected exception in BoolToVisibilityConverter.", e);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                var visibilityValue = (Visibility)value;

                return visibilityValue == Visibility.Visible;
            }
            catch (NullReferenceException e)
            {
                throw new BoolToVisibilityConverterNullValueException("The value passed to BoolVisibilityConverter was null.", e);
            }
            catch (Exception e)
            {
                throw new BoolToVisibilityConverterException("Unexpected exception in BoolToVisibilityConverter.", e);
            }
        }
    }
}