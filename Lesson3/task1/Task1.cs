/*
 * Севостьянов Денис
 * 
 * Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
 * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.task1
{
    class Task1
    {
        private Random random = new Random();

        public void Perform()
        {
            int a = RandomNumber();
            int b = RandomNumber();
            int c = RandomNumber();
            int d = RandomNumber();

            ComplexStruct s1 = new ComplexStruct(a, b);
            ComplexStruct s2 = new ComplexStruct(c, d);

            Console.WriteLine("Структура");
            Console.WriteLine($"{s1} + {s2} равно {s1.Plus(s2)}");
            Console.WriteLine($"{s1} - {s2} равно {s1.Minus(s2)}");

            Complex c1 = new Complex(a, b);
            Complex c2 = new Complex(c, d);

            Console.WriteLine("Класс");
            Console.WriteLine($"{c1} + {c2} равно {c1.Plus(c2)}");
            Console.WriteLine($"{c1} - {c2} равно {c1.Minus(c2)}");
            Console.WriteLine($"{c1} * {c2} равно {c1.Mult(c2)}");

            Console.ReadKey();
        }

        private int RandomNumber()
        {
            return random.Next(11) - 5;
        }
    }
}
