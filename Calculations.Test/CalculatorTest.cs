namespace Calculations.Test;

using Calculations;

public class CalculatorFixture
{
    public Calculator calc = new();
}

public class CalculatorTest : IClassFixture<CalculatorFixture>
{
    private readonly CalculatorFixture _calculatorFixture;

    public CalculatorTest(ITestOutputHelper testOutput, CalculatorFixture calculatorFixture)
    {
        _calculatorFixture = calculatorFixture;
        _testOutput = testOutput;
    }

    private readonly ITestOutputHelper _testOutput;

    [Fact]
    [Trait("Category", "Calcs")]
    public void Add_GivenTwoInteger_ReturnSum()
    {
        // Arrange phase
        var element = _calculatorFixture.calc;

        // Act phase
        var result = element.Add(1, 2);

        // Assert phase
        Assert.Equal(3, result);
    }

    [Fact]
    [Trait("Category", "Calcs")]
    public void Add_GivenTwoDecimal_ReturnRoundedsum()
    {
        // Given
        var calculator = _calculatorFixture.calc;
    
        // When
        var result = calculator.Add(1.5m, 1.2m);
    
        // Then
        Assert.Equal(2.7m, result, precision: 2);
    }

    [Fact]
    [Trait("Category", "Calcs")]
    public void UnTreh_WhenCaling_ReturnThree()
    {
        // Given
        var calculator = _calculatorFixture.calc;
    
        // When
        var result = calculator.UnTreh();
    
        // Then
        _testOutput.WriteLine("Poca consistencia, un treh");
        Assert.InRange(result, 0, 5);
    }
}
