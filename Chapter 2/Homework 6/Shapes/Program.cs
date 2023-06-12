using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Program
    {
        static int[] a = { 1, 2, 3, };
        static void Main(string[] args)
        {
            int a = default;
            Console.WriteLine(a);
            //CalculateCircle();
            //CalculateSquare();
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
        //int a  =5 : int b = 5;
        
        
    }
}
