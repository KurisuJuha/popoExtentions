using System.Collections.Generic;
using System.Linq;

namespace JuhaKurisu.PopoTools.Extentions
{
    public static class JoinEx
    {
        public static string Join<T>(this IEnumerable<T> values, string separator)
            => string.Join(separator, values);
    }
}