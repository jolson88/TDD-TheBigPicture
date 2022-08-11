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
            Assert.AreEqual("1", _fizzBuzz.Print(1));
        }
    }
}
