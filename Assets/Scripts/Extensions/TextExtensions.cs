using UnityEngine.UI;
using TMPro;

namespace Common
{
    public static class TextExtensions
    {
        public static void SetText(this Text source, string someString)
        {
            source.text = someString;
        }

        public static void SetText(this TextMeshProUGUI source, string someString)
        {
            source.text = someString;
        }

        public static void SetUpperText(this Text source, string someString)
        {
            source.text = someString.ToUpper();
        }

        public static void SetUpperText(this TextMeshProUGUI source, string someString)
        {
            source.text = someString.ToUpper();
        }

        public static void SetLowerText(this Text source, string someString)
        {
            source.text = someString.ToLower();
        }

        public static void SetLowerText(this TextMeshProUGUI source, string someString)
        {
            source.text = someString.ToLower();
        }
    }
}