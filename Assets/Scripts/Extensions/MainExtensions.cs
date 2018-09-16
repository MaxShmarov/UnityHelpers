using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace Extensions
{
    public static class MainExtensions
    {
        public static bool Has<T>(this GameObject obj) where T : Component
        {
            return obj.GetComponent<T>() != null;
        }

        public static bool Has<T>(this Component component) where T : Component
        {
            return component.GetComponent<T>() != null;
        }

        public static T AddChild<T>(this GameObject parent) where T : Component
        {
            return AddChild<T>(parent, typeof(T).Name);
        }

        public static GameObject AddChild(this GameObject parent, GameObject child, bool worldPoritionStays = false)
        {
            child.transform.SetParent(parent.transform, worldPoritionStays);
            return parent;
        }

        public static T AddChild<T>(this GameObject parent, string name) where T : Component
        {
            var obj = AddChild(parent, name, typeof(T));
            return obj.GetComponent<T>();
        }

        public static GameObject AddChild(this GameObject parent, params Type[] components)
        {
            return AddChild(parent, "Game Object", components);
        }

        public static GameObject AddChild(this GameObject parent, string name, params Type[] components)
        {
            var obj = new GameObject(name, components);
            if (parent != null)
            {
                if (obj.transform is RectTransform) obj.transform.SetParent(parent.transform, true);
                else obj.transform.parent = parent.transform;
            }
            return obj;
        }

        public static GameObject LoadChild(this GameObject parent, string resourcePath)
        {
            var obj = (GameObject)GameObject.Instantiate(Resources.Load(resourcePath));
            if (obj != null && parent != null)
            {
                if (obj.transform is RectTransform) obj.transform.SetParent(parent.transform, true);
                else obj.transform.parent = parent.transform;
            }
            return obj;
        }

        public static GameObject LoadChild(this Transform parent, string resourcePath)
        {
            var obj = (GameObject)GameObject.Instantiate(Resources.Load(resourcePath));
            if (obj != null && parent != null)
            {
                if (obj.transform is RectTransform) obj.transform.SetParent(parent, true);
                else obj.transform.parent = parent;
            }
            return obj;
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

        public static T RandomOne<T>(this IEnumerable<T> items)
        {
            if (items == null) throw new ArgumentException("Cannot randomly pick an item from the list, the list is null!");
            if (items.Count() == 0) throw new ArgumentException("Cannot randomly pick an item from the list, there are no items in the list!");
            var r = UnityEngine.Random.Range(0, items.Count());
            return items.ElementAt(r);
        }

        public static void Deactivate(this Component component)
        {
            component.gameObject.SetActive(false);
        }

        public static void Deactivate(this GameObject gameObject)
        {
            gameObject.SetActive(false);
        }

        public static void Activate(this Component component)
        {
            component.gameObject.SetActive(true);
        }

        public static void Activate(this GameObject gameObject)
        {
            gameObject.SetActive(true);
        }

        public static void SwitchState(this Component component)
        {
            var currentState = component.gameObject.activeSelf;
            component.gameObject.SetActive(!currentState);
        }

        public static void SwitchState(this GameObject gameObject)
        {
            var currentState = gameObject.activeSelf;
            gameObject.SetActive(!currentState);
        }
    }
}