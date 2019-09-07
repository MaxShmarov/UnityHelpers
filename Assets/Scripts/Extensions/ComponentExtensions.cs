using UnityEngine;

public static class ComponentExtensions
{
    public static bool Has<T>(this Component component) where T : Component
    {
        return component.GetComponent<T>() != null;
    }

    public static void Deactivate(this Component component)
    {
        component.gameObject.SetActive(false);
    }

    public static void Activate(this Component component)
    {
        component.gameObject.SetActive(true);
    }

    public static void SwitchState(this Component component)
    {
        var currentState = component.gameObject.activeSelf;
        component.gameObject.SetActive(!currentState);
    }
}