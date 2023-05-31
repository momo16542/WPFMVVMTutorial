using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFMVVMTutorial
{
    public class BaseCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public bool CanExecute(object parameter)
        {
            bool result = true;
            if (CanExecuteAction != null)
            {
                result = CanExecuteAction.Invoke();
            }
            return result;
        }
        public void Execute(object parameter)
        {
            if (haveParameter)
            {
                ExecuteActionWithParameter(parameter);
            }
            else
            {
                ExecuteAction();
            }
        }
        private Action ExecuteAction;
        private Action<object> ExecuteActionWithParameter;
        private Func<bool> CanExecuteAction;

        private readonly bool haveParameter = false;
        public BaseCommand(Action executeAction)
        {
            this.ExecuteAction = executeAction;
        }
        public BaseCommand(Action<object> executeAction)
        {
            this.ExecuteActionWithParameter = executeAction;
            haveParameter = true;
        }
        public BaseCommand(Action<object> executeAction, Func<bool> canExecuteAction)
        {
            this.ExecuteActionWithParameter = executeAction;
            this.CanExecuteAction = canExecuteAction;
            haveParameter = true;
        }
        public BaseCommand(Action executeAction, Func<bool> canExecuteAction)
        {
            this.ExecuteAction = executeAction;
            this.CanExecuteAction = canExecuteAction;
        }
    }
}
