/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Kytte Burke
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-heavy menu app that demonstrates string formatting and output patterns.
- */

namespace TextMenuApp;

public class Program
{
    public static void Main(string[] args)
    {
        // 1: Build a title banner using strings
        // Create variables for:
        // - title: "Text Menu Studio"
        // - subtitle: "Strings + Console Output Patterns"
        // - divider: 48 equals signs (hint: use new string() constructor)
        // Display: divider, title in uppercase, subtitle, divider
        string title = "Text Menu Studio";
        string subtitle = "Strings + Console Output Patterns";
        string divider = new string('=', 48);

        Console.WriteLine(divider);
        Console.WriteLine(title.ToUpper());
        Console.WriteLine(subtitle);
        Console.WriteLine(divider);

        // 2: Create a menu loop that repeats until user chooses 6 (Exit)
        // Hint: Use a while loop
        int choice = 0;
        while (choice != 6)
        {
            // 3: Print the menu box
            // Required menu option texts (tests check for these):
            // - 1) Greeting Card
            // - 2) Name Tag Formatter
            // - 3) Phrase Analyzer
            // - 4) Fancy Receipt Line
            // - 5) Menu Banner Builder
            // - 6) Exit
            Console.WriteLine("1) Greeting Card");
            Console.WriteLine("2) Name Tag Formatter");
            Console.WriteLine("3) Phrase Analyzer");
            Console.WriteLine("4) Fancy Receipt Line");
            Console.WriteLine("5) Menu Banner Builder");
            Console.WriteLine("6) Exit");

            // 4: Get menu choice from user
            // Use ReadIntInRange helper with prompt: "Choose an option (1-6): "
            // Range: 1 to 6
            choice = ReadIntInRange("Choose an option (1-6): ", 1, 6);

            // TODO 5: Use a switch statement to handle each menu option
            switch (choice)
            {
                case 1:
                    // ===== OPTION 1: Greeting Card =====
                    // Prompts: "Enter your name: " and "Enter a short message: "
                    // Required string operations:
                    // - Use Trim() to clean up the name
                    // - Use ToUpper() for an uppercase version
                    // - Use concatenation OR interpolation for greeting text
                    // - Use string.Format() for at least one output line
                    // - Display a boxed card with the name, uppercase name, and message
                    // Include the word "Message:" in your output
                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine().Trim().ToUpper();
                    Console.Write("Enter a short message: ");
                    string message = Console.ReadLine().Trim();
                    Console.WriteLine();
                    Console.WriteLine(divider);
                    Console.WriteLine($"Hello, {name}!");
                    Console.WriteLine(string.Format("Message: {0}", message));
                    Console.WriteLine(divider);
                    break;
                case 2:
                    // ===== OPTION 2: Name Tag Formatter =====
                    // Prompts: "Enter first name: " and "Enter last name: "
                    // Required string operations:
                    // - Use Trim() on both inputs
                    // - Use concatenation to build full name
                    // - Use string indexing to get first characters for initials
                    // - Use ToUpper() for initials
                    // - Use ToLower() for lowercase version
                    // Display three things:
                    // - Name tag with the full name (include a bracket [)
                    // - Initials (use word "Initials:" in label)
                    // - Lowercase version (use word "Lowercase:" in label)
                    Console.Write("Enter first name: ");
                    string firstName = Console.ReadLine().Trim();
                    Console.Write("Enter last name: ");
                    string lastName = Console.ReadLine().Trim();

                    string fullName = firstName + " " + lastName;
                    string initials = firstName[0].ToString().ToUpper() + lastName[0].ToString().ToUpper();
                    string lowercaseName = fullName.ToLower();

                    Console.WriteLine();
                    Console.WriteLine($"Name Tag: [{fullName}]");
                    Console.WriteLine($"Initials: {initials}");
                    Console.WriteLine($"Lowercase: {lowercaseName}");
                    break;
                case 3:
                    // ===== OPTION 3: Phrase Analyzer =====
                    // Prompt: "Enter a phrase: "
                    // Required string operations:
                    // - Use Trim() on input
                    // - Use Length property
                    // - Use Contains() to check for letter 'a' (convert to lowercase first)
                    // - Use Replace() to change spaces to dashes
                    // - Use Split() to break into words
                    // - Use string.Join() to create comma-separated list
                    // Display: length, contains check, dashed version, and words list
                    Console.Write("Enter a phrase: ");
                    string phrase = Console.ReadLine().Trim();
                    int length = phrase.Length;
                    bool containsA = phrase.ToLower().Contains('a');
                    string dashedVersion = phrase.Replace(' ', '-');
                    string[] words = phrase.Split(' ');
                    string wordsList = string.Join(", ", words);

                    Console.WriteLine();
                    Console.WriteLine($"Length: {length}");
                    Console.WriteLine($"Contains 'a': {containsA}");
                    Console.WriteLine($"Dashed Version: {dashedVersion}");
                    Console.WriteLine($"Words List: {wordsList}");
                    break;
                case 4:
                    // ===== OPTION 4: Fancy Receipt Line =====
                    // Prompts: "Enter item name: ", "Enter price: ", "Enter quantity (1-9): "
                    // Use ReadDouble for price and ReadIntInRange for quantity
                    // Required:
                    // - Calculate total (price * quantity)
                    // - Create a receipt table with header row (ITEM, QTY, TOTAL)
                    // - Use string.Format() with composite formatting for the data row
                    // - Use alignment specifiers (left/right alignment)
                    // - Use currency format specifier (:C2) for the total
                    Console.Write("Enter item name: ");
                    string itemName = Console.ReadLine().Trim();
                    double price = ReadDouble("Enter price: ");
                    int quantity = ReadIntInRange("Enter quantity (1-9): ", 1, 9);
                    double total = price * quantity;
                    Console.WriteLine();
                    Console.WriteLine(string.Format("{0,-20} {1,5} {2,10}", "ITEM", "QTY", "TOTAL"));
                    Console.WriteLine(string.Format("{0,-20} {1,5} {2,10:C2}", itemName, quantity, total));
                    break;
                case 5:
                    // ===== OPTION 5: Menu Banner Builder =====
                    // Prompts: "Enter a title: ", "Enter a subtitle: ", "Enter width (30-60): "
                    // Use ReadIntInRange for width (min=30, max=60)
                    // Required string operations:
                    // - Create border line with equals signs (use new string constructor)
                    // - Use PadLeft() to center text (formula: (width + text.Length) / 2)
                    // - Use ToUpper() on title
                    // - Display banner with borders and centered text
                    // - Show three alignment examples (centered, left, right)
                    Console.Write("Enter a title: ");
                    string bannerTitle = Console.ReadLine().Trim().ToUpper();
                    Console.Write("Enter a subtitle: ");
                    string bannerSubtitle = Console.ReadLine().Trim();
                    int width = ReadIntInRange("Enter width (30-60): ", 30, 60);
                    string border = new string('=', width);
                    int leftPadTitle = (width - bannerTitle.Length) / 2;
                    int leftPadSubtitle = (width - bannerSubtitle.Length) / 2;
                    string centeredTitle = bannerTitle.PadLeft(leftPadTitle).PadRight(width);
                    string centeredSubtitle = bannerSubtitle.PadLeft(leftPadSubtitle).PadRight(width);
                    Console.WriteLine(border);
                    Console.WriteLine(centeredTitle);
                    Console.WriteLine(centeredSubtitle);
                    Console.WriteLine(border);
                    break;
                case 6:
                    // ===== OPTION 6: Exit with String Analysis =====
                    // Prompt: "Enter a closing word: "
                    // Required string operations (demonstrate these 4 methods):
                    // - Use Equals() with StringComparison.OrdinalIgnoreCase to compare with "goodbye"
                    // - Use Substring() to extract first 3 characters (check length first!)
                    // - Use EndsWith() to check if ends with "!"
                    // - Use IndexOf() to find position of space character
                    // Display the results of all four operations
                    // Then print: "Goodbye!"
                    break;
            }

            // TODO 6: Add a blank line between menu actions (but not after Exit)
            if (choice != 6)
            {
                Console.WriteLine(); // Blank line for spacing
            }
        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        // 7: Implement input validation
        // Use a do-while loop with int.TryParse()
        // Keep prompting until input is valid AND within range
        // Return the valid number
        int value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            isValid = int.TryParse(input, out value);
        } while (!isValid || value < min || value > max);

        return value;
    }

    private static double ReadDouble(string prompt)
    {
        // 8: Implement input validation
        // Use a do-while loop with double.TryParse()
        // Keep prompting until input is a valid number
        // Return the valid number
        double value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            isValid = double.TryParse(input, out value);
        } while (!isValid);

        return value;
    }
}
