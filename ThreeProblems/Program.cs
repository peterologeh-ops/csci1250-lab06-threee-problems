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
}
