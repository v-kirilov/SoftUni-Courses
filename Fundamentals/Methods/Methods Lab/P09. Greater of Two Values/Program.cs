using System;

namespace _9._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            switch (input)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(CompareInt(num1, num2));
                    break;
                case "char":
                    string firstLetter = Console.ReadLine();
                    string secondLetter = Console.ReadLine();
                    char a = firstLetter[0];
                    char b = secondLetter[0];
                    Console.WriteLine(CompareChar(a, b));
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    Console.WriteLine(CompareString(firstString,secondString));
                    break;
            }
        }
        static int CompareInt(int num1, int num2)
        {
            int result = 0;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }
        static char CompareChar(char a, char b)
        {
            char newChar;
            int number1 = (int)a;
            int number2 = (int)b;
            if (number1 > number2)
            {
                newChar = a;
            }
            else
            {
                newChar = b;
            }
            return newChar;
        }
        static string CompareString(string firstString, string secondString)
        {
            string result = null;
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < firstString.Length; i++)
            {
                char letterFirst = firstString[i];
                char letterSecond = secondString[i];
                sum1 += (int)letterFirst;
                sum2 += (int)letterSecond;
                if (sum1>sum2)
                {
                    result = firstString;
                }
                else
                {
                    result = secondString;
                }
            }

            return result;
        }

    }
}
