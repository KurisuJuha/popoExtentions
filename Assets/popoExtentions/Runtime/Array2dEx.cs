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
    }
}