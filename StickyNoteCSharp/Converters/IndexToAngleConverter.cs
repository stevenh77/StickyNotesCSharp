using System;
using System.Globalization;
using System.Windows.Data;

namespace StickyNoteCSharp.Converters
{
    public class IndexToAngleConverter : IValueConverter
    {
        private static bool _bReversal;

        private static readonly Random RandomGenerator = new Random(DateTime.Now.Millisecond);

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // I actully don't use the input: I just generate angles randomly.
            // Angles are alternated positive and negative.
            double angleToReturn = 0;
            angleToReturn = RandomGenerator.Next(3, 10);

            if (_bReversal)
            {
                angleToReturn = angleToReturn*-1;
            }
            _bReversal = !_bReversal;

            return angleToReturn;
        }
        
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
