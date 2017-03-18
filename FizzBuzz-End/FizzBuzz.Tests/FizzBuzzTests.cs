using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Library;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        private FizzBuzzService _fizzBuzz;

        public FizzBuzzTests()
        {
            _fizzBuzz = new FizzBuzzService();
        }

        [TestMethod]
        public void ShouldPrintNumber()
        {
            var result = _fizzBuzz.Calculate(1);
            Assert.AreEqual("1", result);
        }
    }
}
