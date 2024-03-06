using Hydac.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hydac
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavigateToCustomerOverview(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new CustomerOverviewView());
        }

        private void NavigateToAddCustomer(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new AddCustomerView());
        }

        private void NavigateToComponentOverview(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new ComponentOverviewView());
        }

        private void NavigateToAddComponent(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new AddComponentView());
        }

        private void NavigateToSetServiceInterval(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new UpdateComponentView());
        }
        
    }
}