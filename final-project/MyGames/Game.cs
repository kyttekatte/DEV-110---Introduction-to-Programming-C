/*******************************************************************************
 * Course: DEV 110
 * Instructor: Zak Brinlee
 * Term: Winter 2026
 *
 * Programmer: Kytte Burke
 * Assignment: Final Project: My Games
 *
 * What does this Class do?:
 * Game class to store the properties expected from the data file
 * Store: gameName + gameCategory
 * Methods: intake (parse) - save
 *
 * ******************************************************************************/
namespace MyGames;

internal class Game
{
    public string GameName { get; set; }
    public string GameCategory { get; set; }

    public Game(string gameName, string gameCategory)
    {
        GameName = gameName;
        GameCategory = gameCategory;
    }

    public string ToCSV()
    {
        return $"{GameName},{GameCategory}";
    }

    public static Game Parse(string line)
    {
        string[] parts = line.Split(',', 2);

        return new Game(parts[0].Trim(), parts[1].Trim());
    }
}
