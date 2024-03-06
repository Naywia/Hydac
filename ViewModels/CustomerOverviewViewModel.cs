using Hydac.Models;
using Hydac.Persistence;
using System.Collections.ObjectModel;

namespace Hydac.ViewModels
{
    public class CustomerOverviewViewModel
    {
        #region Fields
        private CustomerRepo customerRepo = App.CustomerRepo;
        #endregion

        #region Constructors
        public CustomerOverviewViewModel() {
            Customers = customerRepo.GetItems();
        }
        #endregion

        #region Methods

        #endregion

        #region Properties
        public ObservableCollection<Customer> Customers { get; set; }
        #endregion
    }
}
