using Hydac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hydac.ViewModels
{
    public class UpdateComponentViewModel
    {
        #region Fields
        private ICommand updateServiceIntervalCommand;
        #endregion

        #region Constructors
        #endregion

        #region Methods
        private void UpdateServiceInterval()
        {

        }
        #endregion

        #region Properties
        public Component Component { get; set; }

        public ICommand UpdateServiceIntervalCommand
        {
            get
            {
                if (updateServiceIntervalCommand == null)
                    updateServiceIntervalCommand = new RelayCommand(MethodToRun => UpdateServiceInterval());
                return updateServiceIntervalCommand;
            }
        }
        #endregion
    }
}
