using System;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzz_generateFizzBuzzString
    {
        public string generateFizzBuzzString (int [] arrayOfNumbers)
        {
            var fizzBuzzString = "";
            
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
               fizzBuzzString += convertNumberToFizzBuzzString(arrayOfNumbers[i]);
            }
           
            return fizzBuzzString;
            throw new NotImplementedException ("You have to write a test first");
        }

        public static string convertNumberToFizzBuzzString (int number){
             if (isFizzBuzz(number)){
                    return"fizzbuzz";

                }
               
                if (isFizz(number)){
                    return "fizz";
      
                }
             
                if(isBuzz(number)){
                    return "buzz";
          
                }

                return  Convert.ToString(number);
        }

        public static bool isFizz(int number)
        {
            return number % 3 == 0 ? true : false;
        }
        public static bool isBuzz(int number)
        {
            return number % 5 == 0 ? true : false;
        
        }
        public static bool isFizzBuzz(int number)
        {
            return number % 15 == 0 ? true : false;
        
        }
        
    }
}
