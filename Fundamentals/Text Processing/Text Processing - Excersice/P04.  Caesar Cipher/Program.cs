using System;
using System.Text;

namespace P04.__Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder str = new StringBuilder();

            foreach (var character in input)
            {
                int num = (int)character + 3;
                char ch = (char)num;

                str.Append(ch);
            }

            Console.WriteLine(str.ToString());
        }
    }
}
