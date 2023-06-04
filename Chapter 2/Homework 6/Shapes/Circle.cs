using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle:Shape
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
