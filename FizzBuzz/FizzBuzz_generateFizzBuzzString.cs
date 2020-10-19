using System;

namespace FizzBuzz
{
    public class FizzBuzz_generateFizzBuzzString
    {
        public string generateFizzBuzzString (int [] arrayOfNumbers)
        {
            var fizzBuzzString ="";
            var firstNumber = arrayOfNumbers[0];

            isFizz(firstNumber) ? "fizz" :  Convert.ToString(firstNumber) ;

            throw new NotImplementedException ("You have to write a test first");
        }

        public static bool isFizz(int number)
        {
            if (number % 3 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
