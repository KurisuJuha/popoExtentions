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
    }
}