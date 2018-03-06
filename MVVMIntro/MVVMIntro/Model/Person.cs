using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MVVMIntro.Model
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _fname;
        private string _lname;
        private string _fulName;

        public string FName
        {
            get { return _fname; }
            set {
                _fname = value;
                OnPropertyChanged(_fname);
            }
            
        }

        public string LName
        {
            get { return _lname; }
            set {
                _lname = value;
                OnPropertyChanged(_lname);
            }
        }

        public string FullName
        {
            get { return _fulName = $"{_fname} {_lname}"; }
            set
            {
                if(_fulName != value)
                {
                    _fulName = value;
                }
            }
        }

        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        
    }
}
