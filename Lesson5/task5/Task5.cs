/*
 * Севостьянов Денис
 * 
 *  **Написать игру «Верю. Не верю». В файле хранятся вопрос и ответ, правда это или нет. 
 *  Например: «Шариковую ручку изобрели в древнем Египте», «Да». Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задаёт их игроку. 
 *  Игрок отвечает Да или Нет на каждый вопрос и набирает баллы за каждый правильный ответ. Список вопросов ищите во вложении или воспользуйтесь интернетом.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Task5
    {
        struct Question
        {
            public string question;
            public string answer;

            public bool IsRight(string answer)
            {
                return this.answer.Equals(answer.ToLower());
            }
        }

        public void Perform()
        {
            Question[] questions = LoadQuestions();

            int n = 5;
            int count = 0;
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                int index = random.Next(questions.Length);
                Console.WriteLine(questions[index].question);
                Console.Write("Верно? ");

                string answer = Console.ReadLine();
                if (questions[index].IsRight(answer))
                    count++;
            }

            Console.WriteLine($"Вы угадали {count} из {n}");
            Console.ReadKey();
        }

        private Question[] LoadQuestions()
        {
            Question[] questions;

            using (var reader = new StreamReader("task5/questions.txt"))
            {
                int n = int.Parse(reader.ReadLine());
                questions = new Question[n];

                for (int i = 0; i < n; i++)
                {
                    string line = reader.ReadLine();

                    if (line.Contains("(нет)"))
                    {
                        questions[i].question = line.Substring(0, line.Length - 5);
                        questions[i].answer = "нет";
                    }
                    else
                    {
                        questions[i].question = line.Substring(0, line.Length - 4);
                        questions[i].answer = "да";
                    }
                }
            }

            return questions;
        }
    }
}
