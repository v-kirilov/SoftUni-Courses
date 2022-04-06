using System;

namespace P09_Greater_of_two_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            if (type =="int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(num1,num2));
            }
            else if (type=="char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first,second));
            }else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));
            }

        }

        static int GetMax(int num1,int num2)
        {
            int greater = 0;
            if (num1>num2)
            {
                greater = num1;
                return greater;
            }
            else
            {
                greater = num2;
                return greater;
            }
        }

        static char GetMax(char first,char second)
        {
            char greater; 
            if (first>second)
            {
                greater = first;
                return greater;
            }
            else
            {
                greater = second;
                return greater;
            }
        }

        static string GetMax(string first, string second)
        {
            int sumFirst = 0;
            int sumSecond = 0;
            for (int i = 0; i < first.Length; i++)
            {
                char firstCharacters = first[i];
                char secondCharacters = second[i];

                sumFirst += firstCharacters;
                sumSecond += secondCharacters;
            }
            if (sumFirst>sumSecond)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
