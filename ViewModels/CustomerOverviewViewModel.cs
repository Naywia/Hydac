using Hydac.Models;
using Hydac.Persistence;
using System.Collections.ObjectModel;

namespace Hydac.ViewModels
{
    public class CustomerOverviewViewModel
    {
        #region Fields
        private CustomerRepo customerRepo = new();
        #endregion

        #region Constructors

        #endregion

        #region Methods

        #endregion

        #region Properties
        public ObservableCollection<Customer> Customers { get; set; }
        #endregion
    }
}
