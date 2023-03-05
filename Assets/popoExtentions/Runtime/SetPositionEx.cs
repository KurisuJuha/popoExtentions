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

        public static Transform SetPositionY(this Transform transform, float y)
        {
            transform.position = new(transform.position.x, y, transform.position.z);
            return transform;
        }

        public static Transform SetPositionZ(this Transform transform, float z)
        {
            transform.position = new(transform.position.x, transform.position.y, z);
            return transform;
        }
    }
}