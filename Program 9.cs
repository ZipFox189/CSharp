using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HomeWork_9
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
            List<Shape> shapes = new List<Shape>
        {
            new Circle("Small Circle", 1),
            new Square("Small Square", 2),
            new Circle("Medium Circle", 3),
            new Square("Medium Square", 4),
            new Circle("Large Circle", 5),
            new Square("Large Square", 6)
        };

            var shapesInRange = shapes.Where(shape => shape.Area() >= 10 && shape.Area() <= 100);
            using (StreamWriter writer = new StreamWriter("shapes_with_area_in_range.txt"))
            {
                foreach (Shape shape in shapesInRange)
                {
                    writer.WriteLine($"{shape.Name} ({shape.GetType().Name}): Area = {shape.Area()}");
                }
            }

            var shapesWithNameContainingA = shapes.Where(shape => shape.Name.ToLower().Contains("a"));
            using (StreamWriter writer = new StreamWriter("shapes_with_name_containing_a.txt"))
            {
                foreach (Shape shape in shapesWithNameContainingA)
                {
                    writer.WriteLine($"{shape.Name} ({shape.GetType().Name}): Area = {shape.Area()}");
                }
            }

            shapes.RemoveAll(shape => shape.Perimeter() < 5);
            Console.WriteLine("Shapes with perimeter >= 5:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.Name} ({shape.GetType().Name}): Area = {shape.Area()}, Perimeter = {shape.Perimeter()}");
            }
        }
    }

}
