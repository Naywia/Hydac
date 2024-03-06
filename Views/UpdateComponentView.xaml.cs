using Hydac.ViewModels;
using System.Windows.Controls;

namespace Hydac.Views
{
    public partial class UpdateComponentView : Page
    {
        public UpdateComponentView()
        {
            InitializeComponent();
            DataContext = new UpdateComponentViewModel();
        }
    }
}
