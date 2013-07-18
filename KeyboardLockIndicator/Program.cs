using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KeyboardLockIndicator
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var hook = new Hook();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            hook.Enable();
            Application.Run(new TaskTrayApplicationContext());
            hook.Disable();
        }
    }
}
