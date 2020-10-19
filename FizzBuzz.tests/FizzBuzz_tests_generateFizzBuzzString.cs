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
        [Description("When I use array of numbers equal to [1,9,10,2,0,4,15,10],"+ 
                    "I get a fizzbuzz string equal to 1 fizz buzz 2 0 4 fizzbuzz buzz")]
        public void generateFizzBuzzStringTest()
        {
            //Given
            int [] arrayOfNumbers = new int [] {1,9,10,2,0,4,15,10};
            //When
            var fizzBuzzString = _fizzBuzz.generateFizzBuzzString(arrayOfNumbers);
            //Then
            Assert.AreEqual(fizzBuzzString,"1 fizz buzz 2 0 4 fizzbuzz buzz");
        }
        
        [TestMethod]
        [Description("When I use array of numbers equal to [1],"+ 
                    "I get a fizzbuzz string equal to 1 ")]
        public void generateFizzBuzzStringTestForOneNumber()
        {
            //Given
            int [] arrayOfNumbers = new int [] {1};
            //When
            var fizzBuzzString = _fizzBuzz.generateFizzBuzzString(arrayOfNumbers);
            //Then
            Assert.AreEqual(fizzBuzzString,"1");
        }
    }
}
