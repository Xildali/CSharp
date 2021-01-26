/*
    Севостьянов Денис

    Написать программу обмена значениями двух переменных.
    а) с использованием третьей переменной;
    б) *без использования третьей переменной.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Task4
    {
        public void Perform()
        {
            Random rnd = new Random();
            int a = rnd.Next();
            int b = rnd.Next();
            Console.WriteLine($"А: {a} B: {b}");

            // с использованием третьей переменной
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"А: {a} B: {b}");

            // без использования третьей переменной
            a = a + b;
            b = a - b;
            a = a - b; 
            Console.WriteLine($"А: {a} B: {b}");

            Console.ReadKey();
        }

    }
}
