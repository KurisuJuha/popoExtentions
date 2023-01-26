using System;

namespace JuhaKurisu.Popo.Extentions
{
    public static class ArrayEx
    {
        public static T[,] To2D<T>(this T[] self, bool revert)
        {
            T[,] ret = new T[revert ? self.Length : 1, revert ? 1 : self.Length];

            for (int i = 0; i < self.Length; i++)
            {
                if (revert)
                    ret[i, 0] = self[i];
                else
                    ret[0, i] = self[i];
            }

            return ret;
        }

        public static bool IsIndexWithInRange<T>(this T[] self, int index)
        {
            return index >= 0 && index < self.Length;
        }

        public static bool TryGetValue<T>(this T[] self, int index, out T value)
        {
            value = default(T);
            if (self.IsIndexWithInRange(index)) return false;

            value = self[index];
            return true;
        }

        public static bool TryGetValue<T>(this T[] self, int index, Action<T> action)
        {
            if (self.TryGetValue(index, out var value) && value is not null)
            {
                action.Invoke(value);
                return true;
            }

            return false;
        }

        public static T[] ForEach<T>(this T[] self, Action<T> action)
        {
            foreach (var c in self)
            {
                action.Invoke(c);
            }

            return self;
        }
    }
}