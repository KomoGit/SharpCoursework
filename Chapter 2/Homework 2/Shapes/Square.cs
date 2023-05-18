namespace Shapes
{
    public class Square:Shape
    {
        public readonly double SideLength;
        public Square(double sideLength)
        {
            SideLength = sideLength;
        }
        public override double CalculateArea() => SideLength * SideLength;
    }
}
