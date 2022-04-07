using System;

namespace P09_Greater_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            if (type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(num1, num2));
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));
            }
        }

        static int GetMax(int first,int second)
        {
            return first >= second ? first : second;  //Първото по голямо ли е от второто? ако да , върни първото иначе второто
        }
        static char GetMax(char first,char second)
        {
            return first >= second ? first : second;
        }
        static string GetMax(string first,string second)
        {
            return first.CompareTo(second) >=0 ? first : second;
        }
    }
}
