﻿using System;
using System.Windows.Forms;

namespace POSBuddy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.Run(new Main());
        }
    }
}
