using System;

namespace ShapesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricFigure test1 = new Square(4);
            DisplayData(test1);
        }
        static void DisplayData(GeometricFigure figure)
        {
            Console.WriteLine($"{figure.Height} {figure.Width} {figure.Area}");
        }
    }
    abstract class GeometricFigure
    {
        private double area;
        private double height;
        private double width;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
                area = ComputeArea();
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                area = ComputeArea();
            }
        }
        public double Area
        {
            get
            {
                return area;
            }
        }
        abstract public double ComputeArea();
    }
    class Rectangle : GeometricFigure
    {
        public override double ComputeArea()
        {
            return Height * Width;
        }
    }
    class Square : Rectangle
    {
        public Square(double length, double width)
        {
            width = length;
            Width = width;
            Height = length;
        }
        public Square(double length)
        {
            Width = length;
            Height = length;
        }
    }
    class Triangle : GeometricFigure
    {
        public override double ComputeArea()
        {
            return Width * Height * 0.5;
        }
    }
}
