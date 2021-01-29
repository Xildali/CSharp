/*
 * Севостьянов Денис
 * 
 * С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Task3
    {
        public void Perform()
        {
            long sum = 0;
            bool isNumber;
            int number;

            do
            {
                Console.Write("Введите число: ");
                string input = Console.ReadLine();
                isNumber = int.TryParse(input, out number);

                if (!isNumber)
                    break;

                if (IsPositiveOdd(number))
                    sum += number;
            }
            while (number != 0);

            Console.WriteLine($"Результат: {sum}");
            Console.ReadKey();
        }

        private bool IsPositiveOdd(int n)
        {
            return n > 0 && n % 2 == 1;
        }
    }
}
