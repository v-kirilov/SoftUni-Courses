using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            int currentNum = 0;
            bool isSpecial = false;

            for (int i = 1; i <= endNumber; i++)
            {
                currentNum = i;
                int sum = 0;

                while (currentNum > 0)
                {
                    sum += currentNum % 10;
                    currentNum = currentNum / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecial);

                //i = currentNum;
            }

        }
    }
}
