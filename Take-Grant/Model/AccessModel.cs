using System;
using System.Collections.Generic;

namespace TakeGrant.Model
{
    public class AccessModel
    {
        private readonly List<Item> items;

        private int freeId = 0;

        public IReadOnlyList<Item> Items => items;

        public event Action OnMatrixChanged;

        public AccessModel()
        {
            items = new List<Item>();

            items.Add(new Item(freeId++));
            items.Add(new Item(freeId++));
            items.Add(new Item(freeId++));
            items.Add(new Item(freeId++));
            items.Add(new Item(freeId++));
        }

        internal void CreateItem(string name = null)
        {
            var item = new Item(freeId++);
            item.Name = name;

            items.Add(item);
            OnMatrixChanged?.Invoke();
        }

        public void Invalidate()
        {
            OnMatrixChanged?.Invoke();
        }
    }
}
