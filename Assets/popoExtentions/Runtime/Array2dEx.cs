namespace JuhaKurisu.Popo.Extentions
{
    public static class Array2dEx
    {
        public static T[,] Rotate<T>(this T[,] self)
        {
            int rows = self.GetLength(0);
            int colums = self.GetLength(1);
            var result = new T[colums, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[j, rows - i - 1] = self[i, j];
                }
            }

            return result;
        }

        public static T[,] Rotate<T>(this T[,] self, int count)
        {
            for (int i = 0; i < count; i++)
            {
                self = self.Rotate();
            }

            return self;
        }

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