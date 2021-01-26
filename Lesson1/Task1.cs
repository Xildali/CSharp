using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Task1
    {

        public void Perform()
        {
            Console.Write("Имя: ");
            string firstName = Console.ReadLine();

            Console.Write("Фамилия: ");
            string lastName = Console.ReadLine();

            Console.Write("Возраст: ");
            string age = Console.ReadLine();

            Console.Write("Рост: ");
            string height = Console.ReadLine();

            Console.Write("Вес: ");
            string weight = Console.ReadLine();


            string a = firstName + " " + lastName + " " + age + " " + height + " " + weight;
            string b = String.Format("{0} {1} {2} {3} {4}", firstName, lastName, age, height, weight);
            string c = $"{firstName} {lastName} {age} {height} {weight}";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
