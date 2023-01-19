using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo.MVVM.ViewModels
{
    class CommandsViewModel
    {
        /*
        // Create a Command - Way 1 --START
        public ICommand ClickCommand =>
            new Command(() =>
            App.Current.MainPage.DisplayAlert("Title", "Message", "Ok"));
        // Create a Command - Way 1 --END
        */

        // Create a Command - Way 2 --START
        public ICommand ClickCommand =>
           new Command(Alert);

        private void Alert() {

            App.Current.MainPage.DisplayAlert("Title", "Message", "Ok");

        }
        // Create a Command - Way 2 --END
    }
}
