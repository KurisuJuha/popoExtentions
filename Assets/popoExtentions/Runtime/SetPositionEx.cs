using UnityEngine;

namespace JuhaKurisu.PopoTools.Extentions
{
    public static class SetPositionEx
    {
        public static Transform SetPositionX(this Transform transform, float x)
        {
            transform.position = new(x, transform.position.y, transform.position.z);
            return transform;
        }
    }
}