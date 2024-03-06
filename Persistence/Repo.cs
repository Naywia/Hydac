using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac.Persistence
{
    public abstract class Repo
    {
        protected ObservableCollection<Repo> repo;

        public bool AddItem(Repo item)
        {
            repo.Add(item);
            return true;
        }

        public ObservableCollection<Repo> GetItems()
        {
            return repo;
        }

        public bool RemoveItem(Repo item)
        {
            repo.Remove(item);
            return true;
        }
    }
}
