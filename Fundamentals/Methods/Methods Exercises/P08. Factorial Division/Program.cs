using System;

namespace P08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            long fac1 = 1;
            long fac2 = 1;

            for (int i = 1; i <= num1; i++)
            {
                fac1 *= i;
            }
            for (int i = 1; i <= num2; i++)
            {
                fac2 *= i;
            }
            double div = 1.0*fac1 / fac2;
            Console.WriteLine($"{div:f2}");
        }
    }
}
