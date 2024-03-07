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
    public class AddComponentViewModel : ObservableObject
    {
        #region Fields
        private string name;
        private string partNumber;
        public string serialNumber;
        private string itemNumber;
        private string batch;
        private string type;
        private int serviceInterval;

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
        public string Name
        {
            get => name;
            set
            {
                name = value;
                NotifyPropertyChanged();
            }
        }
        public string PartNumber
        {
            get => partNumber;
            set
            {
                partNumber = value;
                NotifyPropertyChanged();
            }
        }
        public string SerialNumber
        {
            get => serialNumber;
            set
            {
                serialNumber = value;
                NotifyPropertyChanged();
            }
        }
        public string ItemNumber
        {
            get => itemNumber;
            set
            {
                itemNumber = value;
                NotifyPropertyChanged();
            }
        }
        public string Batch
        {
            get => batch;
            set
            {
                batch = value;
                NotifyPropertyChanged();
            }
        }
        public string Type
        {
            get => type;
            set
            {
                type = value;
                NotifyPropertyChanged();
            }
        }
        public int ServiceInterval
        {
            get => serviceInterval;
            set
            {
                serviceInterval = value;
                NotifyPropertyChanged();
            }
        }

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
