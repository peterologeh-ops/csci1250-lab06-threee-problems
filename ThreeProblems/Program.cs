/*
 * Name:        Oghaleoghene Ibereola Peter Ologeh
 * Course:      CSCI 1250, Section 001
 * Assignment:  Lab 06, Three Short Problems
 * Date:        October 21, 2026
 * Description: A menu that keeps running until the user quits, offering three
                independent exercises or all three at once. Each exercise 
                practices decisions and one of the four loops
*/


//Constants for the menu
using System.Data;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

const int QUIT_OPTION = 5;

//Random number generator
Random rng = new Random(4000);

//A menu that repeats until the user chooses to quit
int choice = 0;

while (choice != QUIT_OPTION)
{
    // Displaying the five menu options
    System.Console.WriteLine(" ");
    System.Console.WriteLine("=== THE MENU ===");
    System.Console.WriteLine("1. The Grade Checker");
    System.Console.WriteLine("2. The Dice Table");
    System.Console.WriteLine("3. The Score Report");
    System.Console.WriteLine("4. All three");
    System.Console.WriteLine("5. Quit");
    System.Console.WriteLine(" ");

    //Asking the user for a choice
    System.Console.Write("Choose 1 through 5: ");
    choice = Convert.ToInt32(System.Console.ReadLine());

    //Validating the users choice
    while (choice < 1 || choice > 5)
    {
        //Displaying an error message
        System.Console.WriteLine("Invalid entry. Please choose a valid option (1-5).");

        //Asking user for the choice again
        System.Console.Write("Choose 1 through 5: ");
        choice = Convert.ToInt32(System.Console.ReadLine());

    }

    
    //Using separate 'if' statements for the choices
    if (choice == 1)
    {
        //Exercise 1 - The Grade Checker
        //Displaying the Header for Exercise 1
        System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");
        
        //Asking for the scores
        int score = 0;
        System.Console.Write("Score: ");
        score = Convert.ToInt32(System.Console.ReadLine());

        //Repeats asking for score when the input is invalid
        while (score < 0 || score > 100)
        {
            //Printing the validation error
            System.Console.WriteLine("A score must be between 0 and 100.");

            //Asking for another score
            System.Console.Write("Enter a score (0-100): ");
            score = Convert.ToInt32(System.Console.ReadLine());
        }

        //Determining the letter grade
        string grade = "";
        if (score >= 90)
        {
            grade = "A";
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        //Displaying the grade
        System.Console.WriteLine($"{score} earns a {grade}");
        System.Console.WriteLine(" ");
    }

    if (choice == 2)
    {
        //Exercise 2
        //Initializing the roll counter
        int rollCounter = 0;

        //Displaying the Header for Exercise 2
        System.Console.WriteLine("=== Exercise 2: The Dice Table ===");

        //Initializing the win counter
        int winCounter = 0;

        //Continue rolling until the player chooses to stop
        string playAgain = "y";
        while (playAgain == "y")
        {
            //Generating two dice values
            int die1 = rng.Next(1, 7);
            int die2 = rng.Next(1, 7);

            //Calculating the total
            int total = die1 + die2;

            //Increasing the roll number
            rollCounter++;

            //Displaying the roll number, dice, and the total
            System.Console.WriteLine($"Roll {rollCounter}: You rolled {die1} and {die2}. Total = {total}");

            //Checking for snake eyes FIRST
            if (die1 == 1 && die2 == 1)
            {
                //Printing Snake Eyes
                System.Console.WriteLine("Snake Eyes!");
            }
            else if (die1 == die2)
            {
                //Printing Doubles
                System.Console.WriteLine("Doubles!");
            }
            else if (total == 7 || total == 11)
            {
                //Printing winner
                System.Console.WriteLine("A Winner!");

                //Increasing the win counter
                winCounter++;
            }

            //Asking the user if they want to roll again
            System.Console.Write("Do you want to roll again? (y/n)");
            playAgain = System.Console.ReadLine().ToLower();
            System.Console.WriteLine(" ");
        }
    
     //Displaying the total rolls and wins
     System.Console.WriteLine($"\nGame Over!");
     System.Console.WriteLine($"You rolled {rollCounter} and won {winCounter}");
    }

    if (choice == 3)
    {
        //Exercise 3
        //Creating an array capable of storing five scores
        int[] scores = new int[5];

        //The Header for Exercise 3
        System.Console.WriteLine("=== Exercise 3: The Score Report ===");

        //The 1st Loop
        //Using a loop to collect scores
        for (int i = 0; i < scores.Length; i++)
        {
            //Asking for Score 1, Score 2, Score 3, and so on
            System.Console.Write($"Score {i + 1}: ");
            
            //Storing each entered score into the array
            scores[i] = System.Convert.ToInt32(System.Console.ReadLine());
        }

        //The 2nd Loop
        //Initializing total, highest score, and passing count
        int total = 0;
        int highestScore = int.MinValue;
        int passingCount = 0;

        //Using a loop to examine every score
        foreach (int score in scores)
        {
            //Adding the score to the total
            total += score;

            //Updating the highest score when necessary
            if (score > highestScore)
            {
                highestScore = score;
            }

            //Increasing the passing count when score is at least 60
            if (score >= 60)
            {
                passingCount++;
            }

        }

        //Calculating the average
        double average = (double)total / scores.Length;

        //Displaying the summary
        System.Console.WriteLine(" ");
        System.Console.WriteLine($"Scores Entered: {string.Join(", ", scores)}");
        System.Console.WriteLine($"Total: {total}");
        System.Console.WriteLine($"Average: {average:F2}");
        System.Console.WriteLine($"Highest: {highestScore}");
        System.Console.WriteLine($"Passing: {passingCount} of {scores.Length}");
        System.Console.WriteLine(" ");
    }

}

