using System;
// Random randomGenerator = new Random();
//int number = randomGenerator.Next(1, 11);
class Program
{
    static void Main(string[] args)
    {
       
        int guess_number;
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next (1,100);

        do 
        {   
            

            Console.WriteLine("What is your guess?:");
            guess_number = int.Parse(Console.ReadLine());

            if (guess_number > magic_number){
                Console.WriteLine("Lower");
            }else if (guess_number < magic_number){
                Console.WriteLine("Higher");
            }else{
                Console.WriteLine("You guessed it!");
            }


        }while (guess_number != magic_number);
        


    }
}