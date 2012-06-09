
using System;
using System.Collections.ObjectModel;
using StickyNoteCSharp.DTOs;

namespace StickyNoteCSharp.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<Note> Notes { get; set; }
        
        public MainPageViewModel()
        {
            Notes = new ObservableCollection<Note>
                        {
                            new Note() { DateCreated = DateTime.Now.AddDays(-8), Text = "This is where you can store text."},
                            new Note() { DateCreated = DateTime.Now.AddDays(-3), Text = "You can layout your sticky note in any format you like."},
                            new Note() { DateCreated = DateTime.Now, Text = "You could also extend it to include photos, videos or hyperlinks."},
                            new Note() { DateCreated = DateTime.Now, Text = "Another enhancement could be moving the note out of the stack panel onto a data form."},
                        };
        }
    }
}
