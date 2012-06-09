using StickyNoteCSharp.ViewModels;

namespace StickyNoteCSharp
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = new MainPageViewModel();
        }
    }
}