using System;

namespace _6._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(SquareArea(a,b));
        }
        static int SquareArea(int num1, int num2)
        {
            int sum = num1 * num2;
            return sum;
        }
    }
}
