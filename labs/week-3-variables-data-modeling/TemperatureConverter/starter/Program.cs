using System.Data;

namespace TemperatureConverter;

public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Display the welcome message
        // Print "=== Temperature Converter ===" with blank lines before and after
        Console.WriteLine("\n=== Temperature Converter ===\n");


        // TODO: Get the user's name (string type)
        // 1. Display a prompt asking for their name
        Console.Write("Please enter your name: ");
        // 2. Read their input and store it in a variable called userName
        string userName = Console.ReadLine() ?? "User";


        // TODO: Greet the user by name
        // Display: "Hello, {userName}! Let's convert some temperatures."
        Console.WriteLine($"Hello, {userName}! Let's convert some temperatures.");

        // TODO: Ask if user wants detailed calculations (bool type)
        // 1. Display prompt: "Show detailed calculations? (yes/no): "
        Console.Write("Show detailed calculations? (yes/no): ");
        // 2. Read their input and store it in a variable
        // 3. Convert the input to lowercase using .ToLower()
        string detailChoice = Console.ReadLine()?.ToLower();
        // 4. Create a bool variable called showDetails
        // 5. Set showDetails to true if the input is "yes" or "y" (use || for OR)
        bool showDetails = (detailChoice == "yes" || detailChoice == "y");

        // TODO: Get the temperature value (double type)
        // 1. Display prompt: "Enter a temperature value: "
        Console.Write("Enter a temperature value: ");
        // 2. Read the input
        // 3. Convert it to a double using double.Parse()
        // 4. Store it in a variable called inputTemp
        double inputTemp = double.Parse(Console.ReadLine());

        // TODO: Get the unit (string type)
        // 1. Display prompt: "Is this temperature in (C)elsius or (F)ahrenheit? "
        Console.Write("Is this temperature in (C)elsius or (F)ahrenheit? ");
        // 2. Read the input and convert to uppercase using .ToUpper()
        // 3. Store it in a variable called conversionChoice
        string conversionChoice = Console.ReadLine()?.ToUpper();

        // TODO: Create a counter for conversions (int type)
        // Initialize an int variable called conversionCount to 0
        int conversionCount = 0;

        // TODO: Display section header
        // Print "=== Conversion Results ===" with blank lines
        Console.WriteLine("\n=== Conversion Results ===\n");

        // TODO: Check which conversion to perform
        // Use if/else to check if conversionChoice is "C" or "CELSIUS"

        if (conversionChoice == "C" || conversionChoice == "CELSIUS")
        {
            // TODO: Convert Celsius to Fahrenheit
            // Formula: F = (C × 9/5) + 32
            // IMPORTANT: Use 9.0 and 5.0 (not 9 and 5) for decimal division!
            // Store the result in a variable called convertedTemp
            double convertedTemp = (inputTemp * 9.0 / 5.0) + 32.0;

            // TODO: Increment the conversion counter
            // Add 1 to conversionCount
            conversionCount++;

            // TODO: Display the results
            // Show both the input temperature and converted temperature
            // Use :F2 to format numbers with 2 decimal places
            // Example: "Temperature in Celsius: 25.00°C"
            Console.WriteLine($"Temperature in Celsius: {inputTemp:F2}°C");
            Console.WriteLine($"Converted Temperature in Fahrenheit: {convertedTemp:F2}°F");

            // TODO: Show detailed calculation if requested
            // Use an if statement to check if showDetails is true
            // If yes, display the formula and calculation steps
            if (showDetails)
            {
                Console.WriteLine("Detailed Calculation:");
                Console.WriteLine($"Formula: F = ({inputTemp:F2} × 9/5) + 32");
                Console.WriteLine($"Step 1: {inputTemp:F2} × 9/5 = {(inputTemp * 9.0 / 5.0):F2}");
                Console.WriteLine($"Step 2: {(inputTemp * 9.0 / 5.0):F2} + 32 = {convertedTemp:F2}");
            }

            // TODO: Display temperature analysis
            // Print "=== Temperature Analysis ===" header
            Console.WriteLine("\n=== Temperature Analysis ===\n");

            // TODO: Calculate differences from water phase-change points
            // 1. Difference from freezing (0°C)
            // 2. Difference from boiling (100°C)
            // Store results and display with :F2 formatting
            double diffFromFreezing = inputTemp - 0.0;
            double diffFromBoiling = inputTemp - 100.0;
            Console.WriteLine($"Difference from Freezing Point (0°C): {diffFromFreezing:F2}°C");
            Console.WriteLine($"Difference from Boiling Point (100°C): {diffFromBoiling:F2}°C");

            // TODO: Determine water state based on temperature
            // Use if/else to check temperature ranges:
            // - Below 0°C: "Below freezing (water is ice)"
            // - Between 0°C and 100°C: "Between freezing and boiling (water is liquid)"
            // - Above 100°C: "Above boiling (water is steam)"
            if (inputTemp < 0.0)
            {
                Console.WriteLine("Water State: Below freezing (water is ice)");
            }
            else if (inputTemp >= 0.0 && inputTemp <= 100.0)
            {
                Console.WriteLine("Water State: Between freezing and boiling (water is liquid)");
            }
            else
            {
                Console.WriteLine("Water State: Above boiling (water is steam)");
            }
        }
        else if (conversionChoice == "F" || conversionChoice == "FAHRENHEIT")
        {
            // TODO: Convert Fahrenheit to Celsius
            // Formula: C = (F - 32) × 5/9
            // IMPORTANT: Use 32.0, 5.0, and 9.0 for decimal division!
            // Store the result in convertedTemp
            double convertedTemp = (inputTemp - 32.0) * 5.0 / 9.0;

            // TODO: Increment the conversion counter
            conversionCount++;

            // TODO: Display the results
            // Show both temperatures with :F2 formatting
            Console.WriteLine($"Temperature in Fahrenheit: {inputTemp:F2}°F");
            Console.WriteLine($"Converted Temperature in Celsius: {convertedTemp:F2}°C");

            // TODO: Show detailed calculation if requested
            // Check if showDetails is true
            if (showDetails)
            {
                Console.WriteLine("Detailed Calculation:");
                Console.WriteLine($"Formula: C = ({inputTemp:F2} - 32) × 5/9");
                Console.WriteLine($"Step 1: {inputTemp:F2} - 32 = {(inputTemp - 32.0):F2}");
                Console.WriteLine($"Step 2: {(inputTemp - 32.0):F2} × 5/9 = {convertedTemp:F2}");
            }

            // TODO: Display temperature analysis header
            Console.WriteLine("\n=== Temperature Analysis ===\n");

            // TODO: Calculate differences from water phase-change points
            // 1. Difference from freezing (32°F)
            // 2. Difference from boiling (212°F)
            double diffFromFreezing = inputTemp - 32.0;
            double diffFromBoiling = inputTemp - 212.0;

            // TODO: Determine water state based on temperature
            // Use if/else to check temperature ranges:
            // - Below 32°F: "Below freezing (water is ice)"
            // - Between 32°F and 212°F: "Between freezing and boiling (water is liquid)"
            // - Above 212°F: "Above boiling (water is steam)"
            Console.WriteLine($"Difference from Freezing Point (32°F): {diffFromFreezing:F2}°F");
            Console.WriteLine($"Difference from Boiling Point (212°F): {diffFromBoiling:F2}°F");
            if (inputTemp < 32.0)
            {
                Console.WriteLine("Water State: Below freezing (water is ice)");
            }
            else if (inputTemp >= 32.0 && inputTemp <= 212.0)
            {
                Console.WriteLine("Water State: Between freezing and boiling (water is liquid)");
            }
            else
            {
                Console.WriteLine("Water State: Above boiling (water is steam)");
            }
        }
        else
        {
            // TODO: Handle invalid unit input
            // Display error message and set conversionCount to 0

            Console.WriteLine("Error: Invalid temperature unit. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
            conversionCount = 0;
        }

        // TODO: Display conversion count if successful
        // Use an if statement to check if conversionCount is greater than 0
        // If yes, display: "Performed {conversionCount} temperature conversion(s) for {userName}!"
        if (conversionCount > 0)
        {
            Console.WriteLine($"Performed {conversionCount} temperature conversion(s) for {userName}!");
        }

        // TODO: Display closing message
        // Print "Thank you for using Temperature Converter!"

        Console.WriteLine("Thank you for using Temperature Converter!");
    }
}
