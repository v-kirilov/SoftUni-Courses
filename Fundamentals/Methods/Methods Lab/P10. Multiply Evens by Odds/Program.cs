using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            int multipleOfEvenAndOdds = GetMultipleOfEvenAndOdds(evenSum, oddSum);
            Console.WriteLine(multipleOfEvenAndOdds);


        }

        static int GetSumOfEvenDigits(int num)
        {
            int evenNum = 0;
            int sum = 0;
            num = Math.Abs(num);

            while (num > 0)
            {
                evenNum = num % 10;
                if (evenNum % 2 == 0)
                {
                    sum += evenNum;
                }
                num = num / 10;
            }

            return sum;
        }
        static int GetSumOfOddDigits(int num)
        {
            int oddNum = 0;
            int sum = 0;
            num = Math.Abs(num);

            while (num > 0)
            {
                oddNum = num % 10;
                if (oddNum % 2 == 1)
                {
                    sum += oddNum;
                }
                num = num / 10;
            }

            return sum;
        }       static int GetMultipleOfEvenAndOdds(int num1,int num2)
        {
            int sum = num1 * num2;
            return sum;
        }
    }
}
