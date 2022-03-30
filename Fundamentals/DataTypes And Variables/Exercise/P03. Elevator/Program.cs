using System;

namespace P3._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double total = Math.Ceiling(1.0 * people / capacity);

            Console.WriteLine(total);
        }
    }
}
