using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Marvel.WPFApp.Commands
{
    public class RelayCommand<T> : ICommand
    {
        public Action<T> ExecuteAction { get; set; }

        public Func<T, bool> CanExecuteFunction { get; set; }

        public RelayCommand(Action<T> executeAction, Func<T, bool> canExecuteFunction = null)
        {
            if (canExecuteFunction == null)
                canExecuteFunction = (o) => true;
            if (executeAction == null)
                throw new ArgumentNullException(nameof(executeAction));

            ExecuteAction = executeAction;
            CanExecuteFunction = canExecuteFunction;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        #region ICommand implementation
        public bool CanExecute(object parameter)
        {
            return CanExecuteFunction((T)parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            ExecuteAction((T)parameter);
        }
        #endregion
    }
}
