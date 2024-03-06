using Hydac.Persistence;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Hydac
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static CustomerRepo CustomerRepo = new CustomerRepo();
        public static ComponentRepo ComponentRepo = new ComponentRepo();
        public static ComponentTypeRepo ComponentTypeRepo = new ComponentTypeRepo();
    }

}
