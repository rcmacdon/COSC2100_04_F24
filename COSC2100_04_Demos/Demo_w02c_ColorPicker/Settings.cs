using System.Windows.Forms;

namespace Demo_w02c_ColorPicker
{
    public static class Settings
    {
        // Constants
        public const int DEF_SQUARESIZE = 80;
        public const int DEF_SPACING = 10;
        public const int DEF_LAYOUTMARGIN = 20;
        public const int DEF_TOPMARGIN = 50;
        public const int DEF_NUMSQUARES = 3;
        public const int MIN_NUMSQUARES = 1;
        public const int MAX_NUMSQUARES = 6;

        // Global Variables
        public static bool runEvents = false;
        public static Label[,] labels = new Label[MAX_NUMSQUARES, MAX_NUMSQUARES];
    }
}
