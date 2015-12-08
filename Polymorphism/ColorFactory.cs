using System.Collections.Generic;
using Polymorphism.Implementations;

namespace Polymorphism
{
    public class ColorFactory
    {
        public string GetColor(int color)
        {
            IColor defaultColor = new RedColor();
            var colors = GetColors();

            var containsKey = colors.ContainsKey(color);

            if (containsKey)
            {
                var c = colors[color];
                return c.ColorName;
            }

            return defaultColor.ColorName;
        }

        private static IDictionary<int, IColor> GetColors()
        {
            return new Dictionary<int, IColor>
            {
                {1, new GreenColor()},
                {2, new BlueColor()},
                {3, new VioletColor()},
                {4, new OrangeColor()},
                {4, new MagentaColor()}
            };
        }
    }
}
