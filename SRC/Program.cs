﻿/*
    $ TheDropper $

    Author > github.com/L1ghtM4n
    Donate > 1Lightx1nLy6DfH3W8WD1g4PugRu92M7GV (Bitcoin)
*/

using System;
using System.Windows.Forms;

namespace TheDropper
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Builder());
        }
    }
}
