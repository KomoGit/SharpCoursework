using NUnit.Framework;

namespace Homework_4.Tests
{

    [TestFixture]
    internal class MinimumMaximumTests
    {
        //private static readonly FirstHomework firstHomework = new FirstHomework();
        private static readonly SecondHomework secondHomework = new SecondHomework();

        [TestCase]
        public void MinimumMaximum()
        {
            int[] arr = { 1,2,3,4};
            int[] expected = { 1,4};
            Assert.AreEqual(expected, secondHomework.MinimumMaximum(arr));
        }
        [TestCase]
        public void NegativeAndPositiveNumber()
        {
            int[] arr = { -1,-2,-3,-4,1};
            int[] expected = { -4,1};
            Assert.AreEqual(expected,secondHomework.MinimumMaximum(arr));
        }
        [TestCase]
        public void OnlyNegativeNumbers()
        {
            int[] arr = { -1, -2,-3,-4,-5,-6,-7,0 };
            int[] expected = { -7, 0};
            Assert.AreEqual(expected,secondHomework.MinimumMaximum(arr));
        }
    }
    [TestFixture]
    internal class DiscountedPriceTest
    {
        private static readonly ThirdHomework thirdHomework = new ThirdHomework();    
        float expected;

        [TestCase]
        public void MoreThanThousand()
        {

        }

    }
    [TestFixture]
    internal class ArithmetricMeanTests
    {
        private static readonly FourthHomework fourthHomework = new FourthHomework();

        [TestCase]
        public void PositiveNumbers()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            float expected = 3f;
            Assert.AreEqual(expected, fourthHomework.ArithmeticMean(arr));
        }
        [TestCase]
        public void NegativeNumbers()
        {
            int[] arr = { -1, -2, -3, -4, -5 };
            float expected = -3f;
            Assert.AreEqual(expected, fourthHomework.ArithmeticMean(arr));
        }
        [TestCase]
        public void MixedNumbers()
        {
            int[] arr = { -1, -2, -3, 4, 5,6 };
            float expected = 1.5f;
            Assert.AreEqual(expected, fourthHomework.ArithmeticMean(arr));
        }
    }
    [TestFixture]
    internal class DetermineGradeTest
    {
        private static readonly FifthHomework FifthHomework = new FifthHomework();

        [TestCase]
        public void NumberIsNinty()
        {
            Assert.AreEqual('A',FifthHomework.DetermineGrade(90));
        }
        [TestCase]
        public void NumberIsEigty()
        {
            Assert.AreEqual('B', FifthHomework.DetermineGrade(80));
        }
        [TestCase]
        public void NumberIsSeventy()
        {
            Assert.AreEqual('C', FifthHomework.DetermineGrade(70));
        }
        [TestCase]
        public void NumberIsSixty()
        {
            Assert.AreEqual('D', FifthHomework.DetermineGrade(60));
        }
        [TestCase]
        public void NumberIsFifty()
        {
            Assert.AreEqual('F', FifthHomework.DetermineGrade(50));
        }
        [TestCase]
        public void NumberIsMinus()
        {
            Assert.AreEqual('F', FifthHomework.DetermineGrade(-10));
        }
        [TestCase]
        public void NumberIsOverHunder()
        {
            Assert.AreEqual('A',FifthHomework.DetermineGrade(110));
        }
    }
}
