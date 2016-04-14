using System;
using System.Globalization;
using Xamarin.Forms;

namespace SlidersTest
{
    public class IntToDoubleConverter : IValueConverter
    {
        public object ConvertBack(object value, Type targetType,
                              object parameter, CultureInfo culture)
        {
            string strParam = parameter as string;
            double multiplier = 1;

            if (!String.IsNullOrEmpty(strParam))
            {
                Double.TryParse(strParam, out multiplier);
            }

            return (int)Math.Round((double)value * multiplier);
        }

        public object Convert(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            string strParam = parameter as string;
            double divider = 1;

            if (!String.IsNullOrEmpty(strParam))
            {
                Double.TryParse(strParam, out divider);
            }

            int result = 0;
            int.TryParse(value.ToString(), out result);

            return Math.Round((double)result / divider, 3);
        }
    }
}
