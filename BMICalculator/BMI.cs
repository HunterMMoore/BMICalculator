namespace BMICalculator
{
    public class BMI
    {
        public static (double BMI, string Category) CalculateBMI(int feet, int inches, double weight)
        {
            int totalInches = (feet * 12) + inches;
            double bmi = (weight * 703) / (totalInches * totalInches);

            // Round BMI before determining category
            bmi = Math.Round(bmi, 1);

            string category = bmi switch
            {
                < 18.5 => "Underweight",
                >= 18.5 and < 25 => "Normal weight",
                >= 25 and < 30 => "Overweight",
                _ => "Obese"
            };

            return (bmi, category);
        }
    }
}
