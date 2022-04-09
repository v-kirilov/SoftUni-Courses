using System;

namespace _4.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number-1; i++)
            {
                StartTree(i);
            }
            StartTree(number); // Принтим тук средата
            for (int j = number-1; j >0 ; j--)
            {
                StartTree(j);
            }
        }
        static void StartTree(int num)
        {
            
            for (int i = 1; i <= num; i++)
            {
                Console.Write($"{i} ");
                
            }
            Console.WriteLine();
        }
    }
}
