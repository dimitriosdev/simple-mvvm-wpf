using System.ComponentModel;

namespace simple_mvvm_example.ViewModels
{
    public abstract class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            //var handler = PropertyChanged;
            //if (handler != null)
            //    handler(this, new PropertyChangedEventArgs(propertyName));
            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
