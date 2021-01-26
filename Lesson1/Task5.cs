using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Task5
    {
        public void Perform()
        {
            string firstName = "Денис";
            string lastName = "Севостьянов";
            string city = "Курск";

            int y = (Console.WindowHeight - 3) / 2;
            int x1 = (Console.WindowWidth - firstName.Length) / 2;
            int x2 = (Console.WindowWidth - lastName.Length) / 2;
            int x3 = (Console.WindowWidth - city.Length) / 2;

            Print(firstName, x1, y);
            Print(lastName, x2, y + 1);
            Print(city, x3, y + 2);

            Console.ReadKey();
        }

        private void Print(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(message);
        }
    }
}
