using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            int a;
            Console.Write("Enter the side of the square: ");
            a = Convert.ToInt32(Console.ReadLine());
            int areaSquare = a * 2;
            int perimeter = a * 4;
            Console.WriteLine($"Perimeter of a square: {perimeter}. Area: {areaSquare}");

            Console.WriteLine("Task 2");
            string name;
            int age;
            Console.Write("What is your name? - ");
            name = Console.ReadLine();
            Console.Write($"How old are you {name}? - ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hi {name}. Your age {age}.");

            Console.WriteLine("Task 3");
            double r, length, areaCircle, volume;
            const double pi = 3.14;
            Console.Write("Enter the radius of the circle: ");
            r = Convert.ToDouble(Console.ReadLine());
            length = 2 * pi * r;
            areaCircle = pi * r * r;
            volume = 4 / 3 * pi * r * r * r;
            Console.WriteLine("Information about circle: " +
                $"length {length}, area {areaCircle}, volume {volume}");
        }
    }
}
