using System;

namespace _11._Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            string opera = Console.ReadLine();
            double num2 = double.Parse(Console.ReadLine());
            double sumOfElemens = CalculateTheNumbers(num1, opera, num2);
            Console.WriteLine(sumOfElemens);

        }

        static double CalculateTheNumbers(double num1, string operating, double num2)
        {
            double sum = 0;
            switch (operating)
            {
                case "+":
                    sum = num1 + num2;
                    break;
                case "-":
                    sum = num1 - num2;
                    break;
                case "*":
                    sum = num1 * num2;
                    break;
                case "/":
                    sum = num1 / num2;
                    break;
            }
            return sum;
        }
    }
}
