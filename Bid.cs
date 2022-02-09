using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataBinding_wpf
{
    internal class Bid : INotifyPropertyChanged
    {

        private string _biditemname;
        private decimal _biditemprice;

        public Bid(string newBidItemName, decimal newBidItemPrice)
        {
            _biditemname = newBidItemName;
            _biditemprice = newBidItemPrice;
        }

        public string Biditemname
        {
            get { return _biditemname; }
            set { _biditemname = value; OnChangeProperty("Biditemname"); }
        }
        public decimal Biditemprice
        {
            get { return _biditemprice; }
            set { _biditemprice = value; OnChangeProperty("Biditemprice"); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnChangeProperty(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
