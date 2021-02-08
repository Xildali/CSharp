/*
 * Севостьянов Денис
 * 
 * 1. Создать программу, которая будет проверять корректность ввода логина. 
 * Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
 * а) без использования регулярных выражений;
 * б) с использованием регулярных выражений.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson5
{
    class Task1
    {
        public void Perform()
        {
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();

            Console.WriteLine($"Без регулярного выражения: {WithoutRegexp(login)}");
            Console.WriteLine($"С регулярным выражением: {WithRegexp(login)}");

            Console.ReadKey();
        }

        private bool WithRegexp(string login)
        {
            Regex regex = new Regex("^[a-zA-Z][a-zA-Z0-9]{1,9}$");

            return regex.IsMatch(login);
        }

        private bool WithoutRegexp(string login)
        {
            if (login.Length < 2 || login.Length > 10)
                return false;

            if (char.IsDigit(login[0]))
                return false;

            foreach (char c in login)
            {
                if (!IsLetterOrDigit(c))
                    return false;
            }

            return true;
        }

        private bool IsLetterOrDigit(char c)
        {
            if (char.IsDigit(c) || (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                return true;

            return false;
        }
    }
}
