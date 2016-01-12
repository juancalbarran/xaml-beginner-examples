using System;
using System.Windows.Input;

namespace CreatingCustomCommands
{
    public class SampleCommand : ICommand
    {
        private readonly Action<string> _execute;

        public event EventHandler CanExecuteChanged;

        public SampleCommand(Action<string> execute)
        {
            this._execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            string parameterString = null;
            if (parameter != null)
            {
                parameterString = parameter.ToString();
            }
            this._execute(parameterString);
        }
    }
}
