namespace Calculations.Test;

using Calculations;

public class UnitTest1
{
    [Fact]
    public void TestAdd()
    {
        // Arrange phase
        var element = new Calculator();

        // Act phase
        var result = element.Add(1, 2);

        // Assert phase
        Assert.Equal(3, result);
    }
}
