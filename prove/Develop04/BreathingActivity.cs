
public class BreathingActivity : Activity
{
    public BreathingActivity (String name, String description, int duration) : base (name,description,duration)   
    {

    }

    public void Run()
    {
       
        Console.Clear();
        Console.WriteLine("Clear your mind and focus on your breathing.");
       

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        String message1 = "Breathe in...";
        String message2 = "Breath out...";
        

        
        while (DateTime.Now < futureTime)
        {   
            
            Console.Write(message1);
           

            base.ShowCountDown(1000);
            
            Console.WriteLine();
            
            
            Console.Write(message2);
           
            base.ShowCountDown(1000);
            Console.WriteLine();
            
        }
       


    }


}

