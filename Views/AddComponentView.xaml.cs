using Hydac.ViewModels;
using System.Windows.Controls;

namespace Hydac.Views
{
    public partial class AddComponentView : Page
    {
        public AddComponentView()
        {
            InitializeComponent();
            DataContext = new AddComponentViewModel();
        }
    }
}
