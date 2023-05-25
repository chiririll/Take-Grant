using System;
using System.Collections.Generic;

namespace TakeGrant.Model
{
    public class AccessModel
    {
        private readonly List<Item> subjects;
        private readonly List<Item> objects;

        private readonly List<Item> items;

        public IReadOnlyList<Item> Subjects => subjects;
        public IReadOnlyList<Item> Objects => objects;
        public IReadOnlyList<Item> Items => items;

        public event Action OnMatrixChanged;

        public AccessModel()
        {
            subjects = new List<Item>();
            objects = new List<Item>();
            items = new List<Item>();
        }

        public void CreateMatrix(int subjCount, int objCount)
        {
            subjects.Clear();
            objects.Clear();

            int i = 0;
            for (; i < subjCount; i++)
            {
                subjects.Add(new Item(i, false));
            }

            for (; i < subjCount + objCount; i++)
            {
                objects.Add(new Item(i, true));
            }

            items.Clear();
            items.AddRange(subjects);
            items.AddRange(objects);
        }

        public void Invalidate()
        {
            OnMatrixChanged?.Invoke();
        }

        public void ClearRights()
        {
            foreach (var item in subjects)
            {
                item.ClearRights();
            }

            foreach (var item in objects)
            {
                item.ClearRights();
            }
        }

        public void RandomizeRights()
        {
            var rand = new Random();

            ClearRights();

            foreach (var item in subjects)
            {
                foreach (var subj in subjects)
                {
                    if (subj.id == item.id) continue;


                    item.EditRights(subj.id, Rights.Randomize(rand, true, subjects.Count));
                }

                foreach (var obj in objects)
                {
                    item.EditRights(obj.id, Rights.Randomize(rand, false, objects.Count));
                }
            }
        }
    }
}
