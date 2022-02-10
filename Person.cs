using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataBinding_wpf
{
    public class Person : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _hometown;

        public Person(string firstname, string lastname, string hometown)
        {
            _firstName = firstname;
            _lastName = lastname;
            _hometown = hometown;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; OnChangeProperty("FirstName"); }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; OnChangeProperty("LastName"); }
        }

        public string Hometown
        {
            get { return _hometown; }   
            set { _hometown = value; OnChangeProperty("Hometown"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public override string ToString() => _firstName;
        public void OnChangeProperty(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
