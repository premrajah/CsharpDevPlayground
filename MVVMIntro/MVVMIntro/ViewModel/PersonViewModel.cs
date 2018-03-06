using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using MVVMIntro.Model;

namespace MVVMIntro.ViewModel
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Person _person;
        private ObservableCollection<Person> _persons;

        public Person Person
        {
            get { return _person; }
            set
            {
                _person = value;
                NotifyPropertyChanged("Person");
            }
        }

        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
            set {
                _persons = value;
                NotifyPropertyChanged("Persons");
            }
        }





        private void NotifyPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
