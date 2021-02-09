/*
 * Севостьянов Денис
 * 
 * Задача ЕГЭ.
 * *На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней
 * школы. В первой строке сообщается количество учеников N, которое не меньше 10, но не
 * превосходит 100, каждая из следующих N строк имеет следующий формат: <Фамилия> <Имя> <оценки>,
 * где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не
 * более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по
 * пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом.
 * Пример входной строки:
 * Иванов Петр 4 5 3
 * Требуется написать как можно более эффективную программу, которая будет выводить на экран
 * фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
 * набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
 * Достаточно решить 2 задачи. Старайтесь разбивать программы на подпрограммы. Переписывайте в
 * начало программы условие и свою фамилию. Все программы сделать в одном решении. Для решения
 * задач используйте неизменяемые строки (string)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Task4
    {
        struct Student : IComparable<Student>
        {
            public string firstName;
            public string lastName;
            public int grade;

            public int CompareTo(Student other)
            {
                return grade - other.grade;
            }

            public override string ToString()
            {
                return $"{lastName} {firstName}";
            }
        }

        public void Perform()
        {
            int n = int.Parse(Console.ReadLine());

            Student[] students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(' ');

                students[i].lastName = tokens[0];
                students[i].firstName = tokens[1];
                students[i].grade = int.Parse(tokens[2]) + int.Parse(tokens[3]) + int.Parse(tokens[4]);
            }

            Array.Sort(students);

            int lastGrade = -1;
            int count = 0;
            foreach (var student in students)
            {
                if (lastGrade == student.grade)
                    Console.WriteLine(student);
                else if (count < 3)
                {
                    count++;
                    lastGrade = student.grade;
                    Console.WriteLine(student);
                }
                else
                {
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
