using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public static IQueryable<T> WhereIf<T>(
            this IQueryable<T> query, 
            bool condition, Expression<Func<T, bool>> predicate)
        {
            return (condition) ? query.Where(predicate) : query;
        }
    }
}
