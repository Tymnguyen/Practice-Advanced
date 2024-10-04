using System;

class Program
{
    static void Main(string[] args)
    {
        // Question 1: BMI Calculation
        Console.Write("Enter your weight (kg): ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Enter your height (m): ");
        double height = double.Parse(Console.ReadLine());

        double bmi = weight / (height * height);
        Console.WriteLine($"Your BMI is {bmi:F2}");

        if (bmi < 18.5)
            Console.WriteLine("Health category: Underweight");
        else if (bmi < 23)
            Console.WriteLine("Health category: Normal weight");
        else if (bmi < 27.5)
            Console.WriteLine("Health category: Overweight");
        else
            Console.WriteLine("Health category: Obese");

        // Question 2: Discount Calculation
        Console.Write("Enter the amount spent: ");
        double amountSpent = double.Parse(Console.ReadLine());
        double discountRate = 0;

        if (amountSpent > 1000)
            discountRate = 20;
        else if (amountSpent > 500)
            discountRate = 10;
        else if (amountSpent > 100)
            discountRate = 5;

        double discountAmount = amountSpent * discountRate / 100;
        Console.WriteLine($"Discount rate: {discountRate}%");
        Console.WriteLine($"Discount amount: ${discountAmount:F2}");

        // Question 3: Multiplication Table
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{i} x {number} = {i * number}");
        }

        // Question 4: Admin Menu
        int choice;
        do
        {
            Console.WriteLine("------------- MENU --------------");
            Console.WriteLine("[1] Calculate Body Mass Index");
            Console.WriteLine("[2] Calculate Discount");
            Console.WriteLine("[3] Display Multiplication Table");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("---------------------------------");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter your weight (kg): ");
                    weight = double.Parse(Console.ReadLine());
                    Console.Write("Enter your height (m): ");
                    height = double.Parse(Console.ReadLine());
                    bmi = weight / (height * height);
                    Console.WriteLine($"Your BMI is {bmi:F2}");
                    if (bmi < 18.5)
                        Console.WriteLine("Health category: Underweight");
                    else if (bmi < 23)
                        Console.WriteLine("Health category: Normal weight");
                    else if (bmi < 27.5)
                        Console.WriteLine("Health category: Overweight");
                    else
                        Console.WriteLine("Health category: Obese");
                    break;
                case 2:
                    Console.Write("Enter the amount spent: ");
                    amountSpent = double.Parse(Console.ReadLine());
                    discountRate = 0;
                    if (amountSpent > 1000)
                        discountRate = 20;
                    else if (amountSpent > 500)
                        discountRate = 10;
                    else if (amountSpent > 100)
                        discountRate = 5;
                    discountAmount = amountSpent * discountRate / 100;
                    Console.WriteLine($"Discount rate: {discountRate}%");
                    Console.WriteLine($"Discount amount: ${discountAmount:F2}");
                    break;
                case 3:
                    Console.Write("Enter a number: ");
                    number = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= 12; i++)
                    {
                        Console.WriteLine($"{i} x {number} = {i * number}");
                    }
                    break;
                case 0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (choice != 0);

        // Question 5: Unique Words List
        List<string> words = new List<string>();
        string word;
        int totalLetters = 0;

        while (words.Count < 5)
        {
            Console.Write("Enter a word (or 'x' to stop): ");
            word = Console.ReadLine();
            if (word == "x")
                break;

            if (!words.Contains(word))
            {
                words.Add(word);
                totalLetters += word.Length;
            }
        }

        Console.WriteLine("\nList of words:");
        foreach (string w in words)
        {
            Console.WriteLine($"- {w}");
        }
        Console.WriteLine($"Total number of letters: {totalLetters}");

        // Question 6: Number Guessing Game
        Random rand = new Random();
        int randomNumber = rand.Next(1, 101);
        int guesses = 0;
        int guess;

        do
        {
            Console.Write("Guess the number (between 1 and 100, or enter -1 to quit): ");
            guess = int.Parse(Console.ReadLine());

            if (guess == -1)
                break;

            guesses++;

            if (guess > randomNumber)
                Console.WriteLine("Too high!");
            else if (guess < randomNumber)
                Console.WriteLine("Too low!");
            else
                Console.WriteLine($"Congratulations! You guessed the correct number in {guesses} tries.");

        } while (guess != randomNumber && guesses < 5);

        if (guess != randomNumber)
            Console.WriteLine($"The correct number was {randomNumber}. Better luck next time!");
    }
}
