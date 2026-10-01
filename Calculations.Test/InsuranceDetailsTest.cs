namespace Calculations.Test;

[Collection("Seguros")]
public class InsuranceDetailsTest
{
    private readonly InsuranceCollectionFixture _collectorFixture;

    public InsuranceDetailsTest(InsuranceCollectionFixture collectorFixture)
    {
        _collectorFixture = collectorFixture;
    }

    [Fact]
    public void Insurance_InterestRate()
    {
        // Given
        var insurance = _collectorFixture.Insurance;
    
        // When
        int interestRate = insurance.InterestRate;
    
        // Then
        Assert.Equal(10, interestRate);
    }
}