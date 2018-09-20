using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VectorExtensions
{
    #region Vector3
    public static Vector3 GetNewWithX(this Vector3 v, float x)
    {
        return new Vector3(x, v.y, v.z);
    }

    public static Vector3 GetNewWithY(this Vector3 v, float y)
    {
        return new Vector3(v.x, y, v.z);
    }

    public static Vector3 GetNewWithZ(this Vector3 v, float z)
    {
        return new Vector3(v.x, v.y, z);
    }

    public static Vector3 SwapXY(this Vector3 v)
    {
        return new Vector3(v.y, v.x, v.z);
    }

    public static Vector3 SwapXZ(this Vector3 v)
    {
        return new Vector3(v.z, v.y, v.x);
    }

    public static Vector3 SwapYZ(this Vector3 v)
    {
        return new Vector3(v.x, v.z, v.y);
    }

    public static Vector3 Change(this Vector3 org, object x = null, object y = null, object z = null)
    {
        float newX;
        float newY;
        float newZ;

        if (x == null)
            newX = org.x;
        else
            newX = (float)x;

        if (y == null)
            newY = org.y;
        else
            newY = (float)y;

        if (z == null)
            newZ = org.z;
        else
            newZ = (float)z;

        return new Vector3(newX, newY, newZ);
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