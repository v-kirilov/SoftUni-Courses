using System;

namespace P4._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte rows = byte.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                char current = char.Parse(Console.ReadLine());
                sum += current;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
