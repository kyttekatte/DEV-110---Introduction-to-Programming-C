# Final Project — Data Model Planning Template

_Fill this out **before** writing any code. Think through your app's data first._

---

## Scenario (1–2 sentences)

_What does your app do? Who uses it and why?_
  A menu-driven Games Tracker that loads games from a CSV file and lets you
  view, add, and delete your games back to disk.

---

## Class Structure

### `Game` Class

**Properties (with types):**

- `GameName` (string) — the name of the game
- `GameCategory` (string) — the category of the game

**Constructor Parameters:**

- `gameName` (string)
- `gameCategory` (string)

**Methods:**

- `ToCSV()` → string — returns `"gameName,gameCategory"` as a single CSV line
- `static Parse(string line)` → Game — splits a CSV line into a Game object

---

## Inputs (with types)

_List **at least 5** named inputs your app collects or works with. Include the data type for each._

_Example format:_
_- `movieTitle` (string) — the name of the movie the user enters_

- `gameName` (string) — name of the game entered by user
- `gameCategory` (string) — category of the game entered by user
- `filePath` (string) — path to gamesList.csv on disk
- `line` (string) — single raw CSV line read from file during loading
- `games` (List<Game>) — in-memory list of all games

---

## Calculated or Derived Values

_List any values your program computes from the inputs (totals, averages, counts, formatted strings, etc.)._
_If your app doesn't calculate anything, write "None" and explain why._

- `total` (int) — total number of games in the list (`games.Count`)

---

## Outputs (what the user sees)

_Describe what the program displays. Include menu options, summary views, confirmation messages, etc._

- **Games table** (`ViewAllGames`): numbered rows with `gameName` (padded to 32 chars) and `gameCategory` (padded to 30 chars), followed by a total count
- **Save confirmation**: `"Saved X game(s) to games.csv."`
- **Delete confirmation**: `"Deleted X game(s) from games.csv."`
- **Load message**: `"Loaded X game(s) from games.csv."` (or seed fallback message)

---

## Edge Case to Consider (at least 1)

_What could go wrong or behave unexpectedly? How will your app handle it?_

_Examples: file not found, user enters a letter instead of a number, empty list, duplicate entry._

**List<Game> is empty** — if no file is present when we go to load List<Game> then the program may break

**Solution:** create a guard clause using if/else statement
