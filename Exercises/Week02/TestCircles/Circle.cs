using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCircles
{
    class Circle
    {
        private double radius;
        private double area;
        private double diameter;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                diameter = 2 * radius;
                area = radius * radius * Math.PI;
            }
        }
        public double Area
        {
            get
            {
                return area;
            }
        }
        public double Diameter
        {
            get
            {
                return diameter;
            }
        }
        public Circle(double radius = 1)
        {
            Radius = radius;
        }
    }
}
