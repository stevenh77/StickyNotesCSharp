using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace StickyNoteCSharp.Converters
{
    // The purpose of this converter is to give the first item in the list a
    // a different margin from the rest. This avoids some clipping problems.
    public class IndexToMarginValueConverter : DependencyObject, IValueConverter
    {
        public static readonly DependencyProperty ListCountProperty = DependencyProperty.Register("ListCount", typeof(int), typeof(IndexToMarginValueConverter), new PropertyMetadata(default(int)));
        public int ListCount { get { return (int)GetValue(ListCountProperty); } set { SetValue(ListCountProperty, value); } }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var item = default(ListBoxItem);
            var holdInput = (FrameworkElement) value;

            while (item == null)
            {
                holdInput = (FrameworkElement) holdInput.Parent;
                if ((holdInput) is ListBoxItem)
                {
                    item = (ListBoxItem) holdInput;
                    break;
                }

                if (holdInput == null) break;
            }

            if (item == null)
            {
                return new Thickness(20, 3, 20, 0);
            }

            var listBoxToUse = (ListBox) ItemsControl.ItemsControlFromItemContainer(item);
            int itemIndex = listBoxToUse.ItemContainerGenerator.IndexFromContainer(item);

            switch (itemIndex)
            {
                case 0:
                    return new Thickness(20, 10, 20, 0);
                default:
                    return new Thickness(20, 3, 20, 0);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
