using System.Collections.Generic;

namespace TakeGrant.Model
{
    public class Item
    {
        private readonly Dictionary<int, Rights> rights;
        public readonly int id;

        public Item(int id)
        {
            rights = new Dictionary<int, Rights>();

            this.id = id;
        }

        public string Name { get; set; }

        public void EditRights(int id, Rights right)
        {
            rights[id] = right;
        }

        public void Remove(int id)
        {
            rights.Remove(id);
        }

        public override string ToString() => (rights.Count == 0 ? "O" : "S") + id.ToString() + 
            (string.IsNullOrEmpty(Name) ? "" : $": {Name}");
    }
}
