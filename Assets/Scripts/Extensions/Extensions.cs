using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Common
{
    public static class Extensions
    {
        public static T GetRequiredComponent<T>(this GameObject obj) where T : MonoBehaviour
        {
            T component = obj.GetComponent<T>();
            if (component == null)
            {
                throw new NullReferenceException("Waiting component type of " + typeof(T) + ", but it not found! GameObject : " + obj.name);
            }
            return component;
        }

        public static bool HasComponent<T>(this GameObject obj)
        {
            T component = obj.GetComponent<T>();
            if (component != null)
                return true;

            return false;
        }
    }
}