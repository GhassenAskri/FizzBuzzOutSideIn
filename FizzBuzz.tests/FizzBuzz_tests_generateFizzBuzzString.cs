using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzz.tests
{
    [TestClass]
    public class FizzBuzz_tests_generateFizzBuzzString
    {
        private readonly FizzBuzz_generateFizzBuzzString _fizzBuzz;
        public FizzBuzz_tests_generateFizzBuzzString ()
        {
            _fizzBuzz = new FizzBuzz_generateFizzBuzzString();
        }
        [TestMethod]
        public void generateFizzBuzzStringTest()
        {
            //Given
            int [] arrayOfNumbers = new int [] {1,9,10,2,0,4,15,10};
            //When
            var fizzBuzzString = _fizzBuzz.generateFizzBuzzString(arrayOfNumbers);
            //Then
            Assert.AreEqual(fizzBuzzString,"1 fizz buzz 2 0 4 fizzbuzz buzz");
        }
    }
}
