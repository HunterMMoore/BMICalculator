using System;

namespace BMICalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("BMI Calculator");

            Console.Write("Enter height (feet): ");
            int feet = int.Parse(Console.ReadLine());

            Console.Write("Enter height (inches): ");
            int inches = int.Parse(Console.ReadLine());

            Console.Write("Enter weight (lbs): ");
            double weight = double.Parse(Console.ReadLine());

            var result = BMI.CalculateBMI(feet, inches, weight);

            Console.WriteLine($"Your BMI: {result.BMI}");
            Console.WriteLine($"Category: {result.Category}");
        }
    }
}
