using Does.Stuff.With.Logic.Services;
using NUnit.Framework;

namespace Does.Stuff.Test
{
    public class SubtractionUnitTest
    {
        private Subtraction _subtraction;
        [SetUp]
        public void Setup()
        {
            _subtraction = new Subtraction();
        }

        [TestCase(1,1,0)]
        [TestCase(11, 6, 5)]
        [TestCase(45, 23, 22)]
        [TestCase(50, 20, 30)]
        public void Subtract_Two_Numbers(double numberOne, double numberTwo, double expectedResult)
        {
            var result = _subtraction.SubtractTwoNumbers(numberOne, numberTwo);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}