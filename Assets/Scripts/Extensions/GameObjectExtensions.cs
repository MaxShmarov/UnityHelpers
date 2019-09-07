using UnityEngine;

public static class GameObjectExtensions
{
    public static bool Has<T>(this GameObject obj) where T : Component
    {
        return obj.GetComponent<T>() != null;
    }

    public static void DestroyAllChildrenImmediately(this GameObject obj)
    {
        DestroyAllChildrenImmediately(obj.transform);
    }

    public static void DestroyAllChildrenImmediately(this Transform trans)
    {
        while (trans.childCount != 0)
            GameObject.DestroyImmediate(trans.GetChild(0).gameObject);
    }

    public static void SwitchState(this GameObject gameObject)
    {
        var currentState = gameObject.activeSelf;
        gameObject.SetActive(!currentState);
    }

    public static void Activate(this GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    public static void Deactivate(this GameObject gameObject)
    {
        gameObject.SetActive(false);
    }
}