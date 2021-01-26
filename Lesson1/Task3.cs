/*
    Севостьянов Денис

    а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
    б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Task3
    {
        public void Perform()
        {
            Console.Write("Введите x1: ");
            double x1 = Double.Parse(Console.ReadLine());

            Console.Write("Введите y1: ");
            double y1 = Double.Parse(Console.ReadLine());

            Console.Write("Введите x2: ");
            double x2 = Double.Parse(Console.ReadLine());

            Console.Write("Введите y2: ");
            double y2 = Double.Parse(Console.ReadLine());

            double distance = Distance(x1, y1, x2, y2);
            Console.WriteLine($"Расстояние: {distance:f2}");

            Console.ReadKey();
        }

        private double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
