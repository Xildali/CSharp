/*
 * Севостьянов Денис
 *
 * *а) Реализовать класс для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами. 
 * Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, 
 * возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out)
 * *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
 * Дополнительные задачи
 * в) Обработать возможные исключительные ситуации при работе с файлами.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.task4
{
    class Task4
    {
        public void Perform()
        {
            DoubleArray array = new DoubleArray(3, 4);
            Console.WriteLine($"Создан массив {array}");

            int sum = array.Sum();
            Console.WriteLine($"Сумма: {sum}");

            sum = array.Sum(5);
            Console.WriteLine($"Сумма чисел больше 5: {sum}");

            int min = array.Min;
            Console.WriteLine($"Минимальное: {min}");

            int max = array.Max;
            Console.WriteLine($"Максимальное: {max}");

            int row, col;
            array.MaxIndex(out row, out col);
            Console.WriteLine($"Индекс максимального элемента: {row},{col}");

            array.SaveToFile("array.txt");

            array = new DoubleArray("array.txt");
            Console.WriteLine($"Считали массив из файла {array}");

            Console.ReadKey();
        }
    }
}
