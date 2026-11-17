using System;

namespace Day26.Lesson03
{
    public enum ShapeType
    {
        Circle,
        Rectangle,
        Triangle
    }

    public abstract class Shape
    {
        public abstract string Name { get; }
        public abstract double Area();

        public void Describe() => Console.WriteLine($"  {Name,-10} -> Area = {Area():F2}");
    }

    public class Circle : Shape
    {
        private readonly double _radius;
        public Circle(double radius) => _radius = radius;

        public override string Name => "Circle";
        public override double Area() => Math.PI * _radius * _radius;
    }

    public class Rectangle : Shape
    {
        private readonly double _width, _height;
        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public override string Name => "Rectangle";
        public override double Area() => _width * _height;
    }

    public class Triangle : Shape
    {
        private readonly double _baseLength, _height;
        public Triangle(double baseLength, double height)
        {
            _baseLength = baseLength;
            _height = height;
        }

        public override string Name => "Triangle";
        public override double Area() => 0.5 * _baseLength * _height;
    }

    public static class ShapeFactory
    {
        public static Shape Create(ShapeType type, double a, double b = 0)
        {
            switch (type)
            {
                case ShapeType.Circle: return new Circle(a);
                case ShapeType.Rectangle: return new Rectangle(a, b);
                case ShapeType.Triangle: return new Triangle(a, b);
                default:
                    throw new ArgumentOutOfRangeException(nameof(type));
            }
        }
    }

    public static class Lesson03_SimpleFactoryPattern
    {
        public static void Run()
        {
            Console.WriteLine("=== Lesson 03: Simple Factory Pattern ===\n");

            ShapeFactory.Create(ShapeType.Circle, 5).Describe();
            ShapeFactory.Create(ShapeType.Rectangle, 4, 6).Describe();
            ShapeFactory.Create(ShapeType.Triangle, 10, 3).Describe();

            Console.WriteLine("\nLoop me factory:");
            double total = 0;
            foreach (ShapeType t in Enum.GetValues(typeof(ShapeType)))
            {
                Shape s = ShapeFactory.Create(t, 2, 3);
                total += s.Area();
                s.Describe();
            }
            Console.WriteLine($"  Total area = {total:F2}");
        }
    }
}