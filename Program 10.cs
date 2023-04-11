using System;
using System.Collections.Generic;

namespace HomeWork_10
{

    struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }
    }

    class Triangle
    {
        public Point vertex1;
        public Point vertex2;
        public Point vertex3;

        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;
        }

        public double Distance(Point p1, Point p2)
        {
            int dx = p2.x - p1.x;
            int dy = p2.y - p1.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public double Perimeter()
        {
            return Distance(vertex1, vertex2) + Distance(vertex2, vertex3) + Distance(vertex3, vertex1);
        }

        public double Square()
        {
            double a = Distance(vertex1, vertex2);
            double b = Distance(vertex2, vertex3);
            double c = Distance(vertex3, vertex1);
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public void Print()
        {
            Console.WriteLine($"Triangle with vertices {vertex1}, {vertex2}, {vertex3} has perimeter {Perimeter()} and square {Square()}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();

            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 0);
            Point p3 = new Point(0, 4);
            Triangle t1 = new Triangle(p1, p2, p3);
            triangles.Add(t1);

            p1 = new Point(1, 1);
            p2 = new Point(5, 1);
            p3 = new Point(3, 4);
            Triangle t2 = new Triangle(p1, p2, p3);
            triangles.Add(t2);

            p1 = new Point(-2, -3);
            p2 = new Point(-1, -1);
            p3 = new Point(2, -2);
            Triangle t3 = new Triangle(p1, p2, p3);
            triangles.Add(t3);

            double minDistance = double.MaxValue;
            int closestTriangleIndex = -1;
            for (int i = 0; i < triangles.Count; i++)
            {
                double distanceToOrigin = triangles[i].Distance(new Point(0, 0), triangles[i].vertex1);
                if (distanceToOrigin < minDistance)
                {
                    minDistance = distanceToOrigin;
                    closestTriangleIndex = i;
                }
            }

            Console.WriteLine("All triangles:");
            foreach (Triangle t in triangles)
            {
                t.Print();
            }

            Console.WriteLine($"Triangle closest to the origin is {triangles[closestTriangleIndex]} with distance {minDistance}.");
        }
    }


}
