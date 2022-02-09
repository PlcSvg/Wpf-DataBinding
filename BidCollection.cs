using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Timers;

namespace DataBinding_wpf
{
    internal class BidCollection : ObservableCollection<Bid>
    {
        private readonly Bid _item1 = new Bid("Perseus Vase", (decimal)24.95);
        private readonly Bid _item2 = new Bid("Hercules Statue", (decimal)16.05);
        private readonly Bid _item3 = new Bid("Odysseus Painting", (decimal)100.0);
        public BidCollection()
        {
            Add(_item1);
            Add(_item2);
            Add(_item3);
            CreateTimer();
        }
        private void Timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            _item1.Biditemprice += (decimal)1.25;
            _item2.Biditemprice += (decimal)2.45;
            _item3.Biditemprice += (decimal)10.55;
        }

        private void CreateTimer()
        {
            var timer1 = new Timer
            {
                Enabled = true,
                Interval = 2000
            };
            timer1.Elapsed += Timer1_Elapsed;
        }
    }
}
