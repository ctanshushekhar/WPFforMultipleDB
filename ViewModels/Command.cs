using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFforMultipleDB.ViewModels
{
    public class Command : ICommand
    {
        private readonly Action<object> _action;

        public event EventHandler CanExecuteChanged { add { } remove { } }

        public Command(Action<object> action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _action?.Invoke(parameter);
        }

    }
}
