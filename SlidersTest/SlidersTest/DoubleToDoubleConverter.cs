using System;
using System.Globalization;
using Xamarin.Forms;

namespace SlidersTest
{
    public class DoubleToDoubleConverter : IValueConverter
    {
        public object ConvertBack(object value, Type targetType,
                              object parameter, CultureInfo culture)
        {
            string strParam = parameter.ToString();
            double multiplier = 1;

            if (!String.IsNullOrEmpty(strParam))
            {
                Double.TryParse(strParam, out multiplier);
            }

            double result = 0;
            double.TryParse(value.ToString(), out result);

            return result * multiplier;
        }

        public object Convert(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            string strParam = parameter.ToString();
            double divider = 1;

            if (!String.IsNullOrEmpty(strParam))
            {
                Double.TryParse(strParam, out divider);
            }

            double result = 0;
            double.TryParse(value.ToString(), out result);

            return result / divider;
        }
    }
}
