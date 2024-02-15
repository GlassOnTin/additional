using System;
using System.Globalization;
using System.Windows.Data;

namespace Additional
{
    public class CanCalculateToStatusMessageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool canCalculate)
            {
                return canCalculate ? "Ready to calculate" : "Enter both numbers to calculate";
            }
            return "Invalid input";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}