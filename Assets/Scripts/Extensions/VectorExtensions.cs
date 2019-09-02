using UnityEngine;

public static class VectorExtensions
{
    #region Vector3
    public static Vector3 GetNewWithX(this Vector3 vector, float x)
    {
        return new Vector3(x, vector.y, vector.z);
    }

    public static Vector3 GetNewWithY(this Vector3 vector, float y)
    {
        return new Vector3(vector.x, y, vector.z);
    }

    public static Vector3 GetNewWithZ(this Vector3 vector, float z)
    {
        return new Vector3(vector.x, vector.y, z);
    }

    public static Vector3 SwapXY(this Vector3 vector)
    {
        return new Vector3(vector.y, vector.x, vector.z);
    }

    public static Vector3 SwapXZ(this Vector3 vector)
    {
        return new Vector3(vector.z, vector.y, vector.x);
    }

    public static Vector3 SwapYZ(this Vector3 vector)
    {
        return new Vector3(vector.x, vector.z, vector.y);
    }
    #endregion

    #region Vector2
    public static Vector2 GetNewWithX(this Vector2 v, float x)
    {
        return new Vector2(x, v.y);
    }

    public static Vector2 GetNewWithY(this Vector2 v, float y)
    {
        return new Vector2(v.x, y);
    }

    public static Vector2 SwapXY(this Vector2 v)
    {
        return new Vector2(v.y, v.x);
    }
    #endregion
}