using System;

namespace Utilities.FunctionalLogic
{
    public static class FunctionalExtensions
    {
        public static TK Map<T, TK>(this T result, Func<T, TK> func)
        {
            return func(result);
        }

        public static bool IsNull<T>(this T item) where T : class
        {
            return item == null;
        }
    }
}
