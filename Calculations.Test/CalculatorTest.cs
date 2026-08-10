namespace Calculations.Test;

using Calculations;

public class CalculatorTest
{
    [Fact]
    public void Add_GivenTwoInteger_ReturnSum()
    {
        // Arrange phase
        var element = new Calculator();

        // Act phase
        var result = element.Add(1, 2);

        // Assert phase
        Assert.Equal(3, result);
    }

    [Fact]
    public void Add_GivenTwoDecimal_ReturnRoundedsum()
    {
        // Given
        var calculator = new Calculator();
    
        // When
        var result = calculator.Add(1.5m, 1.2m);
    
        // Then
        Assert.Equal(2.7m, result, precision: 2);
    }
}
