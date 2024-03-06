using Hydac.ViewModels;
using System.Windows.Controls;

namespace Hydac.Views
{
    public partial class AddCustomerView : Page
    {
        public AddCustomerView()
        {
            InitializeComponent();
            DataContext = new AddCustomerViewModel();
        }
    }
}
