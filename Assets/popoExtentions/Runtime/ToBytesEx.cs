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

        public static byte[] ToBytes(this sbyte value)
            => BitConverter.GetBytes(value);

        public static byte[] ToBytes(this Int16 value)
            => BitConverter.GetBytes(value);

        public static byte[] ToBytes(this UInt16 value)
            => BitConverter.GetBytes(value);

        public static byte[] ToBytes(this Int32 value)
            => BitConverter.GetBytes(value);

    }
}