using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace ServiceManager.Extensions
{
    public static class ControlExtensions
    {
        public static void EnebleDoubleBuffer(this Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, control, new object[] { true });

            foreach (Control childControl in control.Controls)
            {
                childControl.EnebleDoubleBuffer();
            }
        }
    }
}
