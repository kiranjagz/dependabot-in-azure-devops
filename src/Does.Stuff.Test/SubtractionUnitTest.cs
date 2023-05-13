using Does.Stuff.With.Logic.Services;
using NUnit.Framework;

namespace Does.Stuff.Test
{
    public class AdditionUnitTest
    {
        private Addition _addition;
        [SetUp]
        public void Setup()
        {
            _addition = new Addition();
        }

        [TestCase(1,1,2)]
        [TestCase(10, 11, 21)]
        [TestCase(45, 23, 68)]
        public void Add_Two_Numbers(double numberOne, double numberTwo, double expectedResult)
        {
            var result = _addition.AddTwoNumbers(numberOne, numberTwo);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}