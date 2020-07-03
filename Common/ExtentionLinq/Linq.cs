using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.ExtentionLinq
{
    public static class Linq
    {
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return source.GroupBy(keySelector).Select(x => x.FirstOrDefault());
        }
    }

}
