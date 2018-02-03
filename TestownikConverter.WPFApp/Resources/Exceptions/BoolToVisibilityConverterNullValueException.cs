using System;

namespace TestownikConverter.WPFApp.Resources.Exceptions
{
    public class BoolToVisibilityConverterNullValueException : Exception
    {
        public BoolToVisibilityConverterNullValueException()
        {
            
        }

        public BoolToVisibilityConverterNullValueException(string message)
            :base(message)
        {
            
        }

        public BoolToVisibilityConverterNullValueException(string message, Exception innerException)
            :base(message, innerException)
        {

        }
    }
}