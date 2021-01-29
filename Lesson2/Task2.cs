using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Task2
    {
        public void Perform()
        {
            Random random = new Random();
            int n = random.Next() - int.MaxValue / 2;

            int digits = DigitsCount(n);

            Console.WriteLine($"Число: {n}");
            Console.WriteLine($"Цифр: {digits}");

            Console.ReadKey();
        }

        public int DigitsCount(int n)
        {
            string number = n.ToString();
            int digits = number.Length;

            if (number[0] == '-')
                digits--;

            return digits;
        }
    }
}
