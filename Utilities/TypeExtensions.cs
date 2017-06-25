namespace Utilities
{
    public static class TypeExtensions
    {
        public static bool IsGreaterThan(this int value, int comparator)
        {
            return value > comparator;
        }

        public static bool IsGreaterThan(this int? value, int comparator)
        {
            return value.HasValue && IsGreaterThan(value.Value, comparator);
        }

        public static bool IsGreaterThan(this decimal value, decimal comparator)
        {
            return value > comparator;
        }
    }
}
