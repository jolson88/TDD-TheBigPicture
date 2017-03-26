using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Library;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        private FizzBuzzService _fizzBuzz;

        public FizzBuzzTests()
        {
            _fizzBuzz = new FizzBuzzService();
        }

        [TestMethod]
        public void ShouldPrintNumber()
        {
            Assert.AreEqual("1", _fizzBuzz.Print(1));
        }

        [TestMethod]
        public void ShouldPrintFizz()
        {
            Assert.AreEqual("Fizz", _fizzBuzz.Print(3));
        }

        [TestMethod]
        public void ShouldPrintBuzz()
        {
            Assert.AreEqual("Buzz", _fizzBuzz.Print(5));
            Assert.AreEqual("Buzz", _fizzBuzz.Print(10));
        }

        [TestMethod]
        public void ShouldPrintFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", _fizzBuzz.Print(15));
        }
    }
}
