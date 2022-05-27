using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuss.Business
{
    public static class DivisibleCheckers
    {
        public static bool CheckIfDivisibleBy3(int i) => i % 3 == 0;

        public static bool CheckIfDivisibleBy5(int i) => i % 5 == 0;

        public static bool CheckIfDivisibleBy5and3(int i) => CheckIfDivisibleBy3(i) && CheckIfDivisibleBy5(i);

        public static string ReplaceThreeToFizz(int i)
        {
            if (CheckIfDivisibleBy3(i)) return "fizz";
            return i.ToString();
        }
        
        public static string ReplaceFiveToBuzz(int i)
        {
            if (CheckIfDivisibleBy5(i)) return "buzz";
            return i.ToString();
        }

        public static string CheckIfDivisible(int i)
        {
            if (CheckIfDivisibleBy5(i) && CheckIfDivisibleBy3(i)) return "fizzbuzz";
            if (CheckIfDivisibleBy5(i)) return "buzz";
            if (CheckIfDivisibleBy3(i)) return "fizz";
            return i.ToString();
        }
        public static string[] ReturnFizzBuzzArray()
        {
            int[] arrayOfNumbers = Enumerable.Range(1, 100).ToArray();
            var result = arrayOfNumbers.Select(nb => CheckIfDivisible(nb)).ToArray();
            return result;
        }
    }
}
