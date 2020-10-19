using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzz.tests
{
    [TestClass]
    public class FizzBuzz_generateFizzBuzzString
    {
        private readonly FizzBuzz _fizzBuzz;
        public  int [] arrayOfNumbers;
        public FizzBuzz_generateFizzBuzzString ()
        {
            _fizzBuzz = new FizzBuzz();
            arrayOfNumbers =  new int  {1,9,10,2,0,4,15,10};
        }
        [TestMethod]
        public void generateFizzBuzzStringTest()
        {
            
            var fizzBuzzString = _fizzBuzz.generateFizzBuzzString(arrayOfNumbers);
            Assert.AreEqual(fizzBuzzString,"1 fizz buzz 2 0 4 fizzbuzz buzz");
        }
    }
}
