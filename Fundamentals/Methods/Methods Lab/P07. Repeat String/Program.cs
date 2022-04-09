using System;

namespace _7._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(input, num));
        }
        static string RepeatString(string input, int count)
        {
            string output = null;
            for (int i = 0; i < count; i++)
            {
                output += input;
            }
            return output;

        }
    }
}
