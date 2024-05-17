
public class BreathingActivity : Activity
{
     //public Activity(String name, String description, int duration)
        //BreathingActivity ( int duration) : base (duration)
    public BreathingActivity (String name, String description, int duration) : base (name,description,duration)   
    {

    }

    public void Run()
    {
        Console.WriteLine("This section is under construction");
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on youir breathing.");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int thisDuration = int.Parse(Console.ReadLine());
        SetDuration(thisDuration);
    }


}