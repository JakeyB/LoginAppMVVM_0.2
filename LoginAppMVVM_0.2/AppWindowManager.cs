using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using Caliburn.Micro;

//manages window being viewed

namespace LoginAppMVVM_0._2
{
    class AppWindowManager : WindowManager
    {
        protected override Window EnsureWindow(object model, object view, bool isDialog)
        {
            Window window = base.EnsureWindow(model, view, isDialog);

            window.SizeToContent = SizeToContent.Manual;
            window.Width = 300;
            window.Height = 300;

            return window;
        }
    }
}
