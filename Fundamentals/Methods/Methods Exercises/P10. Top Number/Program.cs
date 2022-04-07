using System;

namespace P10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < num; i++)
            {
                bool isDivisible = DivisibleBy8(i);
                bool isOdd = CheckForOneOddDigit(i);
                if (isOdd && isDivisible)
                {
                    Console.WriteLine(i);
                }
            }
        }


        static bool DivisibleBy8(int num)
        {
            int sum = 0;
            string numString=num.ToString();
            for (int i = 0; i < numString.Length; i++)
            {
                int digit = int.Parse(numString[i].ToString());
                sum += digit;
            }
         
            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool CheckForOneOddDigit(int num)
        {
            string inputNum = num.ToString();
            for (int i = 0; i < inputNum.Length; i++)
            {
                int digit = int.Parse(inputNum[i].ToString());
                if (digit % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
