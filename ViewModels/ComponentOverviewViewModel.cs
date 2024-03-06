using Hydac.Models;
using Hydac.Persistence;
using System.Collections.ObjectModel;

namespace Hydac.ViewModels
{
    public class ComponentOverviewViewModel
    {
        #region Fields
        private ComponentRepo componentRepo = App.ComponentRepo;
        #endregion

        #region Constructors
        public ComponentOverviewViewModel()
        {
            Components = componentRepo.GetItems();
        }
        #endregion

        #region Methods

        #endregion

        #region Properties
        public ObservableCollection<Component> Components { get; set; }
        #endregion
    }
}
