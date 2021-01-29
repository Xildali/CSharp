using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Task4
    {
        private string user;
        private string password;

        public Task4()
        {
            user = "root";
            password = "GeekBrains";
        }

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

                if (IsCorrect(user, password))
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
            return this.user.Equals(user) && this.password.Equals(password);
        }
    }
}
