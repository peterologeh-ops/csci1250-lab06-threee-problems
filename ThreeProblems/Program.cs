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
using System.Runtime.CompilerServices;
using System.Xml.Schema;

const int QUIT_OPTION = 5;

//A menu that repeats until the user chooses to quit
int choice = 0;
while (choice != QUIT_OPTION)
{
    // Displaying the five menu options
    System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");
    System.Console.WriteLine("1. The Grade Checker");
    System.Console.WriteLine("2. The Dice Table");
    System.Console.WriteLine("3. The Score Report");
    System.Console.WriteLine("4. All three");
    System.Console.WriteLine("5. Quit");

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
        //Asking for the scores
        int score = 0;
        System.Console.Write("Enter a score (0=100): ");
        score = Convert.ToInt32(System.Console.ReadLine());

        //Repeats asking for score when the input is invalid
        while (score < 0 || score > 100)
        {
            //Printing the validation error
            System.Console.WriteLine("Invalid score! Please enter a value between 0 and 100.");

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
    }
}