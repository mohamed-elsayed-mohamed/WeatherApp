﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Linq;

namespace WeatherApp.ViewModel.Commands
{
    public class SearchCommand : ICommand
    {
        private WeatherVM weatherVM { set; get; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public SearchCommand(WeatherVM weatherVM)
        {
            this.weatherVM = weatherVM;
        }

        public bool CanExecute(object parameter)
        {
            string query = parameter as string;

            if (string.IsNullOrWhiteSpace(query))
                return false;
            return true;
        }

        public void Execute(object parameter)
        {
            weatherVM.MakeQuery();
        }
    }
}
