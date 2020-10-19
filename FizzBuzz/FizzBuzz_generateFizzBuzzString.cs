using System;

namespace FizzBuzz
{
    public class FizzBuzz_generateFizzBuzzString
    {
        public string generateFizzBuzzString (int [] arrayOfNumbers)
        {
            
            var firstNumber = arrayOfNumbers[0];

            return isFizz(firstNumber) ? "fizz" :  Convert.ToString(firstNumber) ;

            throw new NotImplementedException ("You have to write a test first");
        }

        public static bool isFizz(int number)
        {
            return number % 3 == 0 ? true : false;
        
        }
    }
}
