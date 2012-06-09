
using System;
using System.Windows;
using System.Windows.Controls;

namespace StickyNoteCSharp.Controls
{
    public class Note : Control
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof (string), typeof (Note), new PropertyMetadata(default(string)));
        public string Text { get { return (string) GetValue(TextProperty); } set { SetValue(TextProperty, value); } }

        public static readonly DependencyProperty DateCreatedProperty = DependencyProperty.Register("DateCreated", typeof (DateTime), typeof (Note), new PropertyMetadata(default(DateTime)));
        public DateTime DateCreated { get { return (DateTime) GetValue(DateCreatedProperty); } set { SetValue(DateCreatedProperty, value); } }
    }
}
