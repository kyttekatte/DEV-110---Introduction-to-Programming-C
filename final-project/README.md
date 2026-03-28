# Final Project: Build Your Own App

## Summary

This is your chance to design and build a C# console app of your own choosing. There is no
starter code and no automated tests — you pick the idea, plan it out, and build everything
from scratch using the skills you have practiced all quarter.

This assignment is **extra credit** and is worth **75 points**, with an additional **25 bonus
points** if you record a short video walkthrough.

---

## Learning Objectives

- Design a program before writing code
- Use all core C# concepts from the course together in one cohesive app
- Create and organize a multi-file C# project from scratch
- Reflect on your own design decisions

---

## App Idea Guidelines

You can build any console app that interests you. A few ideas to get you started:

- Personal budget or expense tracker
- Contact or address book
- Recipe or ingredient manager
- Study flashcard quiz
- Workout or habit log
- Movie, book, or game collection tracker

Keep the scope small. A focused app that works well is worth more than a large app
that is only half finished.

---

## Required Concepts

Your app must clearly demonstrate **all 8** of the following:

| #   | Concept                                                                    | Introduced |
| --- | -------------------------------------------------------------------------- | ---------- |
| 1   | Variables using appropriate data types (`string`, `int`, `double`, `bool`) | Week 3     |
| 2   | If/else decisions (at least one conditional branch)                        | Week 4     |
| 3   | At least one loop (`while`, `do-while`, or `for`)                          | Week 5     |
| 4   | Formatted string output (labels, alignment, or headers)                    | Week 6     |
| 5   | An array or `List<T>` storing multiple items                               | Week 7     |
| 6   | At least one custom class in its own `.cs` file                            | Week 8     |
| 7   | At least two named methods beyond `Main`                                   | Week 9     |
| 8   | Read from or write to a file (CSV or plain text)                           | Week 10    |

---

## Grading Criteria

| Area                                                                      | Points  |
| ------------------------------------------------------------------------- | ------- |
| `DATA_MODEL.md` completed (5+ inputs, scenario, outputs, edge case)       | 10      |
| App compiles and runs without errors                                      | 10      |
| All 8 required concepts demonstrated in working code (5 pts each)         | 40      |
| Code quality — file header in every `.cs` file, formatted, readable names | 5       |
| Reflection section below completed                                        | 10      |
| **Total**                                                                 | **75**  |
| **Bonus: 5–10 min video walkthrough (app demo + code tour)**              | **+25** |

---

## Getting Started

1. Fill out `DATA_MODEL.md` **before writing any code**

2. Create your assignment branch:

    ```bash
    git checkout main
    git pull
    git checkout -b assignment/final-project
    ```

3. Scaffold a new console project inside the `final-project` folder:

    ```bash
    cd final-project
    dotnet new console -n YourAppName
    cd YourAppName
    ```

4. Build your app, running it often to test:

    ```bash
    dotnet run
    ```

5. Format your code before committing:

    ```bash
    dotnet format
    ```

---

## Helpful Tips / Common Pitfalls

- **Plan first** — a completed `DATA_MODEL.md` saves hours of rewriting halfway through
- **Build incrementally** — get `dotnet run` working with one feature before adding the next
- **Commit often** — small, frequent commits make it easy to undo mistakes
- **Re-read the checklist** before submitting — make sure all 8 concepts are present and visible
- **Don't over-scope** — a well-built small app beats an ambitious unfinished one

---

## Submission

1. Complete your app, fill out the reflection below, and format your code:

    ```bash
    dotnet format
    ```

2. Stage and commit everything:

    ```bash
    git add final-project/
    git commit -m "Final Project: [Your App Name]"
    ```

3. Push your branch:

    ```bash
    git push -u origin assignment/final-project
    ```

4. Open a pull request on GitHub:
    - Base branch: `main`
    - Title: `Final Project: [Your App Name]`
    - Add a short description of what your app does

5. Submit on Canvas:
    - Paste your **pull request URL** in the text submission box
    - If you recorded a video for bonus points, paste the **video link** on the next line

---

---

## My Project Reflection

_Fill out this section before submitting. Write in your own words — a few sentences per prompt is enough._

**Name:**
Kytte Burke

**App Name:**
My Games App

---

### What I Built

_Describe your app in 1–3 sentences. What does it do? Who might use it?_

Answer: A menu-driven Games Tracker that loads games from a CSV file and lets you view, add/save, and delete your games back to disk. People with a game collection would use this.

---

### Why I Chose This Idea

_Why did this app interest you? What made it feel like a good fit for what you know?_

Answer: I am have to get together a list of my games to give to friends who will be coming over to game.

---

### Required Concepts — Where I Used Them

_For each concept below, write one sentence describing where it appears in your code._

**Variables & data types:**
`string`, `int`, `bool` throughout

**If/else decisions:**
Empty-list guards, `File.Exists` branch

**Loops:**
Menu `while` loop

**Formatted string output:**
`PadRight` games table

**Array or List:**
`List<Game>` — game inventory

**Custom class:**
`Game.cs` — `GameName`, `GameCategory`, `ToCSV()`, `Parse()`

**Named methods:**
9 methods beyond `Main`

**File I/O:**
`LoadGames()` reads CSV, `SaveGames()` writes CSV

---

### What Was Most Challenging

_What part of the project was hardest? How did you work through it?_

Answer: The hardest part for me was two-fold:

1. deciding on a project
2. narrowing scope/preventing scope creep

To work through I just kept trying to keep myself on track by telling myself to work on this bit now
and then we can do the next and by referencing the Flashcard Quiz demo for scope terms.

---

### What I Would Do Differently

_If you had more time, what would you change, add, or improve?_

Answer: With more time I would add a bunch of features and other game information into the list. Features I would like to add include: adding player count and other stats; searching for a game by a player count/genre/etc; picking random game; and more.

---

### Time Spent

_Roughly how many hours did you spend total? Give a short breakdown._

| Task                  | Time |
| --------------------- | ---- |
| Planning / DATA_MODEL | 2    |
| Writing code          | 4.5  |
| Debugging             | .5   |
| Reflection / README   | 1    |
| **Total**             | 8    |
