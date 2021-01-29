/*
 * Севостьянов Денис
 * 
 * Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
 * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
 * С помощью цикла do while ограничить ввод пароля тремя попытками.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Task4
    {
        private string login = "root";
        private string password = "GeekBrains";

        public void Perform()
        {
            int attempts = 3;

            while (attempts > 0)
            {
                attempts--;

                Console.Write("Логин: ");
                string login = Console.ReadLine();

                Console.Write("Пароль: ");
                string password = Console.ReadLine();

                if (IsCorrect(login, password))
                {
                    Console.WriteLine("Вы вошли.");
                    break;
                }
                else if (attempts > 0)
                {
                    Console.WriteLine($"Неверный логин или пароль. Осталось попыток: {attempts}");
                }
                else
                {
                    Console.WriteLine("До свидания.");
                }
            }

            Console.ReadKey();
        }

        private bool IsCorrect(string user, string password)
        {
            return this.login.Equals(user) && this.password.Equals(password);
        }
    }
}
