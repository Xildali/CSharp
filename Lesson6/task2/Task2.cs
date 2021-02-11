/*
 * Севостьянов Денис
 * 
 * Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
 * а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
 * б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
 * в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр.
*/

using System;

namespace Lesson6.task2
{
    public delegate double Function(double x);

    class Task2
    {
        private Function[] functions;
        private string[] titles;

        public Task2()
        {
            functions = new Function[]
            {
                (double x) => x,
                (double x) => x * x,
                (double x) => x * x * x,
                (double x) => Math.Sin(x),
                (double x) => Math.Cos(x)
            };

            titles = new string[]
            {
                "x",
                "x^2",
                "x^3",
                "sin(x)",
                "cos(x)"
            };
        }

        public void Perform()
        {
            Choice choice = GetChoice();

            double min;
            Finder finder = new Finder(choice);
            finder.Min(out min);

            Console.WriteLine($"Минимум функции на заданном отрезке: {min:0.##}");
            Console.ReadKey();
        }

        private Choice GetChoice()
        {
            Console.WriteLine("Выберете функцию:");
            for (int i = 0; i < titles.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {titles[i]}");
            }

            int funcIndex = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Введите <начало отрезка> <конец отрезка> <шаг>:");
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');
            double a = double.Parse(tokens[0]);
            double b = double.Parse(tokens[1]);
            double step = double.Parse(tokens[2]);

            return new Choice(functions[funcIndex], a, b, step);
        }
    }
}
