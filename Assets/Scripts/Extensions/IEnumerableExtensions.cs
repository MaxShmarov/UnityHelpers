using System;
using System.Collections.Generic;
using System.Linq;

public static class IEnumerableExtensions
{
    public static T RandomOne<T>(this IEnumerable<T> items)
    {
        if (items == null) throw new ArgumentException("Cannot randomly pick an item from the list, the list is null!");
        if (items.Count() == 0) throw new ArgumentException("Cannot randomly pick an item from the list, there are no items in the list!");
        var r = UnityEngine.Random.Range(0, items.Count());
        return items.ElementAt(r);
    }
}