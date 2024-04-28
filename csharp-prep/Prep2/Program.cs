using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please entrer your grade percentage:");
        int grade_percent= int.Parse(Console.ReadLine());
        string grade_letter;

        if (grade_percent >=90){
            grade_letter = "A";
            
        }else if (grade_percent >= 80){
            grade_letter = "B";
            
        }else if (grade_percent >= 70){
            grade_letter="C";
            
        }else if(grade_percent >= 60)
        {
            grade_letter = "D";
        }else{
            grade_letter = "F";
        }


        Console.WriteLine($"Your letter grade is: {grade_letter}.");


        if (grade_percent >= 70)
        {
            Console.WriteLine("Congratulations!, you have passed the course!.");

        } else{
            Console.WriteLine("Best luck next time.");
        }
    }
}