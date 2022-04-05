using System;

namespace P05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = SumMethod(num1, num2);
            int diff = DifferenceMethod(sum, num3);
            Console.WriteLine(diff);
            //end
        }

        static int SumMethod(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        static int DifferenceMethod(int num1, int num2)
        {
            int diff = num1 - num2;
            return diff;
        }



    }
}
