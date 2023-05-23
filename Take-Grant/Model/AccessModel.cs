using System.Collections.Generic;

namespace TakeGrant.Model
{
    public class AccessModel
    {
        private readonly List<Item> items;

        public IReadOnlyList<Item> Items => items;

        public AccessModel()
        {
            items = new List<Item>();

            items.Add(new Item(0));
            items.Add(new Item(1));
            items.Add(new Item(2));
            items.Add(new Item(3));
            items.Add(new Item(4));
        }
    }
}
