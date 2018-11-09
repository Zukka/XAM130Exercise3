
using Xamarin.Forms;

namespace Calculator
{
    public static class SharedResources
    {
        public static Color MyOpButtonBkColor
        {
            get { return Color.FromRgb(0xff, 0xa5, 0xa5); }
        }

        public static Color OpButtonBkColor
        {
            get { return Color.FromRgb(0xff, 0xa5, 0); }
        }

        public static double CustomFontSize
        {
            get { return 34; }
        }

        public static Color MyDarkGrayTextColor
        {
            get { return Color.DarkGray; }
        }
    }
}
