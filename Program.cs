using System;
using System.Collections.Generic;
using System.Linq;

namespace LetterCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();

            Dictionary<char, int> letterCounts = new Dictionary<char, int>();

            // Her harfin sayısını hesaplamak için döngü

            foreach (char letter in word)
            {
                if (letterCounts.ContainsKey(letter))
                {
                    letterCounts[letter]++;
                }
                else
                {
                    letterCounts.Add(letter, 1);
                }
            }

            int maxLetterLength = 0; // En uzun harf uzunluğunu saklıyouruz.
            int count = 0; // her dört sütunda bir yeni satıra geçmek için sayaç

            Console.WriteLine("Letter Counts:");

            foreach (var entry in letterCounts.OrderBy(x=>x.Key))
            {
                int letterLength = entry.Key.ToString().Length;
                if (letterLength > maxLetterLength)
                {
                    maxLetterLength = letterLength;
                }

                if (count % 4 == 0)
                {
                    Console.WriteLine();
                }

                string letter = entry.Key.ToString();
                string num = entry.Value.ToString();
                string spaces = new string(' ', maxLetterLength - letter.Length + 1);

                // Harf ve sayısını yan yana yazdırmak için düzgün bir görünüm
                Console.Write($"{letter}:{spaces}{num}\t");

                count++;
            }

            Console.ReadLine();
        }
    }
}
