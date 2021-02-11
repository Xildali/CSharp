/*
 * Севостьянов Денис
 * 
 * Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double). 
 * Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
*/

using System;

namespace Lesson6
{
    public delegate double Function(double a, double x);

    class Task1
    {
        public void Perform()
        {
            Console.WriteLine("Таблица функции a*x^2:");
            Table(SquareFunc, 4, -2, 2);

            Console.WriteLine("Таблица функции a*sin(x):");
            Table(SinFunc, 4, -2, 2);

            Console.ReadKey();
        }

        private void Table(Function func, double a, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");

            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, func(a, x));
                x++;
            }

            Console.WriteLine("---------------------");
        }

        public static double SquareFunc(double a, double x)
        {
            return a * x * x;
        }

        public static double SinFunc(double a, double x)
        {
            return a * Math.Sin(x);
        }
    }
}
