using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Terraria.Plugins.Common {
  public static class CollectionEx {
    public static void AddRangeWithoutClones(this IList list, IEnumerable enumerable) {
      //Contract.Requires<ArgumentNullException>(list != null);
            if (list == null) throw new ArgumentNullException();
            //Contract.Requires<ArgumentNullException>(enumerable != null);
            if (enumerable == null) throw new ArgumentNullException();

            foreach (object item in enumerable) {
        if (!list.Contains(item))
          list.Add(item);
      }
    }

    public static bool TryGetKey<TKey,TValue>(this IDictionary dictionary, TValue value, out TKey key) {
      foreach (KeyValuePair<TKey,TValue> pair in dictionary) {
        if (pair.Value.Equals(value)) {
          key = pair.Key;
          return true;
        }
      }
      
      key = default(TKey);
      return false;
    }
  }
}
