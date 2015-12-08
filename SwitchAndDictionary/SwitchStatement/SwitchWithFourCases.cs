namespace SwitchAndDictionary.SwitchStatement
{
    public class SwitchWithFourCases
    {
        public string SwitchStatment(int color)
        {
            var colorString = "Red";

            switch (color)
            {
                case 1:
                    colorString = "Green";
                    break;

                case 2:
                    colorString = "Blue";
                    break;

                case 3:
                    colorString = "Violet";
                    break;

                case 4:
                    colorString = "Orange";
                    break;

            }

            return colorString;
        }
    }
}
