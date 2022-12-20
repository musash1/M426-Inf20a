using System.Threading;
using Xunit;

namespace Refactoring.Tests;

public class FibonacciTest
{
    [Fact]
    public void TestFirstFibonacciNumberIsOne()
    {
        // TODO: write test
    }

    [Fact]
    public void TestBigFibonacciNumber()
    {
        // Arrange
        int n = 45; 
        long expected = 1134903170;

        // Act
        long actual = Fibonacci.Fib(n);

        // Assert
        Assert.Equal(expected, actual);
    }
}