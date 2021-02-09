using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson5
{
    class Message
    {
        public static readonly char[] SEPARATORS = new char[] { ',', '.', '!', '?', ' ', ';' };

        public static void PrintWords(string text, int n)
        {
            var regex = new Regex($"\\b\\w{{1,{n}}}\\b");
            var words = regex.Matches(text);

            Console.WriteLine(words.Count);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }

        public static string RemoveWords(string text, char c)
        {
            var regex = new Regex($"\\b\\w*{c}\\b");
            var result = regex.Replace(text, "");

            return result;
        }

        public static string MaxWord(string text)
        {
            var words = text.Split(SEPARATORS, StringSplitOptions.RemoveEmptyEntries);
            var maxWord = words[0];

            foreach (var word in words)
            {
                if (word.Length > maxWord.Length)
                    maxWord = word;
            }

            return maxWord;
        }

        public static string MaxWordsString(string text)
        {
            var words = text.Split(SEPARATORS, StringSplitOptions.RemoveEmptyEntries);
            var maxLength = 0;
            var builder = new StringBuilder();

            foreach (var word in words)
            {
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                    builder.Clear();
                    builder.Append(word);
                }
                else if (word.Length == maxLength)
                {
                    builder.Append(", ").Append(word);
                }
            }

            return builder.ToString();
        }
    }
}
