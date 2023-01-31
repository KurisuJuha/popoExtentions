using System;

namespace JuhaKurisu.PopoTools.Extentions
{
    public static class Array2dEx
    {
        public static T[,] Rotate<T>(this T[,] self)
        {
            int rows = self.GetLength(0);
            int columns = self.GetLength(1);
            var result = new T[columns, rows];

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

        public static bool IsIndexWithInRange<T>(this T[,] self, int indexX, int indexY)
        {
            return indexX >= 0 && indexX < self.GetLength(0)
                && indexY >= 0 && indexY < self.GetLength(1);
        }

    }
}