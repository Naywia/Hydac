using Hydac.Models;
using Hydac.Persistence;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace Hydac.ViewModels
{
    public class UpdateComponentViewModel : ObservableObject
    {
        #region Fields
        private ComponentRepo componentRepo = App.ComponentRepo;
        private ICommand updateServiceIntervalCommand;
        public ObservableCollection<Component> Components { get; set; }
        #endregion

        #region Constructors
        public UpdateComponentViewModel()
        {
            Components = componentRepo.GetItems();
            Component = Components.FirstOrDefault();
        }
        #endregion

        #region Methods
        private void UpdateServiceInterval()
        {
            componentRepo.UpdateServiceInterval(Component);
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
