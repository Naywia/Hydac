using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac.Persistence
{
    public abstract class Repo<T>
    {
        protected ObservableCollection<T> repo = new ObservableCollection<T> { };

        public bool AddItem(T item)
        {
            repo.Add(item);
            return true;
        }

        public ObservableCollection<T> GetItems()
        {
            return repo;
        }

        public bool RemoveItem(T item)
        {
            repo.Remove(item);
            return true;
        }
    }
}
