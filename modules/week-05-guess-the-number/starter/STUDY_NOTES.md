# Week 5: Guess the Number - Study Notes

**Name:** Kytte Burke
Kytte Burke

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: A 'do-while' loop always runs at least once and a 'while' loop will sometimes not need to run.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer: A 'do-while' loop was used in the ReadIntInRange helper method as we want it to initially run to check if input is valid and to continue running until it is.

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer: A 'while' loop was used in writing the code needed when guessing the secret number. We use while since we only want it to run until the guess is correct.

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer: Because we will know beforehand, from user input, how many times we need to run the loop a for loop is best used for the rounds loop.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer: A helper method was used so the same code didn't need to be typed everytime there was a need for input validation.

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer: A set of conditional statements was used for checking the minimum and maximum allowable numbers and seeing if the input was valid.

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer: same as above answer

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer: The int.TryParse method trys to convert the string input into an int. Getting a false result means the string wasn't a number to begin with and it would be invalid for our value and round checks.

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer: I used while and if/else if loops to test each circumstance in junction with conditional statements.

**How did you count the number of guesses?**
[Explain where you incremented the counter]

Answer: I used guessCount++ after each guess attempt whether or not it was correct.

## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

Answer: I incremented the guessCount variable after each guess by 1 (guessCount++)

**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

Answer: We need the +1 because the base method does not include the raw number listed as the 2nd parameter.

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

Answer: I tested negative numbers, numbers outside of the min/max, and correct numbers.

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

Answer: I had some misspellings, misplaced braces, and forgot for a moment it is 2 && not 1 & for and conditions.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. different loops have different times when they are best used
2. creating methods for often used code provides clarity and cleaness of code
3. loops are fun!
4.
5.

**Which loop felt most natural to use and why?**

Answer: I think the if type loops feel most natural to use because they follow my normal thinking/decision patterns

## Time Spent

**Total time:** 3.5 hours

**Breakdown:**

- Planning the loops: [.5 hours]
- Input validation: [.75 hours]
- Guessing logic: [.75 hours]
- Testing and debugging: [.5 hours]
- Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Filling out the study notes is the most time consuming for me.

## Reflection

**What would you do differently next time?**

Answer: work on the study notes throughout my coding instead of trying to do all of it at the end.

**How did using three different loop types improve your understanding of repetition?**

Answer: it showed various different ways that repetition can be done.
