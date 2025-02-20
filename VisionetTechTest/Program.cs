// See https://aka.ms/new-console-template for more information
using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input : ");
            string input = Console.ReadLine();

            string result = Manipulate(input);
            Console.WriteLine("Output :" + result);
        }

        static string Manipulate(string input) 
        {
            int midIndex = input.Length / 2;
            
            string str1 = input.Substring(0, midIndex);
            string str2 = input.Substring(midIndex);

            char[] chars1 = str1.ToCharArray();
            Array.Reverse(chars1);
            string reversed1 = new string(chars1);

            char[] chars2 = str2.ToCharArray();
            Array.Reverse(chars2);
            string reversed2 = new string(chars2);

            string result = reversed1 + reversed2;

            return result;
        }
    }
}
