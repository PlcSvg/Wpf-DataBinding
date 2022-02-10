using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBinding_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UserProfile userProfile = new UserProfile();
            RootEle.DataContext = userProfile;
        }

        public void Preview(object sender, RoutedEventArgs e)
        {
            var be = itemNameTextBox.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();
            be = bidPriceTextBox.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();
        }

        private void Submit(object sender, RoutedEventArgs args)
        {
            //var userProfile = RootEle.DataContext as UserProfile;
            var userProfile = (UserProfile)RootEle.DataContext;
            MessageBox.Show("Thank you for your bid of " + userProfile?.BidPrice
                            + " on item " + userProfile?.ItemName);
            userdata.Opacity = 1;
            Finish.Opacity = 1;
        }
    }
}
