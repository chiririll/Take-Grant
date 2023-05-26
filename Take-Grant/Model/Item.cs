using System.Collections.Generic;

namespace TakeGrant.Model
{
    public class Item
    {
        private readonly Dictionary<int, Rights.Type> rights;

        public Item(int id, bool isObject)
        {
            rights = new Dictionary<int, Rights.Type>();

            this.Id = id;
            IsObject = isObject;
        }

        public int Id { get; }

        public IReadOnlyDictionary<int, Rights.Type> AccessRights => rights;

        public string ShortName => (IsObject ? "O" : "S") + (Id + 1).ToString();
        public bool IsObject { get; }

        public void EditRights(int id, Rights.Type right)
        {
            if (right == Rights.Type.None) return;

            rights[id] = right;
        }

        public void ClearRights() => rights.Clear();

        public override string ToString() => ShortName;
    }
}
