using Hydac.Models;
using Hydac.Persistence;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Hydac.ViewModels
{
    public class AddCustomerViewModel
    {
        #region Fields
        private ICommand addCustomerCommand;
        private CustomerRepo customerRepo = App.CustomerRepo;
        #endregion

        #region Constructors
        #endregion

        #region Methods
        private void AddCustomer()
        {
            if (Name != null && Contact != null)
            {
                if (Name != "" && Contact != "" && PhoneNumber.ToString().Length == 8)
                {
                    customerRepo.AddItem(new Customer(Name, Contact, PhoneNumber));
                    Name = "";
                    Contact = "";
                    PhoneNumber = 0;
                }
            }
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

        public string Name { get; set; }
        public string Contact { get; set; }
        public int PhoneNumber { get; set; }
        #endregion
    }
}
