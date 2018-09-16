using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public static class IntExtensions{
    public static void Pow(this int x, int value)
    {
        Math.Pow(x, value);
    }
}
