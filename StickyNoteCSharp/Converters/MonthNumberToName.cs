using System;
using System.Globalization;
using System.Windows.Data;

namespace StickyNoteCSharp.Converters
{
    public class MonthNumberToNameValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Based on month number, return first three chars of month name
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName((Int32) value).Substring(0, 3);
        }

        public object ConvertBack(object value,Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
