using System.Collections.Generic;

namespace SwitchAndDictionary.Dictionary
{
    public class DictionaryWithFiveItems
    {
        public string Dictionary(int color)
        {
            var colorString = "Red";

            var colors = new Dictionary<int, string>
            {
                {1, "Green"},
                {2, "Blue"},
                {3, "Violet"},
                {4, "Orange"},
                {5, "Magenta" }
            };

            var containsKey = colors.ContainsKey(color);

            if (containsKey)
            {
                colorString = colors[color];
            }

            return colorString;
        }
    }
}
