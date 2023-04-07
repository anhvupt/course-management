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
    }
}
