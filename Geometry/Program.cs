using System;
using System.Collections.Generic;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opret en liste af Shape-objekter
            List<Shape> shapes = new List<Shape>
            {
                new Square(5),
                new Rectangle(5, 8),
                new Parallelogram(5, 10),
                new Trapezoid(10, 9, 8, 9),
                new RightAngledTriangle(3, 4)
            };

            foreach (Shape shape in shapes)
            {
                double area = shape.CalculateArea();
                double perimeter = shape.CalculatePerimeter();
                Console.WriteLine($"Figur: {shape.GetType().Name}");
                Console.WriteLine($"Areal: {area}");
                Console.WriteLine($"Omkreds: {perimeter}");
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
