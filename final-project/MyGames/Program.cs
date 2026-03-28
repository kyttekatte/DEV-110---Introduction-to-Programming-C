/*******************************************************************************
 * Course: DEV 110
 * Instructor: Zak Brinlee
 * Term: Winter 2026
 *
 * Programmer: Kytte Burke
 * Assignment: Final Project: My Games
 *
 * What does this program do?:
 * A menu-driven Games Tracker that loads games from a CSV file and lets you
 * view, add/save, and delete your games back to disk.
 * ******************************************************************************/
namespace MyGames;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to My Games Tracker!");

        string filePath = "games.csv";
        List<Game> games = new List<Game>();

        // Check for existing file and load games
        if (File.Exists(filePath))
        {
            games = LoadGames(filePath);
            Console.WriteLine($"Loaded {games.Count} games from {filePath}.");
        }
        else
        {
            Console.WriteLine($"No {filePath} found");
        }

        bool running = true;
        while (running)
        {
            PrintMenu();

            string input = Console.ReadLine() ?? "";
            Console.WriteLine();

            switch (input.Trim())
            {
                case "1":
                    ViewAllGames(games);
                    break;
                case "2":
                    AddGame(filePath,games);
                    break;
                case "3":
                    DeleteGame(filePath,games);
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose 1-4.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }

    private static void PrintMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. View All Games");
        Console.WriteLine("2. Add a Game");
        Console.WriteLine("3. Delete a Game");
        Console.WriteLine("4. Exit");
        Console.Write("Choose an option (1-4): ");
    }

    private static List<Game> LoadGames(string filePath)
    {
        List<Game> games = new List<Game>();
        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                games.Add(Game.Parse(line));
            }
        }
        return games;
    }

    private static void ViewAllGames(List<Game> games)
    {
        if (games.Count == 0)
        {
            Console.WriteLine("No games to display. Use option 2 to add some!");
            return;
        }

        Console.WriteLine("Your Games:");
        Console.WriteLine($"{ "Name",-32} {"Category",-30}");
        Console.WriteLine(new string('-', 55));

        for (int i = 0; i < games.Count; i++)
        {
            Console.WriteLine($"{i + 1} {games[i].GameName,-32} {games[i].GameCategory,-30}");
        }

        Console.WriteLine($"\nTotal Games: {games.Count}");
    }

    private static void AddGame(string filePath, List<Game> games)
    {
        Console.WriteLine("\n--- Add a New Game ---");

        string gameName = ReadNonEmptyString("Enter game name: ");
        string gameCategory = ReadNonEmptyString("Enter game category: ");

        games.Add(new Game(gameName, gameCategory));
        SaveGame(filePath, games);
        Console.WriteLine($"Game '{gameName}' added successfully!  You now have {games.Count} games in your collection.");
    }
    private static void DeleteGame(string filePath, List<Game> games)
    {
        if (games.Count == 0)
        {
            Console.WriteLine("No games to delete. Use option 2 to add some!");
            return;
        }

        ViewAllGames(games);
        Console.Write("\nEnter the number of the game to delete: ");
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input.Trim(), out int index) && index >= 1 && index <= games.Count)
        {
            Game removedGame = games[index - 1];
            games.RemoveAt(index - 1);
            SaveGame(filePath, games);
            Console.WriteLine($"Game '{removedGame.GameName}' deleted successfully! You now have {games.Count} games in your collection.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid game number.");
        }
    }

    private static void SaveGame(string filePath, List<Game> games)
    {
        string[] lines = games.Select(g => g.ToCSV()).ToArray();
        File.WriteAllLines(filePath, lines);
    }


    private static string ReadNonEmptyString(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
        }
    }



}
