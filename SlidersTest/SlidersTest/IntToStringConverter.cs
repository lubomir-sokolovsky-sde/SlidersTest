using System;
using System.Globalization;
using Xamarin.Forms;

namespace SlidersTest
{
    public class IntToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double temp;
            if (!double.TryParse(value.ToString(), out temp))
            {
                return 0;
            }
            else return ((int)temp).ToString();
            //int result;
            //if (!int.TryParse(value.ToString(), out result))
            //{
            //    return 0;
            //}
            //else return result.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int result;
            var stringValue = value.ToString();

            if (string.IsNullOrWhiteSpace(stringValue))
                return 0;

            if (!int.TryParse(stringValue, out result))
            {
                return 0;
            }
            else return result;
        }
    }
}
