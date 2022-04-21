using System;
using System.Text;

namespace P06.__Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder str = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i+1>=input.Length)
                {
                    str.Append(input[i]);
                    break;
                }
                if (input[i+1]==input[i])
                {
                    continue;
                }else
                {
                    str.Append(input[i]);
                }
            }

            Console.WriteLine(str.ToString());
        }
    }
}
