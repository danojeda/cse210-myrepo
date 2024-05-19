using System;
using System.Threading;
public class Activity
{
    private String _name;
    private String _description;
    protected int _duration;


    public Activity(String name, String description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
       

    }

    public void DisplayStartingMessage()
    {   
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine($"Welcome to this {_name}");
        Console.WriteLine($"{_description}");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int thisDuration = int.Parse(Console.ReadLine());
        SetDuration(thisDuration);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();    
        Console.WriteLine("Well done!.");
        Console.WriteLine($"You have completed another {_duration} minutes {_name}.");
        Console.WriteLine();    
    }

    public void ShowSpinner(int seconds)
    {
        char [] spinnerChars = {'|','/','-','\\'};
        int index =0;
        DateTime futureTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < futureTime )
        {
            Console.Write($"{spinnerChars[index]}");
            Thread.Sleep(100);
            index = index+1;
            Thread.Sleep(300);
            Console.Write("\b \b");  
            if (index == spinnerChars.Length)
            {
                index =0;
            }

        }


        /*
          DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        */
    }

    public void ShowCountDown(int seconds)
    {
         for (int i=5;i>0;i--)
            {
                Console.Write(i);
                Thread.Sleep(seconds);  
                Console.Write("\b \b");  
            }
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
}