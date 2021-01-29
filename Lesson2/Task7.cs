using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Task7
    {
        public void Perform()
        {
            Random random = new Random();
            int a = random.Next();
            int b = a + random.Next(1000);

            Print(a, b);
            Console.WriteLine();
            
            long sum = Sum(a, b);
            Console.WriteLine($"Сумма чисел от {a} до {b} равна {sum}.");

            Console.ReadKey();
        }

        public void Print(int a, int b)
        {
            if (a > b)
                return;

            Console.WriteLine(a);
            Print(a + 1, b);
        }

        public long Sum(int a, int b)
        {
            if (a > b)
                return 0;

            return a + Sum(a + 1, b);
        }

    }
}
