using System;

namespace Abstraction
{
    public abstract class Shape
    {
        public virtual string Name => GetType().Name;
        public abstract double GetArea();
    }

    public sealed class Circle : Shape
    {
        private readonly double _radius;
        public Circle(double radius) => _radius = radius;
        public override double GetArea() => Math.PI * _radius * _radius;
    }

    public sealed class Rectangle : Shape
    {
        private readonly double _length;
        private readonly double _width;
        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }
        public override double GetArea() => _length * _width;
    }

    internal static class ShapePrinter
    {
        public static void PrintArea(Shape shape)
        {
            Console.WriteLine($"{shape.Name} area: {shape.GetArea():F2}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Abstract Classes and Methods ===\n");

            ShapePrinter.PrintArea(new Circle(5));
            ShapePrinter.PrintArea(new Rectangle(4, 6));

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
