using System;
using System.Globalization;
using Xamarin.Forms;

namespace SlidersTest
{
    public class SliderToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            decimal result;
            if (!decimal.TryParse(value.ToString(), out result))
            {
                return 0;
            }
            else return (int)result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            decimal result;
            var stringValue = value.ToString();

            if (string.IsNullOrWhiteSpace(stringValue))
                return 0;

            if (!decimal.TryParse(stringValue, out result))
            {
                return 0;
            }
            else return Math.Round(result, 1);
        }
    }
}
