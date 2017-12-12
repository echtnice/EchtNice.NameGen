﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameGen
{
    public static class ControlExtensions
    {
        /// <summary>
        /// Executes the Action asynchronously on the UI thread, does not block execution on the calling thread.
        /// this.UIThread(() => CtrlResult.Text = res);
        /// </summary>
        /// <param name="control"></param>
        /// <param name="code"></param>
        public static void UIThread(this Control @this, Action code)
        {
            if (@this.InvokeRequired)
            {
                @this.BeginInvoke(code);
            }
            else
            {
                code.Invoke();
            }
        }
    }
}
