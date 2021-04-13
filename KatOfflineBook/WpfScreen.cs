using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Pro1
{   
    public static class WindowHelpers
    {
        public static ScreenCurrentScreen(this Window window)
        {
            this.Width = System.Windows.SystemParameters.VirtualScreenWidth;
            this.Height = System.Windows.SystemParameters.VirtualScreenHeight;
        }
    }
}
