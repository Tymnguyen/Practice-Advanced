using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Declare an integer variable and print its value
        int num = 10;
        Console.WriteLine($"The value of num is: {num}");

        // Part 2: Concatenate two strings and print the result
        string firstName = "John";
        string lastName = "Doe";
        Console.WriteLine($"The full name is: {firstName} {lastName}");

        // Part 3: Get the user's age as input and print it to the console
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"Your age is: {age}");

        // Part 4: Calculate the sum of two integers
        int a = 5;
        int b = 7;
        int sum = a + b;
        Console.WriteLine($"The sum of {a} and {b} is: {sum}");

        // Part 5: Convert the temperature from Celsius to Fahrenheit
        double celsius = 25;
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"The Fahrenheit equivalent is: {fahrenheit}");

        // Part 6: Declare a player's health and print it
        int playerHealth = 100;
        Console.WriteLine($"Player's health: {playerHealth}");

        // Part 7: Get the player's name as input and concatenate it with the game's title
        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();
        Console.WriteLine($"Welcome to the game, {playerName}!");

        // Part 8: Calculate the area of a rectangular movement space
        int length = 10;
        int width = 5;
        int area = length * width;
        Console.WriteLine($"The area of the rectangular movement space is: {area}");

        // Part 9: Convert player's level from string to integer
        string playerLevel = "Level 10";
        int levelNumber = int.Parse(playerLevel.Replace("Level ", ""));
        Console.WriteLine($"Player's Level as an integer: {levelNumber}");

        // Part 10: Calculate the total score in a game
        int enemyPoints = 100;
        int bonusPoints = 50;
        int totalScore = enemyPoints + bonusPoints;
        Console.WriteLine($"The total score is: {totalScore}");

        // Part 11: Change string to upper case, lower case, and title case
        Console.Write("Enter the string: ");
        string inputString = Console.ReadLine();
        Console.WriteLine($"The string in upper case: {inputString.ToUpper()}");
        Console.WriteLine($"The string in lower case: {inputString.ToLower()}");
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        Console.WriteLine($"The string in title case: {textInfo.ToTitleCase(inputString)}");

        // Part 12: Calculate compound interest
        double principalAmount = 1000;
        double interestRate = 5;
        int timePeriod = 3;
        double compoundInterest = principalAmount * Math.Pow(1 + interestRate / 100, timePeriod) - principalAmount;
        Console.WriteLine($"The compound interest is: {compoundInterest:F2}");

        // Part 13: Swap two numbers
        int firstNumber = 5;
        int secondNumber = 10;
        Console.WriteLine($"Before swapping: First number: {firstNumber}, Second number: {secondNumber}");
        int temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;
        Console.WriteLine($"After swapping: First number: {firstNumber}, Second number: {secondNumber}");

        // Part 14: Find the largest of three numbers
        int num1 = 25, num2 = 78, num3 = 87;
        int largest = Math.Max(num1, Math.Max(num2, num3));
        Console.WriteLine($"The greatest number is: {largest}");

        // Part 15: Find the greatest common divisor (GCD) of two numbers
        int number1 = 12;
        int number2 = 18;
        while (number1 != number2)
        {
            if (number1 > number2)
                number1 -= number2;
            else
                number2 -= number1;
        }
        Console.WriteLine($"The GCD is: {number1}");

        // Part 16: Calculate the volume of a sphere
        double radius = 3;
        double volume = (4 / 3.0) * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine($"The volume of the sphere is: {volume}");

        // Part 17: Find the index of a character in a string starting from a specified position
        string searchString = "hello world";
        char searchChar = 'o';
        int startingPosition = 5;
        int index = searchString.IndexOf(searchChar, startingPosition);
        Console.WriteLine($"The index of '{searchChar}' starting from position {startingPosition} is: {index}");

        // Part 18: Remove a specific character from a string
        string input = "apple";
        char charToRemove = 'p';
        string result = input.Replace(charToRemove.ToString(), "");
        Console.WriteLine($"The string after removing '{charToRemove}' is: {result}");

        // Part 19: Replace all occurrences of a character in a string with another character
        string bananaString = "banana";
        string replacedString = bananaString.Replace('a', 'o');
        Console.WriteLine($"The string after replacing 'a' with 'o' is: {replacedString}");

        // Part 20: Extract a substring from a string
        string helloString = "hello world";
        int startIndex = 3;
        int length = 4;
        string substring = helloString.Substring(startIndex, length);
        Console.WriteLine($"The substring from index {startIndex} to {startIndex + length} is: {substring}");
    }
}
