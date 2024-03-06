using Hydac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hydac.ViewModels
{
    public class AddComponentViewModel
    {
        #region Fields
        private ICommand addComponentCommand;
        #endregion

        #region Constructors
        #endregion

        #region Methods
        private void AddComponent()
        {

        }
        #endregion

        #region Properties
        public ICommand AddComponentCommand
        {
            get
            {
                if (addComponentCommand == null)
                    addComponentCommand = new RelayCommand(MethodToRun => AddComponent());
                return addComponentCommand;
            }
        }
        #endregion
    }
}
