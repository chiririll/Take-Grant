using System.Collections.Generic;

namespace TakeGrant.Model
{
    public class Item
    {
        private readonly Dictionary<int, Rights.Type> rights;
        public readonly int id;

        public Item(int id, bool isObject)
        {
            rights = new Dictionary<int, Rights.Type>();

            this.id = id;
            IsObject = isObject;
        }

        public IReadOnlyDictionary<int, Rights.Type> AccessRights => rights;

        public string ShortName => (IsObject ? "O" : "S") + id.ToString();
        public bool IsObject { get; }

        public void EditRights(int id, Rights.Type right)
        {
            if (right == Rights.Type.None) return;

            rights[id] = right;
        }

        public void ClearRights() => rights.Clear();
    }
}
