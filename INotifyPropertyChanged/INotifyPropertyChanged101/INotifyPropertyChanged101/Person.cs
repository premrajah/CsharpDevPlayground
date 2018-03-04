using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace INotifyPropertyChanged101
{
    public class Person : INotifyPropertyChanged
    {
        private string _firstname;
        private string _lastname;
        private string _fullname;

        public string Firstname
        {
            get { return _firstname; }
            set
            {
                if(_firstname != value)
                {
                    _firstname = value;
                    OnPropertyChanged("Firstname");
                    OnPropertyChanged("Fullname");
                }
            }
        }

        public string Lastname
        {
            get { return _lastname; }
            set
            {
                if (_lastname != value)
                {
                    _lastname = value;
                    OnPropertyChanged("Lastname");
                    OnPropertyChanged("Fullname");
                }
            }
        }

        public string Fullname
        {
            get { return _fullname = $"{_firstname} {_lastname}"; }
            set
            {
                if(_fullname != value)
                {
                    _fullname = value;
                    OnPropertyChanged("Fullname");
                }
            }
        }

        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
