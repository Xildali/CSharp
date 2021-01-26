/*
    Севостьянов Денис

    Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Task2
    {
        public void Perform()
        {
            Console.Write("Вес: ");
            double weight = Double.Parse(Console.ReadLine());

            Console.Write("Рост: ");
            double height = Double.Parse(Console.ReadLine());

            double index = weight / (height * height);

            string output = String.Format("ИМТ: {0:0.##}", index);
            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}
