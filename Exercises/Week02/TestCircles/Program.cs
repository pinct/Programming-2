using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(10);
            Circle circle2 = new Circle(0.5);
            Circle circle3 = new Circle();

            Console.WriteLine($"Circle 1 R: {circle1.Radius} D: {circle1.Diameter} A: {circle1.Area:f2}");
            Console.WriteLine($"Circle 2 R: {circle2.Radius} D: {circle2.Diameter} A: {circle2.Area:f2}");
            Console.WriteLine($"Circle 3 R: {circle3.Radius} D: {circle3.Diameter} A: {circle3.Area:f2}");
        }
    }
}
