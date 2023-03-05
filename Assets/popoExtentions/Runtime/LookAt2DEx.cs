using UnityEngine;

namespace JuhaKurisu.PopoTools.Extentions
{
    public static class LookAt2DEx
    {
        public static void LookAt2D(this Transform transform, Vector2 targetPosition) => transform.LookAt2D(targetPosition);
        public static void LookAt2D(this Transform transform, Vector3 targetPosition)
        {
            Vector3 diff = (targetPosition - transform.position);
            transform.rotation = Quaternion.FromToRotation(Vector3.up, diff);
        }
    }
}