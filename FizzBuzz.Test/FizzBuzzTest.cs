using System;
using FizzBuzz.Lib;
using Xunit;

namespace FizzBuzz.Test
{
    public class FizzBuzzTest
    {
        [Fact]
        public void FuzzBuzz()
        {
            FizzBuzzCalc fb = new FizzBuzzCalc();
            Assert.Equal("Fizz", fb.FizzOrBuzz(3));
            Assert.Equal("Buzz", fb.FizzOrBuzz(5));
        }
    }
}
