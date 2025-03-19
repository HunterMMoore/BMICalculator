# BMI Calculator (Test-Driven Development)

## Overview
This is a C# console application that calculates Body Mass Index (BMI) based on user input (height in feet and inches, weight in pounds). The project follows **Test-Driven Development (TDD)** principles and includes unit tests written using **xUnit**.

## Features
- Accepts height (feet & inches) and weight (lbs) as input.
- Computes BMI 
- Rounds BMI to one decimal place.
- Categorizes BMI as:
  - **Underweight**: BMI < 18.5
  - **Normal weight**: 18.5 ≤ BMI < 25
  - **Overweight**: 25 ≤ BMI < 30
  - **Obese**: BMI ≥ 30
- Includes boundary testing to validate classification at category thresholds.

## Installation & Setup

### **Prerequisites**
- **.NET SDK 8.0+**  
  - Download from: [https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download)
  - Verify installation:  
    dotnet --version
- **Git** (for cloning repository)  
  - Download from: [https://git-scm.com/downloads](https://git-scm.com/downloads)

### **Clone the Repository and Run the Project**
# Clone the GitHub repository
git clone https://github.com/HunterMMoore/BMICalculator.git
cd BMICalculator

# Build the project
dotnet build

# Run the application
dotnet run --project BMICalculator
Example Output:

BMI Calculator
Enter height (feet): 5
Enter height (inches): 9
Enter weight (lbs): 160
Your BMI: 23.6
Category: Normal weight

Press Enter to exit...

# Or Download the .exe file 

Download link
https://github.com/HunterMMoore/BMICalculator/releases/tag/v1.0

# Run Unit Tests
dotnet test

All tests should pass, including boundary cases.
