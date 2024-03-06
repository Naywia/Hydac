using Hydac.Models;
using Hydac.Persistence;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hydac.ViewModels
{
    public class AddComponentViewModel
    {
        #region Fields
        private ComponentRepo componentRepo = App.ComponentRepo;
        private ICommand addComponentCommand;
        #endregion

        #region Constructors
        #endregion

        #region Methods
        private void AddComponent()
        {
            if (Name != null && PartNumber != null && SerialNumber != null && ItemNumber != null && Batch != null && Type != null)
            {
                if (Name != "" && PartNumber != "" && SerialNumber != "" && ItemNumber != "" && Batch != "" && Type != "")
                {
                    componentRepo.AddItem(new Component(Name, PartNumber, SerialNumber, ItemNumber, Batch, Type, ServiceInterval));
                    Name = "";
                    PartNumber = "";
                    SerialNumber = "";
                    ItemNumber = "";
                    Batch = "";
                    Type = "";
                    ServiceInterval = 0;
                }
            }
        }
        #endregion

        #region Properties
        public string Name { get; set; }
        public string PartNumber { get; set; }
        public string SerialNumber { get; set; }
        public string ItemNumber { get; set; }
        public string Batch { get; set; }
        public string Type { get; set; }
        public int ServiceInterval { get; set; }

        public ICommand AddComponentCommand
        {
            get
            {
                addComponentCommand ??= new RelayCommand(MethodToRun => AddComponent());
                return addComponentCommand;
            }
        }
        #endregion
    }
}
