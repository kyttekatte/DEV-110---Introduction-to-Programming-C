using System.Data;
using System.Diagnostics;
using System.Reflection.Emit;

namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

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
        bool isFullTime = Console.ReadLine().ToLower() == "yes" || Console.ReadLine().ToLower() == "y";

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
        // - PERSONAL INFORMATION
        Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("PERSONAL INFORMATION");
        Console.WriteLine($"Name: {fullName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {heightInches} inches");
        Console.WriteLine($"Hometown: {homeTown}");
        Console.WriteLine($"Favorite Color: {favColor}");
        Console.WriteLine($"Favorite Number: {favNumber}");
        Console.WriteLine($"Dream Job: {dreamJob}");

        // - ACADEMIC DETAILS
        Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("ACADEMIC DETAILS");
        Console.WriteLine("═══════════════════════════════════════════");
        Console.WriteLine($"Major: {major}");
        Console.WriteLine($"GPA: {gpa:F2}");
        Console.WriteLine($"Graduation Year: {gradYear}");
        Console.WriteLine($"Full-Time Student: {(isFullTime ? "Yes" : "No")}");
        Console.WriteLine($"Honor Student: {(isHonorStudent ? "Yes" : "No")}");

        // - CALCULATED STATISTICS
        // Use proper alignment and formatting
        Console.WriteLine("\n===========================================");
        Console.WriteLine("CALCULATED STATISTICS");
        Console.WriteLine("===========================================");
        Console.WriteLine($"Birth Year: {birthYear}");
        Console.WriteLine($"Years to Graduation: {yearsToGraduation}");
        Console.WriteLine($"Height in Feet and Inches: {heightFeet} feet {remainingInches:F1} inches");
        Console.WriteLine($"Age in Months: {ageMonths}");

        Console.WriteLine("Profile complete! Good luck with your studies!");
    }
}
