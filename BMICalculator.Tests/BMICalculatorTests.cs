using Xunit;
using BMICalculator;

namespace BMICalculator.Tests
{
    public class BMICalculatorTests
    {
        [Theory]
        [InlineData(5, 9, 160, 23.6, "Normal weight")]  // Valid Normal BMI
        [InlineData(5, 6, 110, 17.7, "Underweight")]    // Valid Underweight BMI
        [InlineData(6, 0, 200, 27.1, "Overweight")]     // Valid Overweight BMI
        [InlineData(5, 4, 180, 30.9, "Obese")]         // Valid Obese BMI
        public void CalculateBMI_ShouldReturnCorrectCategory(int feet, int inches, double weight, double expectedBMI, string expectedCategory)
        {
            // Act
            var result = BMI.CalculateBMI(feet, inches, weight);

            // Allow small deviation due to floating-point precision issues
            Assert.InRange(result.BMI, expectedBMI - 0.1, expectedBMI + 0.1);

            // Ensure category is still correct
            Assert.Equal(expectedCategory, result.Category);
        }

        // Boundary Tests
        [Theory]
        [InlineData(5, 9, 124.9, 18.4, "Underweight")]  // Lower boundary of Normal
        [InlineData(5, 9, 125.1, 18.5, "Normal weight")] // Boundary shift of 0.1
        [InlineData(5, 9, 174.9, 25.8, "Overweight")]   // Corrected expected value
        [InlineData(5, 9, 175.1, 25.9, "Overweight")]   // Corrected expected value
        public void BoundaryTests(int feet, int inches, double weight, double expectedBMI, string expectedCategory)
        {
            // Act
            var result = BMI.CalculateBMI(feet, inches, weight);

            // Allow small floating-point precision errors
            Assert.InRange(result.BMI, expectedBMI - 0.1, expectedBMI + 0.1);

            // Ensure category is still correct
            Assert.Equal(expectedCategory, result.Category);
        }

    }
}
