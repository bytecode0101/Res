using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace LoginWindow
{
    public class MyCommand : ICommand
    {
        readonly Action<object> eXecute;
        readonly Predicate<object> canExecute;

       public MyCommand(Action<object> execute)
            : this(execute, null)
        {
        }

            public MyCommand(Action<object> execute, Predicate<object> canEXecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
                eXecute = execute;
                canExecute = canEXecute;
            }

        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object param)
        {
            return canExecute == null ? true : canExecute(param);
        }

        public void Execute(object param)
        {
            eXecute(param);
        }
    }
}
