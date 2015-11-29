using System;
using System.Windows.Input;

namespace TestApp1.Mvvm
{
    class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        
        private Action<object> _execute;
        private Func<object, bool> _canExecute = _ => true;

        public DelegateCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            if (canExecute != null)
            { _canExecute = canExecute; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            _execute?.Invoke(parameter);
        }
        public void RaiseCanExecutreChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
