using System.Collections.ObjectModel;
using XamLottie.Models;

namespace XamLottie.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
            Title = "Xamarin + Lottie = ♥️";
            LoadPage();
        }

        private ObservableCollection<TaskItem> _tasks;
        public ObservableCollection<TaskItem> Tasks
        {
            get { return _tasks; }
            set 
            { 
                _tasks = value; 
                RaisePropertyChanged();
            }
        }

        void LoadPage()
        {
            Tasks = new ObservableCollection<TaskItem> {
                new TaskItem { Id = 1, Text="Finalize sample idea" },
                new TaskItem { Id = 2, Text="Setup GitHub repo" },
                new TaskItem { Id = 3, Text="Get boilerplate code in" },
                new TaskItem { Id = 4, Text="Get Lottie files" },
                new TaskItem { Id = 5, Text="Animate checks" },
                new TaskItem { Id = 6, Text="Animate completion" },
                new TaskItem { Id = 7, Text="Be Awesome ♥️" }
            };
        }
    }
}
