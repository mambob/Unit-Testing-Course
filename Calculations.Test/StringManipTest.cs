namespace Calculations.Test;

using Calculations;
using FluentAssertions;

public class NamesTest
{
    [Fact]
    [Trait("Category", "Names")]
    public void MakefullName_GivenTwoStrings_ReturnFullname()
    {
        // Given
        var element = new Names();
    
        // When
        var fullName = element.MakeFullName(
            firstName: "Pepe",
            surname: "Botin");
    
        // Then
        Assert.Contains(
            "Tin",
            fullName,
            comparisonType: StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    [Trait("Category", "Names")]
    public void MakeFullNAme_GivenTwoNumericStrings_ContainsNumbers()
    {
        // Given
        var element = new Names();
    
        // When
        var fullName = element.MakeFullName("12", "34");
    
        // Then
        Assert.Matches(@"\d+", fullName);
        fullName.Should().Be("12 34");
    }

    [Fact]
    [Trait("Category", "Names")]
    public void TestName()
    {
        // Given
    
        // When
    
        // Then
    }
}