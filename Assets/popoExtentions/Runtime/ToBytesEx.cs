using System;
using System.Text;


namespace JuhaKurisu.PopoTools.Extentions
{
    public static class ToBytesEx
    {
        public static byte[] ToBytes(this bool value)
            => BitConverter.GetBytes(value);

        public static byte[] ToBytes(this byte value)
            => new byte[] { value };

    }
}