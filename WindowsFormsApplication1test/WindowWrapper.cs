using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WindowsFormsApplication1test
{
    public class WindowWrapper
    {
        [DllImport("user32")]
        public static extern int GetWindowLong(IntPtr hWnd, GWL nIndex);
        [DllImport("user32.dll")]
        public static extern bool SetLayeredWindowAttributes(IntPtr hWnd, int crKey, byte alpha, LWA dwFlags);
        [DllImport("user32")]
        public static extern int SetWindowLongPtr(IntPtr hWnd, GWL nIndex, WS_EX dsNewLong);//SetWindowLong

        public enum GWL
        {
            ExStyle = -20
        }

        public enum LWA
        {
            Alpha = 2,
            ColorKey = 1
        }

        public enum WS_EX
        {
            Layered = 0x80000,
            Transparent = 0x20
        }
    }
}
