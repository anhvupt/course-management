using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;

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
            this IQueryable<T> source,
            bool condition, Expression<Func<T, bool>> predicate)
        {
            return (condition) ? source.Where(predicate) : source;
        }

        public static IQueryable<T> DynamicSort<T>(this IQueryable<T> source,
            string sortBy, bool revert = false)
        {
            string revertSuffix = revert ? "descending" : "";
            return source.OrderBy($"{sortBy} {revertSuffix}");
        }

        public static IQueryable<T> DynamicSortIf<T>(this IQueryable<T> source,
            bool condition, string sortBy, bool revert = false)
        {
            return (condition) ? source.DynamicSort(sortBy, revert) : source;
        }
    }
}
