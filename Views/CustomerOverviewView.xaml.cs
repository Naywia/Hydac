using Hydac.ViewModels;
using System.Windows.Controls;

namespace Hydac.Views
{
    public partial class CustomerOverviewView : Page
    {
        public CustomerOverviewView()
        {
            InitializeComponent();
            DataContext = new CustomerOverviewViewModel();
        }
    }
}
