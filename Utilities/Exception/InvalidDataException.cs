using System.Collections.Generic;
using System.Linq;

namespace Utilities.Exception
{
    public static class InvalidDataException
    {
        public static IEnumerable<T> InvalidDataExceptionIfNotMatched<T>(this IEnumerable<T> items, int count)
            where T : class
        {
            if (items != null && items.Count() == count)
            {
                return items;
            }

            throw new System.IO.InvalidDataException();
        }

        public static IEnumerable<T> InvalidDataExceptionIfNullOrEmpty<T>(this IEnumerable<T> items) where T : class
        {
            if (items != null && items.Any())
            {
                return items;
            }

            throw new System.IO.InvalidDataException();
        }
    }
}
