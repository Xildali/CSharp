/*
 * Севостьянов Денис
 * 
 * Написать метод подсчета количества цифр числа.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Task2
    {
        public void Perform()
        {
            Random random = new Random();
            int n = random.Next(int.MinValue, int.MaxValue);

            int digits = DigitsCount(n);

            Console.WriteLine($"Число: {n}. Цифр: {digits}");
            Console.ReadKey();
        }

        private int DigitsCount(int n)
        {
            string number = n.ToString();
            int digits = number.Length;

            if (number[0] == '-')
                digits--;

            return digits;
        }
    }
}
