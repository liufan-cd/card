using UnityEngine;

namespace src.card_framework.util
{
    public class BezierUtil
    {
        public static Vector3 BezierCurve(Vector3 p0, Vector3 p1, float t)
        {
            return (1 - t) * p0 + t * p1;
        }

        public static Vector3 BezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, float t)
        {
            float f = (1 - t);
            float t1 = f * f;
            float t2 = 2 * t * f;
            float t3 = t * t;
            return t1 * p0 + t2 * p1 + t3 * p2;
        }
    
        public static Vector3 BezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
        {
            float f = 1 - t;
            float t1 = f * f * f;
            float t2 = 3 * t * f * f;
            float t3 = 3 * t * t * f;
            float t4 = t * t * t;
            return t1 * p0 + t2 * p1 + t3 * p2 + t4 * p3;
        }
    }
}