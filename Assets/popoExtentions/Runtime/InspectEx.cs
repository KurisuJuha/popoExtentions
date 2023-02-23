using UnityEngine;

namespace JuhaKurisu.PopoTools.Extentions
{
    public static class InspectEx
    {
        public static T Inspect<T>(this T value)
        {
            Debug.Log(value);
            return value;
        }
    }
}