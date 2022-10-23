using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnrarNative;

namespace alphashare
{
    static class Program
    {
        /// 
        /// HELLO WORLD
        /// 2
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern bool SetProcessDPIAware();
    }
}
