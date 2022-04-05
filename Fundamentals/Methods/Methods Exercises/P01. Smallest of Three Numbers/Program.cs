using System;

namespace P01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Check(num1,num2,num3));
        }

        static int Check(int one, int two, int three)
        {
            int minNum = int.MaxValue;

            if (one<minNum)
            {
                minNum = one;
            }
            if (two < minNum)
            {
                minNum = two;
            }
            if (three<minNum)
            {
                minNum = three;
            }
            return minNum;
        }
    }
}
