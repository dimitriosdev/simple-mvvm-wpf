using System;
using System.Windows.Input;

namespace simple_mvvm_example.ViewModels
{
    public class DelegateCommand : ICommand
    {
        private readonly Action action;

        public DelegateCommand(Action action)
        {
            this.action = action;
        }

        
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action();
        }

        #pragma warning disable
        public event EventHandler CanExecuteChanged;
        #pragma warning disable
    }
}
