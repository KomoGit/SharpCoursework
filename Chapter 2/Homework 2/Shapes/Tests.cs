using NUnit.Framework;

namespace Shapes
{
    [TestFixture]
    internal class Tests
    {       
        [Test]
        public void CalculateSquare()
        {
            Square sqr = new Square(50);
            double expected = 2500;
            Assert.AreEqual(expected, sqr.CalculateArea());
        }
        [Test]
        public void CalculateCircle()
        {
            Circle circle = new Circle(50);
            double expected = 7854;
            Assert.AreEqual(expected,circle.CalculateArea());
        }
        [Test]
        public void CalculateTriangle()
        {
            Triangle tri = new Triangle(50,50);
            double expected = 1250;
            Assert.AreEqual(expected,tri.CalculateArea());
        }
    }
}
