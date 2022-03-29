using System;

namespace I._Integer_and_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal meters = decimal.Parse(Console.ReadLine());
            if (meters == 0)
            {
                Console.WriteLine("0");
            }else
            {
                Console.WriteLine($"{meters / 1000:f2}");

            }

        }
    }
}
