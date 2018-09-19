using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public static class IntExtensions{
    public static int Pow(this int x, int value)
    {
        return (int)Math.Pow(x, value);
    }
}
