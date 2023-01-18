using MVVMDemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public Person Person { get; set; }
        public string Test { get; set; }

        public PersonViewModel() {

            Test = $"Custom format of Date:\n {new DateTime(2000, 08, 05).ToString("yyyy-MM-dd")}";          

            Person = new Person
            {
                Name = "Hector",
                Age = 30,
                Married = true,
                BirthDate = new DateTime(2000, 08, 05),               
                Weight = 70,
                Lunchtime = new TimeSpan(10,0,0)
            };

        }
    }
}
