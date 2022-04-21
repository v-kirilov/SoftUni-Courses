using System;

namespace P05.__Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal first = decimal.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());

            Console.WriteLine(first * (decimal)second);

        }
    }
}
