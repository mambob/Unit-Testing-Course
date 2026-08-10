namespace Calculations.Test;

using Calculations;

public class NamesTest
{
    [Fact]
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
    public void MakeFullNAme_GivenTwoNumericStrings_ContainsNumbers()
    {
        // Given
        var element = new Names();
    
        // When
        var fullName = element.MakeFullName("12", "34");
    
        // Then
        Assert.Matches(@"\d+", fullName);
    }
}