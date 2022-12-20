using Xunit;

namespace Refactoring.Tests;

public class GradingTest 
{
    [Fact]
    public void TestConverterEuro()
    {
        // Arrange
        int toConvertedAmount = 4;
        char expectedGrade = 'D';

        // Act
        char convertedGrade = Grading.GetLetterGrade(toConvertedAmount);
        
        // Assert
        Assert.Equal(expectedGrade, convertedGrade);
    }
}