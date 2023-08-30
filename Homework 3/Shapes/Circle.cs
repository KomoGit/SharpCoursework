using System;

namespace Shapes
{
    public class Circle : Shape
    {
        public readonly double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            return Math.Ceiling(area);  
        }
    }
}
