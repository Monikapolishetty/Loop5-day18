using System;
using Xunit;
using FluentAssertions;
using StringCalculator;

namespace StringCalculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void should_return_zero_when_empty_string()
        {
            //act
            var result = Calculator.Add("");
            //assert
            result.Should().Be(0);
        }
        [Fact]
        public void should_throw_exception_when_wrong_input_format()
        {
            //act
            Assert.Throws<ArgumentException>(() => Calculator.Add("13,4"));
        }
    }
}