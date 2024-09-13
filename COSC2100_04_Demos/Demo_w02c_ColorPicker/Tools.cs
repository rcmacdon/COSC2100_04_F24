using System;
using System.Drawing;

namespace Demo_w02c_ColorPicker
{
    public static class Tools
    {

        static Random random = new Random();

        public static int RandomInt(int min, int max)
        {
            return random.Next(min, max);
        }

        public static Color RandomColor()
        {
            return Color.FromArgb(255, RandomInt(0, 255), RandomInt(0, 255), RandomInt(0, 255));
        }

    }
}
