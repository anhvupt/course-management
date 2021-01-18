using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Extensions
{
    public static class CollectionExtension
    {
        public static IEnumerable<TSource> WhereIf<TSource>(
            this IEnumerable<TSource> collection, 
            bool condition, Func<TSource, bool> predicate)
        {
            return (condition) ? collection.Where(predicate) : collection;
        }
    }
}
