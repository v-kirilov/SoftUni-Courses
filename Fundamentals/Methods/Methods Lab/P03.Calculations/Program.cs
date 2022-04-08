using System;

namespace _3.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string sign = Console.ReadLine();
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            //Calculation(sign, num1, num2);
            string result;
            result = Calculation(sign, num1, num2);
            Console.WriteLine(result);
        }

        static string Calculation(string sign,double num1,double num2)
        {
            double result=0;
            switch (sign)
            {
                case "add":
                    result = num1 + num2;
                    break;
                case "multiply":
                    result = num1 * num2;
                    break;
                case "subtract":
                    result = num1 - num2;
                    break;
                case "divide":
                    result = num1 / num2;
                    break;
            }

            return $"{result}";
            //Console.WriteLine(result);
        }
    }
}
