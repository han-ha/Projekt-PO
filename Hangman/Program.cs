﻿using System;
using System.Windows.Forms;

namespace HangmanUI
{
    /// <summary>
    /// Klasa programu.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
