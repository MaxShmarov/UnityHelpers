using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Axis
{
    X,Y,Z
}
namespace Common
{
    public static class TransformExtensions
    {
        #region Verification
        private static bool NotNull(object obj) 
        {
            if (obj == null)
            {
                Debug.LogError("[Transform] is not initialized!");
                return false;
            }

            return true;
        }
        #endregion

        #region PositionOperation
        public static void SetPosition(this Transform transform, float x, float y, float z)
        {
            if (!NotNull(transform))
                return;

            transform.position = new Vector3(x, y, z);
        }

        public static void SetPositionFor(this Transform transform, Axis axis, float value)
        {
            if (!NotNull(transform))
                return;

            switch (axis)
            {
                case Axis.X:
                    transform.position = new Vector3(value, transform.position.y, transform.position.z);
                    break;
                case Axis.Y:
                    transform.position = new Vector3(transform.position.x, value, transform.position.z);
                    break;
                case Axis.Z:
                    transform.position = new Vector3(transform.position.x, transform.position.y, value);
                    break;
                default:
                    Debug.LogWarning("Incorrect axis");
                    break;
            }
        }

        public static void SetRandomPositionFor(this Transform transform, Axis axis, float min, float max)
        {
            if (!NotNull(transform))
                return;

            float value = Random.Range(min, max);

            switch (axis)
            {
                case Axis.X:
                    transform.position = new Vector3(value, transform.position.y, transform.position.z);
                    break;
                case Axis.Y:
                    transform.position = new Vector3(transform.position.x, value, transform.position.z);
                    break;
                case Axis.Z:
                    transform.position = new Vector3(transform.position.x, transform.position.y, value);
                    break;
                default:
                    Debug.LogWarning("Incorrect axis");
                    break;
            }
        }
        #endregion

        #region RotationOperation
        public static void SetRotation(this Transform transform, float x, float y, float z)
        {
            if (!NotNull(transform))
                return;

            transform.rotation = Quaternion.Euler(x, y, z);
        }

        public static void SetRotationFor(this Transform transform, Axis axis, float value)
        {
            if (!NotNull(transform))
                return;

            switch (axis)
            {
                case Axis.X:
                    transform.rotation = Quaternion.Euler(value, transform.rotation.y, transform.rotation.z);
                    break;
                case Axis.Y:
                    transform.rotation = Quaternion.Euler(transform.rotation.x, value, transform.rotation.z);
                    break;
                case Axis.Z:
                    transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, value);
                    break;
                default:
                    Debug.LogWarning("Incorrect axis");
                    break;
            }
        }

        public static void SetRandomRotationFor(this Transform transform, Axis axis, float min, float max)
        {
            if (!NotNull(transform))
                return;

            float value = Random.Range(min, max);

            switch (axis)
            {
                case Axis.X:
                    transform.rotation = Quaternion.Euler(value, transform.rotation.y, transform.rotation.z);
                    break;
                case Axis.Y:
                    transform.rotation = Quaternion.Euler(transform.rotation.x, value, transform.rotation.z);
                    break;
                case Axis.Z:
                    transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, value);
                    break;
                default:
                    Debug.LogWarning("Incorrect axis");
                    break;
            }
        }
        #endregion
    }
}