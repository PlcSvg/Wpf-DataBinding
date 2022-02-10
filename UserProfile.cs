using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataBinding_wpf
{
    internal class UserProfile : INotifyPropertyChanged
    {
        private string _bidPrice;
        private string _itemName;
        public string BidPrice
        {
            get { return _bidPrice; }
            set { _bidPrice = value; OnChangeProperty("BidPrice"); }
        }

        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; OnChangeProperty("ItemName"); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnChangeProperty(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
