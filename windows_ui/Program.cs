﻿using System;
using System.Windows.Forms;

namespace windows_ui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main ( )
        {
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault ( false );
        }
    }
}
