namespace Shapes
{
    public class Triangle : Shape
    {
        readonly double BaseLength, SideLength;
        public Triangle(double baseLength,double sideLength)
        {
            BaseLength = baseLength;
            SideLength = sideLength;
        }

        public override double CalculateArea()
        {
            return (BaseLength * SideLength) / 2;
        }
    }
}
