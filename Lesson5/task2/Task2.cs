/*
 * Севостьянов Денис
 * 
 * 2. Разработать класс Message, содержащий следующие статические методы для обработки текста:
 * а) Вывести только те слова сообщения, которые содержат не более n букв.
 * б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
 * в) Найти самое длинное слово сообщения.
 * г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
 * Продемонстрируйте работу программы на текстовом файле с вашей программой.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Task2
    {
        public void Perform()
        {
            var reader = new StreamReader("task2/text.txt");
            var text = reader.ReadToEnd();

            Console.WriteLine("Вывести только те слова сообщения, которые содержат не более n букв");
            Message.PrintWords(text, 5);

            Console.WriteLine();
            Console.WriteLine("Удалить из сообщения все слова, которые заканчиваются на заданный символ");
            Console.WriteLine(Message.RemoveWords(text, 'т'));

            Console.WriteLine();
            Console.WriteLine("Найти самое длинное слово сообщения");
            Console.WriteLine(Message.MaxWord(text));

            Console.WriteLine();
            Console.WriteLine("Сформировать строку с помощью StringBuilder из самых длинных слов сообщения");
            Console.WriteLine(Message.MaxWordsString(text));

            Console.ReadKey();
        }
    }
}
