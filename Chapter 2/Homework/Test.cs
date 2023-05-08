using NUnit.Framework;
using System;

namespace Homework
{
    [TestFixture]
    internal class Test
    {
        private readonly FirstHomework first = new FirstHomework();
        [TestCase]
        public void TestHelloWorld()
        {
            string inserted = "Hello World";
            float expected = 1052;
            Assert.AreEqual(expected, first.SumASCIIValues(inserted));
        }

        [TestCase]
        public void Testhelloworld()
        {
            string inserted = "hello world";
            float expected = 1116f;
            Assert.AreEqual(expected, first.SumASCIIValues(inserted));
        }

        [TestCase]
        public void TestNull()
        {
            string inserted = default;
            Assert.Throws<Exception>(() => first.SumASCIIValues(inserted));
        }

        [TestCase]
        public void TestNothing()
        {
            string inserted = "";
            float expected = 0f;
            Assert.AreEqual(expected, first.SumASCIIValues(inserted));
        }
    }
}
