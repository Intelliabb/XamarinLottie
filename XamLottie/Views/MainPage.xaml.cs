using System.Linq;
using Xamarin.Forms;
using XamLottie.ViewModels;

namespace XamLottie.Views
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel _vm;
        public MainPage()
        {
            InitializeComponent();
            SetBindingContext();
        }

        async void Done_Tapped(object sender, System.EventArgs e)
        {
            await MainFrame.FadeTo(.5);
            PopupFrame.IsVisible = true;
            DoneAnimation.Play();
        }

        void All_Tapped(object sender, System.EventArgs e)
        {
            foreach (var task in _vm.Tasks.Where(t => !t.IsComplete))
                task.IsComplete = true;
        }

        async void Ok_Tapped(object sender, System.EventArgs e)
        {
            await MainFrame.FadeTo(1);
            PopupFrame.IsVisible = false;
            SetBindingContext();
        }

        void SetBindingContext()
        {
            _vm = new MainPageViewModel();
            BindingContext = _vm;
        }
    }
}
