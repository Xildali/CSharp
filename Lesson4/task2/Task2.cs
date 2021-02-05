/*
 * Севостьянов Денис
 * 
 * а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом. 
 * Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, метод Multi, умножающий каждый элемент массива на определенное число, 
 * свойство MaxCount, возвращающее количество максимальных элементов. В Main продемонстрировать работу класса.
 * б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.task2
{
    class Task2
    {
        public void Perform()
        {
            OneArray array = new OneArray(new int[] { 1, 6, 4, 3, 5, 1, 1 });
            Console.WriteLine($"Создан массив {array}");

            int sum = array.Sum;
            Console.WriteLine($"Сумма: {sum}");

            array.Inverse();
            Console.WriteLine($"Поменяли знаки: {array}");

            array.Mult(5);
            Console.WriteLine($"Умножили на 5: {array}");

            int maxCount = array.MaxCount;
            Console.WriteLine($"Максимальных элементов: {maxCount}");

            array.SaveToFile("array.txt");

            array = new OneArray("array.txt");
            Console.WriteLine($"Считали массив из файла {array}");

            Console.ReadKey();
        }
    }
}
