using System;

namespace _2._Passed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num = float.Parse(Console.ReadLine());
            if (num >= 3)
            {
                Console.WriteLine("Passed!");
            }else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
