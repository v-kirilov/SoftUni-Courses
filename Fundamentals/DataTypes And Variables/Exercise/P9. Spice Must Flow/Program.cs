using System;

namespace P9._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            double sum = 0;

            while (startingYield >= 100)
            {
                sum += startingYield-26;
                days++;
                startingYield -= 10;
            }

            if (sum>=26)
            {
                sum -= 26;
            }else
            {
                sum = 0;
            }

            Console.WriteLine(days);
            Console.WriteLine(sum);
        }
    }
}
