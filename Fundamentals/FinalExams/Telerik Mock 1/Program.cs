using System;
using System.Linq;

namespace Telerik_Mock_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num1 = int.Parse(input[0].ToString());
            int num2 = int.Parse(input[1].ToString());
            int num3 = int.Parse(input[2].ToString());

            int multy = num1 * num2 * num3;
            int sum = num1 + num2 + num3;

            int mult1 = num1 * num2 + num3;
            int mult2 = num1 + num2 * num3;
            //int mult3 = num1 * num3 + num2;
            //int mult4 = (num1 + num2) * num3;
            //int mult5 = (num1 + num3) * num2;
            //int mult6 = (num2 + num3) * num1;

            int[] numbers = { multy, sum, mult1, mult2 };

            Console.WriteLine(numbers.Max());

        }
    }
}
