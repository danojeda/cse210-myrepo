using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string user_name = PromptUserName ();
        int fav_number = PromptUserNumber();
        int sq_number = SquareNumber(fav_number);
        var my_program = new Program();
        my_program.DisplayResult (user_name, sq_number);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName ()
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        number = number * number;
        return number;
    }

    void DisplayResult (string name, int sq_number)
    {
        Console.WriteLine($"{name}, the square of your number is {sq_number}");
    }
}