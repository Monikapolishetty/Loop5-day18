using System;
using Xunit;
using FluentAssertions;
using FizzBuss.Business;

namespace FizzBuzz.tests
{
    public class UnitTest1
    {
        [Fact]
        public void should_return_true_if_divisible_by_three()
        {
            var result = DivisibleCheckers.CheckIfDivisibleBy3(3);

            result.Should().Be(true);
        }
        
        [Fact]
        public void should_return_true_if_divisible_by_five()
        {
            var result = DivisibleCheckers.CheckIfDivisibleBy5(5);

            result.Should().Be(true);
        }

        [Fact]
        public void should_return_true_if_divisible_by_five_and_three()
        {
            var result = DivisibleCheckers.CheckIfDivisibleBy5and3(15);

            result.Should().Be(true);
        }
        
        [Fact]
        public void should_print_fizz()
        {
            var result = DivisibleCheckers.ReplaceThreeToFizz(15);

            result.Should().Be("fizz");
        }
        
        [Fact]
        public void should_print_buzz()
        {
            var result = DivisibleCheckers.ReplaceFiveToBuzz(15);

            result.Should().Be("buzz");
        }
        
        [Fact]
        public void should_print_fizzbuzz()
        {
            var result = DivisibleCheckers.CheckIfDivisible(15);

            result.Should().Be("fizzbuzz");
        }
        [Fact]
        public void should_print_array()
        {
            var result = DivisibleCheckers.ReturnFizzBuzzArray();

            result.Should().Contain("4");
        }
    }
}
