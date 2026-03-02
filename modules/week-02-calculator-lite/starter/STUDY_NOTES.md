# Week 2: Calculator Lite - Study Notes

**Name:** Kytte Burke

## Understanding Data Types

**What are the four data types you used in this assignment?**
[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer: string - alphanumeric; bool - true/false; int - integer literal numbers; double - real number values

**Why did we use `double` instead of `int` for the calculations?**
[Explain the difference between int and double, and why double is better for this calculator]

Answer: int doesn't include decimals but double does. we need this because certain calculations result in needing the decimals

**How do you convert a string to a boolean?**
[Explain how you converted the user's "yes/no" input into a true/false value]

Answer:a conditional statement was used for conversion

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer: getting the tests to work

**How you solved it:**
[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer: reviewed documentaion and tried different commands

**Most confusing concept:**
[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer: most confusing was the way the TODO statements were laid out with some TODOs listed after they were needed. the pre-provided progam code did not follow the assignment instructions so this was a bit confusing too.

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer: division provides the quotient while modulus provides the remainder. for example 15/2 = 7 while 15%2 = 5

**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer: you add the two numbers together and then divide by 2

**What is the formula for percentage difference?**
[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer: you subtract 2nd number from 1st number then you divide that subtotal by 1st number, lastly you take that total and multiply it by 100

## Input and Output

**How do you read user input in C#?**
[Explain what Console.ReadLine() does and what type of data it returns]

Answer: it takes user input and returns it as a string

**How do you convert string input to a number?**
[Explain the Parse methods you used, like double.Parse()]

Answer: using Parse (in it's many guises) allows us to take the inputed string and convert it into a number that can be used for calculations

**What is string interpolation and how did you use it?**
[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer: using $ allows you to pull in what is currently in variable to make your writeline dynamic instead of hard coded

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
[Explain the :F2 and :F0 format specifiers]

Answer: the :F indicates to the program what decimal place is desired with the 2/0/etc defines how many places are displayed

**Why is it important to check for division by zero?**
[Explain what happens if you try to divide by zero and how you handled it]

Answer: division by zero does not provide a 'legal' answer and would break a program. conditional programming was implemented to check for zero for calculations where this might be an issue

**How did you use the boolean variable to control formatting?**
[Explain how you used if/else to format output differently based on user preference]

Answer: if/else provides different pathways depending on the results of a conditional statment (or statments)

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1. always be sure to use the correct data type to get the results you are looking for
2. remember that input from ReadLine() is always a string and needs casting for calculations, etc
3. always check for division by zero
4.
5.

**Which data type concept was most useful?**
[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer: I find bool most interesting because even though there are just 2 values you can do so much with them

**How does conditional formatting improve user experience?**
[Why is it helpful to let users choose decimal precision?]

Answer: it gives control to the user which usually makes users happier and more willing to use it

## Testing and Debugging

**What test cases did you use to verify your program works?**
[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer: positive numbers, decimals, zero

**What bugs or errors did you encounter and fix?**
[Describe any errors you got and how you fixed them]

Answer: I had a couple of spelling errors that were fixed when I fixed the typos.

## Time Spent

**Total time:** [2.75 hours]

**Breakdown:**

- Understanding data types: [.25 hours]
- Reading and parsing user input: [.25 hours]
- Implementing arithmetic operations: [.5 hours]
- Adding conditional formatting: [.5 hours]
- Handling division by zero: [.5 hours]
- Testing and debugging: [.25 hours]
- Writing documentation: [.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: conditional formatting/handling division by zero/implementing arithmetic operations combined to take the longest because of the puzzle of where to put things and in what order

## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer: I would try to start earlier and run the lab multiple times before beginning the assignment

**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer: this assignment taught the basics of data types, calculations, and conditionals that will be used in every project going forward
