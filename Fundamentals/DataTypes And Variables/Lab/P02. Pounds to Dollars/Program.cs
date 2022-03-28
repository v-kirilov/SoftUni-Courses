using System;

namespace _2._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            double mul = 1.31;
            decimal convertet = decimal.Multiply(pounds, (decimal)mul);

            Console.WriteLine($"{convertet:f3}");
        }
    }
}
