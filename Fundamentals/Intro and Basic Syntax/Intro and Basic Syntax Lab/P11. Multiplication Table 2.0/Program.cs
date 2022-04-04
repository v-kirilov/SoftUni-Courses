using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num<=10)
            {
                for (int i = num2; i <= 10; i++)
                {
                    Console.WriteLine($"{num} X {i} = {num*i}");

                }
            }else
            {
                    Console.WriteLine($"{num} X {num2} = {num* num2}");
            }
        }
    }
}
