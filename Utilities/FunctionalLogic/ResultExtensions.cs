using System;

namespace Utilities.FunctionalLogic
{
    public static class ResultExtensions
    {
        public static Result<T> ToResult<T>(this T item, string errorMessage) where T : class
        {
            if (item.IsNull())
                return Result.Fail<T>(errorMessage);

            return Result.Ok(item);
        }

        public static Result<TK> OnSuccess<T, TK>(this Result<T> result, Func<T, TK> func)
        {
            if (result.IsFailure)
                return Result.Fail<TK>(result.Error);

            return Result.Ok(func(result.Value));
        }

        public static Result<T> OnSuccess<T>(this Result<T> result, Action<T> action)
        {
            if (result.IsSuccess)
            {
                action(result.Value);
            }

            return result;
        }
    }
}
