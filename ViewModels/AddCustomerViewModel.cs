using Hydac.Models;
using System.Windows.Input;

namespace Hydac.ViewModels
{
    public class AddCustomerViewModel
    {
        #region Fields
        private ICommand addCustomerCommand;
        #endregion

        #region Constructors
        #endregion

        #region Methods
        private void AddCustomer()
        {

        }
        #endregion

        #region Properties
        public ICommand AddCustomerCommand
        {
            get
            {
                if (addCustomerCommand == null)
                    addCustomerCommand = new RelayCommand(MethodToRun => AddCustomer());
                return addCustomerCommand;
            }
        }
        #endregion
    }
}
