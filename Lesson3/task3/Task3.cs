/*
 * Севостьянов Денис
 * 
 * *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
 * Написать программу, демонстрирующую все разработанные элементы класса. Достаточно решить 2 задачи. Все программы сделать в одном решении.
 * ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); Добавить упрощение дробей.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.task3
{
    class Task3
    {
        private Random random = new Random();

        public void Perform()
        {
            RationalFraction r1 = new RationalFraction(RandomNumber(), RandomNumber());
            RationalFraction r2 = new RationalFraction(RandomNumber(), RandomNumber());

            Console.WriteLine($"{r1} + {r2} равно {r1.Plus(r2)}");
            Console.WriteLine($"{r1} - {r2} равно {r1.Minus(r2)}");
            Console.WriteLine($"{r1} / {r2} равно {r1.Mult(r2)}");
            Console.WriteLine($"{r1} * {r2} равно {r1.Div(r2)}");

            Console.ReadKey();
        }

        private int RandomNumber()
        {
            return random.Next(11);
        }
    }
}
