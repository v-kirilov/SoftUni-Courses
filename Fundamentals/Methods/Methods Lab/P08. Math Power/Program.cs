using System;

namespace _8._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Pow(a,b));

        }
        static double Pow(int n1, int n2)
        {
            double result = Math.Pow(n1, n2);
            return result;
        }
    }
}
