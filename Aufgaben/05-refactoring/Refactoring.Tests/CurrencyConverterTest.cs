using Xunit;

namespace Refactoring.Tests;

public class CurrencyConverterTest
{
    [Fact]
    public void TestConverterEuro()
    {
        // Arrange
        double toConvertedAmount = 55;
        double expectedEuro = 52.8;
        CurrencyConverter currencyConverter = new CurrencyConverter("EUR");
        
        // Act
        double convertedAmount = currencyConverter.ConvertTo(toConvertedAmount);
        
        // Assert
        Assert.Equal(expectedEuro, convertedAmount);
    }
}