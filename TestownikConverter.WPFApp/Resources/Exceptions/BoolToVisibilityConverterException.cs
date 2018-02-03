using System;

namespace TestownikConverter.WPFApp.Resources.Exceptions
{
    public class BoolToVisibilityConverterException : Exception
    {
        public BoolToVisibilityConverterException()
        {
            
        }

        public BoolToVisibilityConverterException(string message)
            :base(message)
        {
            
        }

        public BoolToVisibilityConverterException(string message, Exception innerException)
            :base(message, innerException)
        {
            
        }
    }
}