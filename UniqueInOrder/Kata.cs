using System.Collections.Generic;
using System.Linq;

namespace UniqueInOrder
{
    public class Kata
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            if (!iterable.Any()) return iterable;
            var items = new List<T> {iterable.First()};
            foreach (var item in iterable.Skip(1))
            {
                if (!item.Equals(items.Last()))
                {
                    items.Add(item);
                }
            }
            return items;
        }
    }
}
