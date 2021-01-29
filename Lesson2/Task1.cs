/*
 * Севостьянов Денис
 * 
 * Написать метод, возвращающий минимальное из трех чисел
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Task1
    {
        public void Perform()
        {
            Random random = new Random();
            int a = random.Next(100);
            int b = random.Next(100);
            int c = random.Next(100);

            int min = Min(a, b, c);

            Console.WriteLine($"Числа: {a} {b} {c}. Минимальное: {min}.");
            Console.ReadKey();
        }

        private int Min(int a, int b, int c)
        {
            int min = a < b ? a : b;
            min = min < c ? min : c;

            return min;
        }
    }
}
