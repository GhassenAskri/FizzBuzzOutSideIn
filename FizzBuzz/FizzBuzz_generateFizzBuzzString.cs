using System;

namespace FizzBuzz
{
    public class FizzBuzz_generateFizzBuzzString
    {
        public string generateFizzBuzzString (int [] arrayOfNumbers)
        {
            var fizzBuzzString ="";
            var firstNumber = arrayOfNumbers[0];


            if(isFizz(firstNumber)){
                 fizzBuzzString ="fizz";
            }
            else{
                fizzBuzzString = Convert.ToString(firstNumber);
            }
             
            return fizzBuzzString;

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
