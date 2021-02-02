/*
 * Севостьянов Денис
 * 
 * а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
 * б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.task2
{
    class Task2
    {
        public void Perform()
        {
            long sum = 0;
            bool isNumber;
            int number;

            do
            {
                Console.Write("Введите число: ");
                isNumber = int.TryParse(Console.ReadLine(), out number);

                if (!isNumber)
                {
                    Console.WriteLine("Вы ввели не число.");
                    continue;
                }

                if (IsPositiveOdd(number))
                    sum += number;
            }
            while (!isNumber || number != 0);

            Console.WriteLine($"Сумма: {sum}");
            Console.ReadKey();
        }

        private bool IsPositiveOdd(int n)
        {
            return n > 0 && n % 2 == 1;
        }
    }
}
