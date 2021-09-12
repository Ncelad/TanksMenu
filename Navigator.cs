using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TanksMenu
{
    public static class Navigator
    {
        public static MainWindow win_nav;

        public static void GoToPage(UserControl control)
        {
            win_nav.ChangePage(control);
        }
    }
}
