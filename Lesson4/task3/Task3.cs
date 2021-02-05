/*
 * Севостьянов Денис
 * 
 * Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.task3
{
    class Task3
    {
        private Account[] accounts;

        public Task3()
        {
            LoadAccounts();
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

        private void LoadAccounts()
        {
            Reader reader = new Reader("task3/accounts.txt");

            int count = reader.NextInt();
            accounts = new Account[count];

            for (int i = 0; i < count; i++)
            {
                string line = reader.NextString();
                string[] words = line.Split(' ');

                if (words.Length != 2)
                {
                    reader.Close();
                    throw new InvalidDataException("Неверный формат.");
                }

                accounts[i] = new Account(words[0], words[1]);
            }

            reader.Close();
        }

        private bool IsCorrect(string login, string password)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                Account account = accounts[i];

                if (account.login.Equals(login) && account.password.Equals(password))
                    return true;
            }

            return false;
        }
    }
}
