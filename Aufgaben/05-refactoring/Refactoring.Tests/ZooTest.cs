using Xunit;
using Refactoring.Animals;

namespace Refactoring.Tests;

public class ZooTest
{
    [Fact]
    public void TestMakeNoise()
    {
        // Arrange
        string expected = "Bello says 'woof'";

        // Act
        string actualNoise = Zoo.MakeNoise(new Dog("Bello"));

        // Assert
        Assert.Equal(expected, actualNoise);
    }
}