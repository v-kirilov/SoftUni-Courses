using System;

namespace _1._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string result = SignOfInteger(num);

            Console.WriteLine(result);

        }

        static string SignOfInteger(int number)
        {
            string sign;

            if (number > 0)
            {
                sign = "positive";
            }
            else if (number < 0)
            {
                sign = "negative";
            }
            else
            {
                sign = "zero";
            }

            return $"The number {number} is {sign}.";
        }
    }
}
