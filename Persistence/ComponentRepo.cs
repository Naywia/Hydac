using Hydac.Models;

namespace Hydac.Persistence
{
    public class ComponentRepo : Repo<Component>
    {
        public ComponentRepo() {
            AddItem(new Component("a", "b", "c", "d", "e", "f", 7));
        }
        public void UpdateServiceInterval(Component component)
        {
            Component c = repo.FirstOrDefault(x => x.ItemNumber == component.ItemNumber);
            int i = repo.IndexOf(c);
            repo[i] = component;
        }
    }
}
