using System;

namespace FizzBuzz.Lib
{
    public class FizzBuzzCalc : IFizzBuzz
    {
        /// <summary>
        /// assumin number input could be +ve or -ve
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string FizzOrBuzz(int num)
        {
            //bool variable declaration would help us later to use both condition together like fizzbuzz.
            bool fizz = num % 3 == 0;
            bool buzz = num % 5 == 0;
            if (fizz)
                return "Fizz";
            else if (buzz)
                return "Buzz";
            return null;
        }
    }
}
