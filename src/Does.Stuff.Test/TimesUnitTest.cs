using Does.Stuff.With.Logic.Services;
using NUnit.Framework;

namespace Does.Stuff.Test
{
    public class TimesUnitTest
    {
        private ITimes _times;

        [SetUp]
        public void Setup()
        {
            _times = new Times();
        }

        [TestCase(1, 1, 1)]
        [TestCase(11, 2, 22)]
        public void Times_Two_Numbers(double numberOne, double numberTwo, double expectedResult)
        {
            var result = _times.TimesTwoNumbers(numberOne, numberTwo);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}