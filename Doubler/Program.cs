﻿/*
 * Севостьянов Денис
 * 
 * а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
 * б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен постараться получить это число за минимальное количество ходов.
 * в) * Добавить кнопку «Отменить», которая отменяет последние ходы.
*/

using System;
using System.Windows.Forms;

namespace Doubler
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
