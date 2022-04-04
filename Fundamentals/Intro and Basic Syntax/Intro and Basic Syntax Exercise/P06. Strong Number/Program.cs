using System;

namespace _6._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int num = int.Parse(Console.ReadLine());
            int firstNumber = num;
            int sum = 0;
            int factorial = 1;
            while (num!=0)
            {
                factorial = 1;
                int divider = num % 10;
                for (int i = 1; i <= divider; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
                num /= 10;
            }
            if (sum == firstNumber)
            {
                Console.WriteLine("yes");
            }else
            {
                Console.WriteLine("no");
            }

        }
    }
}
