// program to test out the class


using System;

class HealthProfileTest
{
    public static void Main(string[] args)
    {
        HealthProfile hp1 = new HealthProfile(null, null, 0, 0, 0, 0, 0, null);

        Console.Write("Enter First Name: ");
        hp1.FirstName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter Last Name: ");
        hp1.LastName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter Day of Birth: ");
        hp1.DayOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Month of Birth: ");
        hp1.MonthOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Year of Birth: ");
        hp1.YearOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Weight in pounds: ");
        hp1.WeightInPounds = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Height in inches: ");
        hp1.HeightInInches = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Gender: ");
        hp1.Gender = Convert.ToString(Console.ReadLine());

        
        
        hp1.DisplayFirstName();
        hp1.DisplayLastName();
        hp1.DisplayDayOfBirth();
        hp1.DisplayMonthOfBirth();
        hp1.DisplayYearOfBirth();
        hp1.DisplayWeightInPounds();
        hp1.DisplayHeightInInches();
        hp1.DisplayGender();
        hp1.DisplayYearsOfAgeSimple();
        hp1.DisplayMaxHeartRate();
        hp1.DisplayTargetHeartRate();
        hp1.DisplayBodyMassIndex();
        hp1.DisplayBMIOutput();
        hp1.DisplayBMIChart();        
    }
}