using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Common
{
    public static class TextExtensions
    {
        public static void SetText(this Text text, string someString)
        {
            text.text = someString;
        }

        public static void SetUpperText(this Text text, string someString)
        {
            text.text = someString.ToUpper();
        }

        public static void SetLowerText(this Text text, string someString)
        {
            text.text = someString.ToLower();
        }
    }
}