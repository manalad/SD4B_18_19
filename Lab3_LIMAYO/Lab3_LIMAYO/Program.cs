
/*
Limayo, Paula Ann A.
BSCS-SD4B
September 27, 2018
This program is will compute the input number w/ diff operations the calculator */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab3_LIMAYO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculator());
        }
    }
}
