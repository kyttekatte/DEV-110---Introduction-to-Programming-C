using System.Data;
using System.Diagnostics;
using System.Reflection.Emit;

namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Student Profile Card Generator!\n");
        Console.WriteLine("Please provide the following information:\n");

        // TODO: Collect PERSONAL INFORMATION (strings)
        // - Full name
        Console.WriteLine("Enter your full name: ");
        string fullName = Console.ReadLine();

        // - Hometown (city, state)
        Console.WriteLine("Enter your hometown (city, state): ");
        string homeTown = Console.ReadLine();

        // - Favorite color
        Console.WriteLine("Enter your favorite color: ");
        string favColor = Console.ReadLine();

        // - Dream job
        Console.WriteLine("Enter your dream job: ");
        string dreamJob = Console.ReadLine();

        // Hint: string variableName = Console.ReadLine();

        // TODO: Collect ACADEMIC INFORMATION
        // - Major (string)
        Console.WriteLine("Enter your major: ");
        string major = Console.ReadLine();

        // - GPA (double, 0.0-4.0)
        Console.WriteLine("Enter your GPA (0.0 - 4.0): ");
        double gpa = double.Parse(Console.ReadLine());

        // - Graduation year (int)
        Console.WriteLine("Enter your graduation year: ");
        int gradYear = int.Parse(Console.ReadLine());

        // - Is full-time student? (bool from yes/no)
        Console.WriteLine("Are you a full-time student? (yes/no): ");
        string fullTimeInput = Console.ReadLine().ToLower();
        bool isFullTime = fullTimeInput == "yes" || fullTimeInput == "y";

        // Hint: double gpa = double.Parse(Console.ReadLine());
        // Hint: bool isFullTime = answer.ToLower() == "yes";

        // TODO: Collect ADDITIONAL DETAILS
        // - Age (int)
        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        // - Height in inches (double)
        Console.WriteLine("Enter your height in inches: ");
        double heightInches = double.Parse(Console.ReadLine());

        // - Favorite number (int)
        Console.WriteLine("Enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());

        // TODO: CALCULATE derived information
        // - Birth year = 2026 - age
        int birthYear = 2026 - age;

        // - Years to graduation = graduationYear - 2026
        int yearsToGraduation = gradYear - 2026;

        // - Height in feet and inches: feet = heightInches / 12, inches = heightInches % 12
        int heightFeet = (int)(heightInches / 12);
        double remainingInches = heightInches % 12;

        // - Is honor student? = gpa >= 3.5
        bool isHonorStudent = gpa >= 3.5;

        // - Age in months = age * 12
        int ageMonths = age * 12;

        // TODO: DISPLAY formatted profile card
        // Use sections with headers:
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        // - PERSONAL INFORMATION
        Console.WriteLine("PERSONAL INFORMATION");
        Console.WriteLine("══════════════════════");
        Console.WriteLine($"\nName: {fullName}");
        Console.WriteLine($"Age: {age} years old");
        Console.WriteLine($"Height: {heightInches} inches");
        Console.WriteLine($"Hometown: {homeTown}");
        Console.WriteLine($"Favorite Color: {favColor}");
        Console.WriteLine($"Favorite Number: {favNumber}");
        Console.WriteLine($"Dream Job: {dreamJob}");

        // - ACADEMIC DETAILS
        // Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("\nACADEMIC DETAILS");
        Console.WriteLine("═══════════════════");
        Console.WriteLine($"\nMajor: {major}");
        Console.WriteLine($"GPA: {gpa:F2}");
        Console.WriteLine($"Expected Graduation Year: {gradYear}");
        Console.WriteLine($"Full-Time Student: {isFullTime}");
        Console.WriteLine($"Honor Student: {isHonorStudent}");

        // - CALCULATED STATISTICS
        // Use proper alignment and formatting
        // Console.WriteLine("\n===========================================");
        Console.WriteLine("\nCALCULATED STATISTICS");
        Console.WriteLine("======================");
        Console.WriteLine($"\nBirth Year: {birthYear}");
        Console.WriteLine($"Years to Graduation: {yearsToGraduation} years");
        Console.WriteLine($"Height in Feet and Inches: {heightFeet} feet {remainingInches:F1} inches");
        Console.WriteLine($"Age in Months: {ageMonths} months");

        Console.WriteLine("\nProfile complete! Good luck with your studies!");
    }
}
