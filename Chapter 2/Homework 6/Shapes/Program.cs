using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateCircle();
            CalculateSquare();
        }

        private static void CalculateSquare() 
        {
            Square sqr = new Square(50);
            Console.WriteLine(sqr.CalculateArea());
        }
        private static void CalculateCircle()
        {
            Circle circle = new Circle(50);
            Console.WriteLine(circle.CalculateArea());
        }

    }
}
