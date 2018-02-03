using System;
using System.Globalization;
using NUnit.Framework;
using System.Windows;
using System.Windows.Media.Media3D;
using TestownikConverter.WPFApp.Converters;
using TestownikConverter.WPFApp.Resources.Exceptions;

namespace TestownikConverter.WPFApp.Tests.Converters.Tests
{
    [TestFixture]
    public class BoolToVisibilityConverterTest
    {

        [TestCase(true, null, null, Visibility.Visible)]
        [TestCase(false, null, null, Visibility.Hidden)]
        [TestCase(true, typeof(Visibility), null, Visibility.Visible)]
        [TestCase(false, typeof(Visibility), null, Visibility.Hidden)]
        public void Convert_Arrange_Value_TargetType_Parameter_CultureInfoIsCurrentCulture_ExpectedVisibility(bool arrangedValue,
            Type arrangedTargetType, object arrangedParameter, Visibility expectedVisibility)
        {
            var btvConverter = new BoolToVisibilityConverter();
            var actualVisibility = btvConverter.Convert(arrangedValue,
                arrangedTargetType, arrangedParameter, CultureInfo.CurrentCulture);

            Assert.AreEqual(expectedVisibility, actualVisibility);
        }

        [TestCase(true, null, null, Visibility.Visible)]
        [TestCase(false, null, null, Visibility.Hidden)]
        [TestCase(true, typeof(Visibility), null, Visibility.Visible)]
        [TestCase(false, typeof(Visibility), null, Visibility.Hidden)]
        public void Convert_Arrange_Value_TargetType_Parameter_CultureInfoIsNull_ExpectedVisibility(bool arrangedValue,
            Type arrangedTargetType, object arrangedParameter, Visibility expectedVisibility)
        {
            var btvConverter = new BoolToVisibilityConverter();
            var actualVisibility = btvConverter.Convert(arrangedValue,
                arrangedTargetType, arrangedParameter, null);

            Assert.AreEqual(expectedVisibility, actualVisibility);
        }

        [TestCase(null, null, null)]
        [TestCase(null, typeof(Visibility), null)]
        public void Convert_Arrange_Value_TargetType_Parameter_CultureInfoIsCurrentCulture_ExpectedBoolToVisibilityConverterNullValueExceptionThrown(bool? arrangedValue,
            Type arrangedTargetType, object arrangedParameter)
        {
            var btvConverter = new BoolToVisibilityConverter();

            Assert.Throws<BoolToVisibilityConverterNullValueException>(() => btvConverter.Convert(arrangedValue,
                arrangedTargetType, arrangedParameter, CultureInfo.CurrentCulture));
        }

        [TestCase(null, null, null)]
        [TestCase(null, typeof(Visibility), null)]
        public void Convert_Arrange_Value_TargetType_Parameter_CultureInfoIsNull_ExpectedBoolToVisibilityConverterNullValueExceptionThrown(bool? arrangedValue,
            Type arrangedTargetType, object arrangedParameter)
        {
            var btvConverter = new BoolToVisibilityConverter();

            Assert.Throws<BoolToVisibilityConverterNullValueException>(() => btvConverter.Convert(arrangedValue,
                arrangedTargetType, arrangedParameter, CultureInfo.CurrentCulture));
        }

        [TestCase(Visibility.Visible, null, null, true)]
        [TestCase(Visibility.Hidden, null, null, false)]
        [TestCase(Visibility.Visible, typeof(Visibility), null, true)]
        [TestCase(Visibility.Hidden, typeof(Visibility), null, false)]
        public void ConvertBack_Arrange_Value_TargetType_Parameter_CultureInfoIsCurrentCulture_ExpectedBool(Visibility arrangedValue,
            Type arrangedTargetType, object arrangedParameter, bool expectedBool)
        {
            var btvConverter = new BoolToVisibilityConverter();
            var actualBool = btvConverter.ConvertBack(arrangedValue,
                arrangedTargetType, arrangedParameter, CultureInfo.CurrentCulture);

            Assert.AreEqual(expectedBool, actualBool);
        }

        [TestCase(Visibility.Visible, null, null, true)]
        [TestCase(Visibility.Hidden, null, null, false)]
        [TestCase(Visibility.Visible, typeof(Visibility), null, true)]
        [TestCase(Visibility.Hidden, typeof(Visibility), null, false)]
        public void ConvertBack_Arrange_Value_TargetType_Parameter_CultureInfoIsNull_ExpectedBool(Visibility arrangedValue,
            Type arrangedTargetType, object arrangedParameter, bool expectedBool)
        {
            var btvConverter = new BoolToVisibilityConverter();
            var actualBool = btvConverter.ConvertBack(arrangedValue,
                arrangedTargetType, arrangedParameter, null);

            Assert.AreEqual(expectedBool, actualBool);
        }

        [TestCase(null, null, null)]
        [TestCase(null, typeof(Visibility), null)]
        public void ConvertBack_Arrange_Value_TargetType_Parameter_CultureInfoIsCurrentCulture_ExpectedBoolToVisibilityConverterNullValueExceptionThrown(Visibility? arrangedValue,
            Type arrangedTargetType, object arrangedParameter)
        {
            var btvConverter = new BoolToVisibilityConverter();

            Assert.Throws<BoolToVisibilityConverterNullValueException>(() => btvConverter.ConvertBack(arrangedValue,
                arrangedTargetType, arrangedParameter, CultureInfo.CurrentCulture));
        }

        [TestCase(null, null, null)]
        [TestCase(null, typeof(Visibility), null)]
        public void ConvertBack_Arrange_Value_TargetType_Parameter_CultureInfoIsNull_ExpectedBoolToVisibilityConverterNullValueExceptionThrown(Visibility? arrangedValue,
            Type arrangedTargetType, object arrangedParameter)
        {
            var btvConverter = new BoolToVisibilityConverter();

            Assert.Throws<BoolToVisibilityConverterNullValueException>(() => btvConverter.ConvertBack(arrangedValue,
                arrangedTargetType, arrangedParameter, CultureInfo.CurrentCulture));
        }

    }
}