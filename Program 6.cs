using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    class Program
    {
        static int Div(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }

        static double Div(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }

        static int ReadNumber(int start, int end)
        {
            Console.Write($"Enter a number between {start} and {end}: ");
            int num;
            if (!int.TryParse(Console.ReadLine(), out num))
            {
                throw new ArgumentException("Invalid input format. Please enter an integer number.");
            }
            if (num < start || num > end)
            {
                throw new ArgumentOutOfRangeException("Number is out of range.");
            }
            return num;
        }


        static void Main()
        {
            try
            {
                Console.Write("Enter first integer number: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter second integer number: ");
                int b = int.Parse(Console.ReadLine());

                int result = Div(a, b);
                Console.WriteLine("Result: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                int[] numbers = new int[10];
                int start = 1;
                int end = 100;

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = ReadNumber(start, end);
                    start = numbers[i] + 1;
                }

                Console.WriteLine("Numbers entered:");
                foreach (int num in numbers)
                {
                    Console.Write(num + " ");
                }
            }
            catch (ArgumentException ex) when (!(ex is ArgumentOutOfRangeException))
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
