using System;

namespace P7._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const byte capacity = 255;

            int sum = 0;
            int lines = int.Parse(Console.ReadLine());
            int pour = 0;

            for (int i = 0; i < lines; i++)
            {
                pour = int.Parse(Console.ReadLine());
                if (sum + pour > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += pour;
                }
            }
            if (sum <= capacity)
            {
                Console.WriteLine(sum);
            }
        }
    }
}
