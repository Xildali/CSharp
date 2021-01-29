/*
 * Севостьянов Денис
 * 
 * *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр. 
 * Реализовать подсчет времени выполнения программы, используя структуру DateTime.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Task6
    {
        public void Perform()
        {
            DateTime start = DateTime.Now;
            int goodNumbers = 0;

            for (int i = 1; i <= 1_000_000_000; i++)
            {
                if (IsGoodNumber(i))
                    goodNumbers++;
            }

            DateTime finish = DateTime.Now;

            Console.WriteLine($"Хороших чисел: {goodNumbers}. Время выполнения: {finish - start}");
            Console.ReadKey();
        }

        private bool IsGoodNumber(int n)
        {
            int rest = n;
            int sum = 0;

            while (rest != 0)
            {
                sum += rest % 10;
                rest /= 10;
            }

            return (n % sum) == 0;
        }
    }
}
