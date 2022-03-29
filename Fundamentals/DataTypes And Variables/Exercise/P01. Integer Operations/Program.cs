using System;
using System.Numerics;

namespace P1._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            BigInteger sum = first + second;

            int divide = (int)sum / third;

            BigInteger multiply = divide * fourth;

            Console.WriteLine($"{multiply}");
        }
    }
}
