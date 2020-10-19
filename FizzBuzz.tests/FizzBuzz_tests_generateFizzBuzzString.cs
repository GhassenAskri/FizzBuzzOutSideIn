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
        

        [Description("When I use array of numbers equal to [1,9,10,2,0,4,15,10],"+ 
                    "I get a fizzbuzz string equal to 1 fizz buzz 2 0 4 fizzbuzz buzz")]
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




        [Description("When I use array of numbers that not multiple of 3 or 5,"+ 
                    "I get the same number as string ")]
        [TestMethod]
        public void generateFizzBuzzStringTestForOneNumberEqualToONE()
        {
            //Given
            int [] arrayOfNumbers = new int [] {1};
            //When
            var fizzBuzzString = _fizzBuzz.generateFizzBuzzString(arrayOfNumbers);
            //Then
            Assert.AreEqual(fizzBuzzString,"1");
        }
        [TestMethod]
        public void generateFizzBuzzStringTestForOneNumberEqualToFour()
        {
            //Given
            int [] arrayOfNumbers = new int [] {4};
            //When
            var fizzBuzzString = _fizzBuzz.generateFizzBuzzString(arrayOfNumbers);
            //Then
            Assert.AreEqual(fizzBuzzString,"4");
        }
        
        
        
        [Description("When I use array of numbers that are multiple of 3,"+ 
                    "I get fizz")]
        [TestMethod]
        public void generateFizzBuzzStringTestForOneNumberMultipleOfThreeEqualTo9()
        {
            //Given
            int [] arrayOfNumbers = new int [] {9};
            //When
            var fizzBuzzString = _fizzBuzz.generateFizzBuzzString(arrayOfNumbers);
            //Then
            Assert.AreEqual(fizzBuzzString,"fizz");
        }
        [TestMethod]
        public void generateFizzBuzzStringTestForOneNumberMultipleOfThreeEqualTo3()
        {
            //Given
            int [] arrayOfNumbers = new int [] {3};
            //When
            var fizzBuzzString = _fizzBuzz.generateFizzBuzzString(arrayOfNumbers);
            //Then
            Assert.AreEqual(fizzBuzzString,"fizz");
        }

    }
}
