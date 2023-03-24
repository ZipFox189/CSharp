using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork_8
{
    public abstract class Shape
    {
        public string Name { get; }
        public abstract double Area();
        public abstract double Perimeter();

        public Shape(string name)
        {
            Name = name;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; }
        public override double Area() => Math.PI * Radius * Radius;
        public override double Perimeter() => 2 * Math.PI * Radius;

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }
    }

    public class Square : Shape
    {
        public double Side { get; }
        public override double Area() => Side * Side;
        public override double Perimeter() => 4 * Side;

        public Square(string name, double side) : base(name)
        {
            Side = side;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Enter data for shape {i}:");
                Console.Write("Shape name: ");
                string name = Console.ReadLine();
                Console.Write("Shape type (1 for Circle, 2 for Square): ");
                int shapeType = int.Parse(Console.ReadLine());

                if (shapeType == 1)
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(name, radius));
                }
                else if (shapeType == 2)
                {
                    Console.Write("Side: ");
                    double side = double.Parse(Console.ReadLine());
                    shapes.Add(new Square(name, side));
                }
            }

            Console.WriteLine("Shapes entered:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}, Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
            }

            Shape shapeWithLargestPerimeter = shapes[0];
            for (int i = 1; i < shapes.Count; i++)
            {
                if (shapes[i].Perimeter() > shapeWithLargestPerimeter.Perimeter())
                {
                    shapeWithLargestPerimeter = shapes[i];
                }
            }
            Console.WriteLine($"Shape with largest perimeter: {shapeWithLargestPerimeter.Name}");

            shapes.Sort();
            Console.WriteLine("Shapes sorted by area:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}, Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
            }
        }
    }

}
