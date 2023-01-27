using Xunit;
using System;

namespace Code.Kata;

public class FizzBuzzTest {
    FizzBuzz fizzBuzz = new FizzBuzz();
    [Fact]
    public void FizzBuzzShouldReturnNormalNumbers() {
        Assert.Equal("1", fizzBuzz.Check(1));
        Assert.Equal("2", fizzBuzz.Check(2));     
    }

    [Fact]
    public void FizzBuzzShouldReturnFizzIfNumberIsDivisibleByThree() {
       Assert.Equal("Fizz", fizzBuzz.Check(3));
    }

    [Fact]
    public void FizzBuzzShouldReturnBuzzIfNumberIsDivisibleByFive() {
       Assert.Equal("Buzz", fizzBuzz.Check(5));
    }

    [Fact]
    public void FizzBuzzShouldReturnFizzBuzzIfNumberIsDivisibleByFifteen() {
       Assert.Equal("FizzBuzz", fizzBuzz.Check(15));
    }

    [Fact]
    public void FizzBuzzShouldOutputAllTheCorrectValues() {
        Assert.Equal(100, fizzBuzz.Count(100));
    }


} 