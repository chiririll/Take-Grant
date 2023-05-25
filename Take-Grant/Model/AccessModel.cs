using System;
using System.Collections.Generic;

namespace TakeGrant.Model
{
    public class AccessModel
    {
        private readonly List<Item> items;

        public IReadOnlyList<Item> Items => items;

        public event Action OnMatrixChanged;

        public AccessModel()
        {
            items = new List<Item>();
        }

        public void CreateMatrix(int count)
        {
            items.Clear();
            for (int i = 0; i < count; i++) 
            { 
                items.Add(new Item(i));
            }
        }

        public void Invalidate()
        {
            OnMatrixChanged?.Invoke();
        }

        public void ClearRights()
        {
            foreach (var item in items)
            {
                item.ClearRights();
            }
        }

        public void RandomizeRights()
        {
            var rand = new Random();

            ClearRights();

            foreach (var item in items)
            {
                var objId = rand.Next(items.Count - 1);
                if (objId == item.id) objId++;

                item.EditRights(objId, Rights.Randomize(rand));
            }
        }
    }
}
