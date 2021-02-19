/*
 * Севостьянов Денис
 * 
 * 2. Используя полученные знания и класс TrueFalse, разработать игру «Верю — не верю».
*/

using System;
using System.Windows.Forms;

namespace TrueFalseGame
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
            Application.Run(new Form1());
        }
    }
}
