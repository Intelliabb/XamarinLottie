using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamLottie.Models
{
    public class TaskItem : INotifyPropertyChanged
    {
        private int _id;
        private string _text;
        private bool _isComplete;

        public int Id { get => _id; set { _id = value; RaisePropertyChanged(); }}
        public string Text { get => _text; set { _text = value; RaisePropertyChanged(); }}
        public bool IsComplete { get => _isComplete; set { _isComplete = value; RaisePropertyChanged(); }}

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
