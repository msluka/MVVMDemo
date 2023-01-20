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

        /*
        // Create a Command - Way 2 --START
        public ICommand ClickCommand =>
           new Command(Alert);

        private void Alert() {

            App.Current.MainPage.DisplayAlert("Title", "Message", "Ok");

        }
        // Create a Command - Way 2 --END
        */

        /*
        // Create a Command - Way 3 --START
        public ICommand ClickCommand { get; }

        public CommandsViewModel()
        {

            ClickCommand = new Command(() =>
            {
                App.Current.MainPage.DisplayAlert("Title", "Message", "Ok");

            });

        }
        // Create a Command - Way 3 --END
        */

        /*
        // Passing parameters to a Command - Way 1 --START 
        public ICommand SearchCommand { get; }
        public string SearchTerm { get; set; }

        public CommandsViewModel()
        {            

            SearchCommand = new Command((s) =>
            {
                var data = SearchTerm;
                App.Current.MainPage.DisplayAlert("Title", data, "Ok");

            });

        }
        // Passing parameters to a Command - Way 1 --END
        */

        // Passing parameters to a Command - Way 2 --START 
        public ICommand SearchCommand { get; }     

        public CommandsViewModel()
        {

            SearchCommand = new Command((s) =>
            {
                var data = s;
                App.Current.MainPage.DisplayAlert("Title", data.ToString(), "Ok");

            });

        }
        // Passing parameters to a Command - Way 2 --END



    }

}
