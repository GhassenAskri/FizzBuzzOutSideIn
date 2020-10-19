using System;

namespace FizzBuzz
{
    public class FizzBuzz_generateFizzBuzzString
    {
        public string generateFizzBuzzString (int [] arrayOfNumbers)
        {
            var fizzBuzzString ="";
            var FIRST_NUMBER = arrayOfNumbers[0];


            if(isFizz(FIRST_NUMBER)){
                 fizzBuzzString ="fizz";
            }
            else{
                fizzBuzzString = convertToString(FIRST_NUMBER);
            }
             
            return fizzBuzzString;

            throw new NotImplementedException ("You have to write a test first");
        }

        public static string convertToString (int number)
        {
            return Convert.ToString(number);
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
