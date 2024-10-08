/*
 * COSC2100 Section 4 F2024
 * Clint MacDonald
 * Sept 17, 2024
 * General Tools
 * */

using System;
using System.Drawing;

namespace Demo_w04a_VariableScope_Planning
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
