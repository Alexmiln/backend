using System;

namespace Calculator
{
    class Program
    {
        //private enum Operations
        //{

        //    Plus = '+',
        //    Minus = '-',
        //    Divide = '/',
        //    Multiple = '*'
        //}

        private static double Sum(double arg1, double arg2)
        {
            return arg1 + arg2;
        }

        private static double Substract(double arg1, double arg2)
        {
            return arg1 - arg2;
        }

        private static double Divide(double arg1, double arg2)
        {
            return arg1 / arg2;
        }

        private static double Multiple(double arg1, double arg2)
        {
            return arg1 * arg2;
        }

        public static void Main(string[] args)
        {
            double arg1, arg2;
            string a, b, c;

            Console.WriteLine("Type the first number: ");
            a = Console.ReadLine();
            while (!double.TryParse(a, out arg1))
            {
                Console.Write("This is not valid. Please enter a number: ");
                a = Console.ReadLine();
            }

            Console.WriteLine("Type the second number: ");
            b = Console.ReadLine();
            while (!double.TryParse(b, out arg2))
            {
                Console.WriteLine("This is not valid. Please enter a number: ");
                b = Console.ReadLine();
            }

            Console.WriteLine("Choose an operation (+, -, *, /):");
            c = Console.ReadLine();

            switch (c)
            {
                case "+":
                    Console.WriteLine($"Result: {arg1} + {arg2} = " + Sum(arg1, arg2));
                    break;
                case "-":
                    Console.WriteLine($"Result: {arg1} - {arg2} = " + Substract(arg1, arg2));
                    break;
                case "/":
                    if (arg2 != 0)
                    {
                        Console.WriteLine($"Result: {arg1} / {arg2} = " + Divide(arg1, arg2));
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{arg1} cannot be divided by zero!");
                        break;
                    }
                case "*":
                    Console.WriteLine($"Result: {arg1} * {arg2} = " + Multiple(arg1, arg2));
                    break;
                default:
                    Console.WriteLine("Try again");
                    break;
            }
        }
    }
}
