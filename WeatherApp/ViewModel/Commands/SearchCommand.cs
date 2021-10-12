using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WeatherApp.ViewModel.Commands
{
    public class SearchCommand : ICommand
    {
        private WeatherVM weatherVM { set; get; }

        public event EventHandler CanExecuteChanged;

        public SearchCommand(WeatherVM weatherVM)
        {
            this.weatherVM = weatherVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            weatherVM.MakeQuery();
        }
    }
}
