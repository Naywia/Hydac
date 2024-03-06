using Hydac.ViewModels;
using System.Windows.Controls;

namespace Hydac.Views
{
    public partial class ComponentOverviewView : Page
    {
        public ComponentOverviewView()
        {
            InitializeComponent();
            DataContext = new ComponentOverviewViewModel();
        }
    }
}
