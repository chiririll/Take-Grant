using System.Collections.Generic;

namespace TakeGrant.Model
{
    public class Item
    {
        private readonly Dictionary<int, Rights.Type> rights;
        public readonly int id;

        public Item(int id)
        {
            rights = new Dictionary<int, Rights.Type>();

            this.id = id;
        }

        public IReadOnlyDictionary<int,  Rights.Type> Rights => rights;

        public string ShortName => (rights.Count == 0 ? "O" : "S") + id.ToString();
        public string Name { get; set; }

        public void EditRights(int id, Rights.Type right)
        {
            rights[id] = right;
        }

        public void ClearRights() => rights.Clear();

        public override string ToString() => string.IsNullOrEmpty(Name) ? ShortName : $"{ShortName}: {Name}";
    }
}
