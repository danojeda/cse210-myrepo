using System;

class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        Console.Clear();
        Console.WriteLine("Welcome to this mindfulness thing.");
        int option=0;
        // This variable is to count the activities that has been done.
        int myActivitiesCounter =0;
        
        Activity myTestActivity = new Activity ("Actividad201", "Una buena 02 Actividad", 5);
        Console.WriteLine();
        Console.WriteLine();    
        do
        {
            Console.WriteLine("1. Breathing Activity.");
            Console.WriteLine("2. Listing Activity.");
            Console.WriteLine("3. Reflecting Activity.");
            Console.WriteLine("4. Quit.");
            Console.WriteLine();
            Console.WriteLine("Select an option from the menu.");
            Console.WriteLine();
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                
                BreathingActivity myBreathingActivity = new 
                BreathingActivity("Breathing Activity","This activity will help you relax by walking you through breathing in and out slowly.Clear your mind and focus on youir breathing.",1);
                myBreathingActivity.DisplayStartingMessage();
                myBreathingActivity.Run();

                myBreathingActivity.DisplayEndingMessage();
                myBreathingActivity.ShowSpinner(15);

                // With this following 3 lines I show how many activities has been completed.
                myActivitiesCounter++;
                myBreathingActivity.ActivitiesCounter(myActivitiesCounter);
                Thread.Sleep(5000);
                Console.Clear();
            }
            else if (option ==2)
            {
                
                List <String> thisPrompts2 = new List<String>();
                
                ListingActivity myListingActivity = new 
                ListingActivity (0,thisPrompts2, "Listing Activity",
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",0);
                myListingActivity.DisplayStartingMessage();
                myListingActivity.Run();
                myListingActivity.DisplayEndingMessage();
                myListingActivity.ShowSpinner(15);

                // With this following 3 lines I show how many activities has been completed.
                myActivitiesCounter++;
                myListingActivity.ActivitiesCounter(myActivitiesCounter);
                Thread.Sleep(5000);
                Console.Clear();
                


            }
            else if (option ==3)
            {
                
                List <String> thisPrompts = new List<String>();
                List <String> thisQuestions = new List<String>();
                
                ReflectingActivity myReflectingActivity = new ReflectingActivity (thisPrompts,thisQuestions,"Reflecting Activity",
                "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", 
                0);
                String myPrompt = myReflectingActivity.GetRandomPrompt();
                myReflectingActivity.SetPrompt(myPrompt);
               
                
               
                myReflectingActivity.DisplayStartingMessage();
                myReflectingActivity.Run();
                myReflectingActivity.DisplayEndingMessage();
                myReflectingActivity.ShowSpinner(15);
                
                // With this following 3 lines I show how many activities has been completed.
                myActivitiesCounter++;
                myReflectingActivity.ActivitiesCounter(myActivitiesCounter);
                Thread.Sleep(5000);

                Console.Clear();
                
                

            }else if (option == 4)
            {
                break;
            }else
            {
                Console.WriteLine("This is not a valid option!.");
            }

        }while (option !=4);





    }
}