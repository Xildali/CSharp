using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Task5
    {
        public void Perform()
        {
            double minNormalIndex = 18.5;
            double maxNormalIndex = 25;

            Console.Write("Вес (кг): ");
            double weight = Double.Parse(Console.ReadLine());

            Console.Write("Рост (м): ");
            double height = Double.Parse(Console.ReadLine());

            double index = weight / (height * height);

            if (index < minNormalIndex)
            {
                double diff = WeightByIndex(minNormalIndex, height) - weight;
                Console.WriteLine($"Необходимо набрать {diff:F2}кг.");
            }
            else if (index > maxNormalIndex)
            {
                double diff = weight - WeightByIndex(maxNormalIndex, height);
                Console.WriteLine($"Необходимо сбросить {diff:F2}кг.");
            }
            else
            {
                Console.WriteLine("Вес в норме.");
            }

            Console.ReadKey();
        }

        private double WeightByIndex(double index, double height)
        {
            return index * height * height;
        }
    }
}
