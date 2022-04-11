using System;

namespace Problem_1___SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empOne = int.Parse(Console.ReadLine());
            int empTwo = int.Parse(Console.ReadLine());
            int empThree = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            if (students==0)
            {
                Console.WriteLine("Time needed: 0h.");
                return;
            }

            double newNumber = Math.Ceiling(1.0 * students / (empOne + empThree + empTwo));
            double newNumberTwo = Math.Floor(1.0 * students / (empOne + empThree + empTwo));
            int addedTime = ((int)newNumberTwo / 3);
            Console.WriteLine($"Time needed: {newNumber+addedTime}h.");
        }
    }
}
