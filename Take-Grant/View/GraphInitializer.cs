using System.Collections.Generic;

namespace TakeGrant.View
{
    public class GraphInitializer<T> where T : class
    {
        private readonly IReadOnlyList<T> items;
        private int currentIndex;

        public GraphInitializer(IReadOnlyList<T> items)
        {
            this.items = items;
            currentIndex = 0;
        }

        public bool IsOver() => currentIndex >= items.Count;
        public T PeekItem() => IsOver() ? null : items[currentIndex];
        public T GetItem() => IsOver() ? null : items[currentIndex++];
    }
}
