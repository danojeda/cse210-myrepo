using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        Console.WriteLine("Welcome to this mindfulness thing.");
        int option=0;
        //   public Activity(String name, String description, int duration)
        Activity myTestActivity = new Activity ("Actividad201", "Una buena 02 Actividad", 5);

        do
        {
            Console.WriteLine("1. Breathing Activity.");
            Console.WriteLine("2. Listing Activity.");
            Console.WriteLine("3. Reflecting Activity.");
            Console.WriteLine("4. Quit.");
            Console.WriteLine();
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                // BreathingActivity (String name, String description, int duration) : base (name,description,duration)    
                BreathingActivity myBreathingActivity = new BreathingActivity("Breathing","This is a breathing activity",1);
                myBreathingActivity.Run();
            }
            else if (option ==2)
            {

            }
            else if (option ==3)
            {

            }else
            {
                Console.WriteLine("This is not a valid option!.");
            }

        }while (option !=4);





    }
}