using simple_mvvm_example.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace simple_mvvm_example.ViewModels
{
    public class Presenter : ObservableObject
    {
        private readonly TextConverter textConverter = new TextConverter(s => s.ToUpper());
        private readonly ObservableCollection<string> history = new ObservableCollection<string>();
        private string someText;

        public string SomeText
        {
            get { return someText; }
            set
            {
                someText = value;
                RaisePropertyChangedEvent("SomeText");
            }
        }

        public IEnumerable<string> History
        {
            get { return history; }
        }

        public ICommand ConvertTextCommand
        {
            get { return new DelegateCommand(ConvertText); }
        }

        private void ConvertText()
        {
            if (string.IsNullOrEmpty(SomeText)) return;
            AddToHistory(textConverter.ConvertText(SomeText));
            SomeText = string.Empty;
        }

        private void AddToHistory(string item)
        {
            if (!history.Contains(item))
                history.Add(item);
        }
    }
}
