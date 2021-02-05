using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.task1
{
    class Task1
    {
        public void Perform()
        {
            int[] array = { 6, 2, 9, -3, 6 };

            int count = FindCountrPairs(array);

            Console.WriteLine($"Количество пар: {count}");
            Console.ReadKey();
        }

        private int FindCountrPairs(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                    count++;
            }

            return count;
        }
    }
}
