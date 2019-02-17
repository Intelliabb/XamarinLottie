using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamLottie.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private string _title;

        public string Title 
        { 
            get => _title;
            set
            {
                _title = value;
                RaisePropertyChanged();
            }
        }

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
