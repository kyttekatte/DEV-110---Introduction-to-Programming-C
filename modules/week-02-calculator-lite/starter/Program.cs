namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        // TODO: Declare variables for storing user input (use descriptive names)
        // Hint: You'll need variables for two numbers, user name, and calculation choice
        string userName = " ";
        bool useDecimals = false;
        double num1 = 0;
        double num2 = 0;
        int calculationCount = 0;

        // TODO: Ask for user's name (string) and greet them
        // Example: "Enter your name: " then "Hello, [name]!"
        Console.WriteLine("Enter your name: ");
        userName = Console.ReadLine() ?? "User";
        Console.WriteLine($"Hello, {userName}!");

        // TODO: Ask if they want to use decimals (bool)
        // Example: "Use decimal precision? (yes/no): "
        // Store as boolean (true for yes, false for no)
        Console.WriteLine("Use decimal precision? (yes/no): ");
        string decimalChoice = Console.ReadLine()?.ToLower();
        useDecimals = (decimalChoice == "yes" || decimalChoice == "y");

        // TODO: Prompt user for first number (double or int based on choice)
        // If decimals: use double.Parse()
        // If no decimals: use int.Parse() then cast to double
        Console.WriteLine("Enter the first number: ");
        if (useDecimals)
        {
            num1 = double.Parse(Console.ReadLine() ?? "0");
        }
        else
        {
            num1 = (double)int.Parse(Console.ReadLine() ?? "0");
        }

        // TODO: Prompt user for second number (same type as first)
        Console.WriteLine("Enter the second number: ");
        if (useDecimals)
        {
            num2 = double.Parse(Console.ReadLine() ?? "0");
        }
        else
        {
            num2 = (double)int.Parse(Console.ReadLine() ?? "0");
        }

        // TODO: Calculate ALL arithmetic operations:
        // - sum (addition: +)
        double sum = num1 + num2;
        calculationCount++;

        // - difference (subtraction: -)
        double difference = num1 - num2;
        calculationCount++;

        // - product (multiplication: *)
        double product = num1 * num2;
        calculationCount++;

        // TODO: Check if second number is zero BEFORE dividing
        // Use if statement: if (num2 == 0) { show error } else { calculate }
        // - quotient (division: /)
        double quotient = 0;
        if (num2 != 0)
        {
            quotient = num1 / num2;
            calculationCount++;
        }
        else
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }

        // - remainder (modulus: %)
        double remainder = 0;
        if (num2 != 0)
        {
            remainder = num1 % num2;
            calculationCount++;
        }
        else
        {
            Console.WriteLine("Error: Cannot modulus by zero.");
        }

        // - average ((num1 + num2) / 2)
        double average = (num1 + num2) / 2.0;
        calculationCount++;

        // TODO: Calculate percentage difference
        // Formula: ((num1 - num2) / num1) * 100
        // Display with % symbol
        // - Percentage difference ((num1 - num2) / num1 * 100)
        double percentageDifference = 0;
        if (num1 != 0)
        {
            percentageDifference = ((num1 - num2) / num1) * 100;
            calculationCount++;
        }
        else
        {
            Console.WriteLine("Error: Cannot calculate percentage difference when first number is zero.");
        }

        // TODO: Display results with proper formatting
        // Show 2 decimal places: {value:F2} if user chose 'yes'
        // Show no decimal places: {value:F0} if user chose 'no'
        // Include descriptive labels for each operation
        Console.WriteLine($"\nResults for {userName}:");
        if (useDecimals)
        {
            Console.WriteLine($"Sum: {sum:F2}");
            Console.WriteLine($"Difference: {difference:F2}");
            Console.WriteLine($"Product: {product:F2}");
            if (num2 != 0)
            {
                Console.WriteLine($"Quotient: {quotient:F2}");
            }
            else
            {
                Console.WriteLine("Quotient: Not defined (division by zero)");
            }

            if (num2 != 0)
            {
                Console.WriteLine($"Remainder: {remainder:F2}");
            }
            else
            {
                Console.WriteLine("Remainder: Not defined (division by zero)");
            }

            Console.WriteLine($"Average: {average:F2}");

            if (num1 != 0)
            {
                Console.WriteLine($"Percentage Difference: {percentageDifference:F2}%");
            }
            else
            {
                Console.WriteLine("Percentage Difference: Not defined (first number is zero)");
            }
        }
        else
        {
            Console.WriteLine($"Sum: {sum:F0}");
            Console.WriteLine($"Difference: {difference:F0}");
            Console.WriteLine($"Product: {product:F0}");

            if (num2 != 0)
            {
                Console.WriteLine($"Quotient: {quotient:F0}");
            }
            else
            {
                Console.WriteLine("Quotient: Not defined (division by zero)");
            }

            if (num2 != 0)
            {
                Console.WriteLine($"Remainder: {remainder:F0}");
            }
            else
            {
                Console.WriteLine("Remainder: Not defined (division by zero)");
            }

            Console.WriteLine($"Average: {average:F0}");

            if (num1 != 0)
            {
                Console.WriteLine($"Percentage Difference: {percentageDifference:F0}%");
            }
            else
            {
                Console.WriteLine("Percentage Difference: Not defined (first number is zero)");
            }
        }

        // TODO: Count total calculations performed (int)
        // Display: "Performed [count] calculations for [name]!"
        if (calculationCount > 0)
        {
            Console.WriteLine($"\nPerformed {calculationCount} calculation(s) for {userName}!");
        }

        // Closing message
        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
