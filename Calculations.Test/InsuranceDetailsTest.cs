namespace Calculations.Test;

[Collection("Seguros")]
public class InsuranceDetailsTest (InsuranceCollectorFixture collectorFixture)
{
    private readonly InsuranceCollectorFixture collectorFixture = collectorFixture;

    [Fact]
    public void Insurance_InterestRate()
    {
        // Given
        var insurance = collectorFixture.Insurance;
    
        // When
    
        // Then
    }
}