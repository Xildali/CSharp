/*
 * Севостьянов Денис
 * 
 * Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
 * а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
 * б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
 * в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр.
*/

using System;
using System.Collections.Generic;
using System.IO;

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

            double min = Min(choice.Func, choice.A, choice.B, choice.Step);

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

        private double Min(Function func, double a, double b, double step)
        {
            SaveFunc("data.bin", func, a, b, step);
            double min;
            Load("data.bin", out min);

            return min;
        }

        private void SaveFunc(string fileName, Function func, double a, double b, double step)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(func(x));
                x += step;
            }

            bw.Close();
            fs.Close();
        }
        private double[] Load(string fileName, out double min)
        {
            List<double> values = new List<double>();

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);

            min = double.MaxValue;
            double d;

            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                values.Add(d);
                if (d < min) min = d;
            }

            bw.Close();
            fs.Close();

            return values.ToArray();
        }
    }
}
