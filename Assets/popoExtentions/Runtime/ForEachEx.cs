using System;
using System.Collections.Generic;

namespace JuhaKurisu.PopoTools.Extentions
{
    public static class ForEachEx
    {
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> value, Action<T> action)
        {
            foreach (var item in value)
                action.Invoke(item);

            return value;
        }

        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> value, Action<T, int> action)
        {
            int i = 0;
            foreach (var item in value)
            {
                action.Invoke(item, i);
                i++;
            }

            return value;
        }
    }
}