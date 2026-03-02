// Week 4 Logic Lounge Lab - Starter
// Follow the TODOs to complete the program.

Console.WriteLine("=== Logic Lounge ===\n");

// TODO 1: Ask for the user's name and store it in userName (string)
Console.Write("Enter your name: ");
string userName = Console.ReadLine();

// TODO 2: Ask for the user's age and store it in age (int)
Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

// TODO 3: Use a simple if statement
// If the age is under 13, print a message about age restrictions.
if (age < 13)
{
    Console.WriteLine("\nNote: Some activities are for 13+.");
}

// TODO 4: Ask for snack size (S or L)
Console.Write("\nChoose a snack size (S/L/N): ");
string snackChoice = Console.ReadLine().ToUpper();

// TODO 5: Use an if/else to set snackPrice
// Small: 3.50, Large: 5.00, otherwise 0.00 with a warning message
double snackPrice = 0.0;
if (snackChoice == "S")
{
    snackPrice = 3.50;
}
else if (snackChoice == "L")
{
    snackPrice = 5.00;
}
else
{
    Console.WriteLine("No snack selected. Price set to $0.00.");
}

// TODO 6: Ask if the user is a club member (yes/no)
Console.Write("Are you a club member? (yes/no): ");
string memberInput = Console.ReadLine().ToLower();
bool isMember = memberInput == "yes" || memberInput == "y";

// TODO 7: Use a nested if to set membershipLevel
// If isMember is true: age >= 18 -> "Gold", else -> "Junior"
// If isMember is false: "None"
string membershipLevel = "";
if (isMember)
{
    if (age >= 18)
    {
        membershipLevel = "Gold";
    }
    else
    {
        membershipLevel = "Junior";
    }
}
else
{
    membershipLevel = "None";
}

// TODO 8: Show a menu of activities
Console.WriteLine("\nChoose an activity:");
Console.WriteLine("1) Movie");
Console.WriteLine("2) Arcade");
Console.WriteLine("3) Study Lounge");
Console.Write("Enter 1, 2, or 3: ");
int activityChoice = int.Parse(Console.ReadLine());

// TODO 9: Use a switch statement to set activityName and activityCost
string activityName = "";
double activityCost = 0.0;
switch (activityChoice)
{
    case 1:
        activityName = "Movie";
        activityCost = 12.00;
        break;
    case 4:
        Console.WriteLine("Student discount selected, redirecting to Arcade pricing ....");
        goto case 2;
    case 2:
        activityName = "Arcade";
        activityCost = 8.00;
        break;
    case 3:
        activityName = "Study Lounge";
        activityCost = 4.00;
        break;
    default:
        activityName = "None";
        activityCost = 0.00;
        Console.WriteLine("\nInvalid choice. No activity selected.");
        break;
}

// TODO 10: Print a summary of the user's selections
// Include: name, age, snack price, member status, membership level, activity, activity cost
Console.WriteLine("\n=== Summary ===");
Console.WriteLine($"Name: {userName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Snack Price: ${snackPrice:F2}");
Console.WriteLine($"Member: {isMember}");
Console.WriteLine($"Membership Level: {membershipLevel}");
Console.WriteLine($"Activity: {activityName}");
Console.WriteLine($"Activity Cost: ${activityCost:F2}");

// TODO 11: If both snackPrice and activityCost are greater than 0, show the total cost
if (snackPrice > 0 && activityCost > 0)
{
    double totalCost = snackPrice + activityCost;
    Console.WriteLine($"\nTotal Cost: ${totalCost:F2}");
}
