using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
   public static class Enumerableextension
    {
        public static T WithMinimum<T, Tkey>(this IEnumerable<T> sequence, Func<T, Tkey> criterion)
            where T : class
            where Tkey : IComparable<Tkey> =>
            sequence.Aggregate((T)null, (best, curr) =>
            best == null || criterion(curr).CompareTo(criterion(best)) < 0 ? curr : best);

        public static IEnumerable<T> Except<T, TKey>(this IEnumerable<T> items, IEnumerable<T> other, Func<T, TKey> getKey)
        {
            return from item in items
                   join otherItem in other on getKey(item)
                   equals getKey(otherItem) into tempItems
                   from temp in tempItems.DefaultIfEmpty()
                   where ReferenceEquals(null, temp) || temp.Equals(default(T))
                   select item;
        }
    }


}
