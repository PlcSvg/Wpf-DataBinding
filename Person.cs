using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataBinding_wpf
{
    internal class Person : INotifyPropertyChanged
    {
        private string name;
        public string PersonName { get { return name; } set { name = value; OnChangeProperty("PersonName"); } }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnChangeProperty(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
