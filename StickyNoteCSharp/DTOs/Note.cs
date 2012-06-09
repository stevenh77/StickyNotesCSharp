using System;
using System.ComponentModel;

namespace StickyNoteCSharp.DTOs
{
    public class Note : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        private string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                if (_text == value) return;
                _text = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Text"));
            }
        }

        private DateTime _dateCreated;
        public DateTime DateCreated
        {
            get { return _dateCreated; }
            set
            {
                if (_dateCreated == value) return;
                _dateCreated = value;
                OnPropertyChanged(new PropertyChangedEventArgs("DateCreated"));
            }
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, e);
        }
    }
}
