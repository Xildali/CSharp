/*
 * Севостьянов Денис
 * 
 * 3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
 * а) с использованием методов C#;
 * б) *разработав собственный алгоритм.
 * Например:
 * badc являются перестановкой abcd.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Task3
    {
        public void Perform()
        {
            Console.Write("Введите первую строку: ");
            var s1 = Console.ReadLine();

            Console.Write("Введите вторую строку: ");
            var s2 = Console.ReadLine();

            Console.WriteLine();
            if (IsPermutation(s1, s2))
                Console.WriteLine("Одна строка является перестановкой другой");
            else
                Console.WriteLine("Одна строка не является перестановкой другой");

            Console.ReadKey();
        }

        public bool IsPermutation(string s1, string s2)
        {
            var symbols1 = s1.ToCharArray();
            var symbols2 = s2.ToCharArray();

            Array.Sort(symbols1);
            Array.Sort(symbols2);

            return symbols1.SequenceEqual(symbols2);
        }
    }
}
