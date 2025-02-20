// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;

namespace Test2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] firstWords = { "cinema", "host", "aba", "train" };
            string[] secWords = { "iceman", "shot", "bab", "rain" };

            string result =AnagramCheck(firstWords,secWords);
            Console.WriteLine("Output :" + result);
        }

        static string AnagramCheck(string[] word1, string[] word2)
        {
           var ResultBuilder = new System.Text.StringBuilder();
            
            for (int i = 0;i < word1.Length; i++)
            {
                string fWord = word1[i];
                string sWord = word2[i];

                bool CheckisAnagram = isAnagram(fWord, sWord);

                ResultBuilder.Append(CheckisAnagram ? "1" : "0");
            }
            return ResultBuilder.ToString();
        }

        static bool isAnagram(string word1, string word2)
        {
            if (word1.Length != word2.Length) return false;

            char[] chars1 = word1.ToCharArray();
            char[] chars2 = word2.ToCharArray();

            Array.Sort(chars1);
            Array.Sort(chars2);

            return chars1.SequenceEqual(chars2);
        }
    }
}
