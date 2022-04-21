using System;
using System.Text;

namespace P07.__String_Explosion
{
    internal class Program
    {
        private static object stringBuilder;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int bombpower = 0;
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == '>')
                {
                    bombpower += (int)input[i+1]-48;
                    str.Append(ch);
                    continue;
                }
                if (bombpower>0)
                {
                    bombpower--;
                    continue;
                }else
                {
                    str.Append(ch);
                }
            }

            Console.WriteLine(str.ToString());

        }
    }
}
