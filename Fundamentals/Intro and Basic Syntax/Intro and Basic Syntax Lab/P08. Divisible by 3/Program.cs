using System;

namespace _8._Divisible_by_3
{
    internal class Program
    {
        static void Main(string[] args)
        {    //Това е 9та задача!!!!!!!!
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i+i-1);
                sum += i + i - 1;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
