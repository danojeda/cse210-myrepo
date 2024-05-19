using System;
using System.Threading;
public class ListingActivity : Activity
{
    private int _count;
    private List<String> _prompts = new List<String>();


    
    public ListingActivity(int count , List<String> prompts, String name, String description, int duration) : base (name,description,duration)
    {   
        
        _count = count;
        _prompts = new List<string>(prompts);

    }

    public void Run()
    {   
        Console.Clear();
        Console.WriteLine("Get ready....");
        base.ShowSpinner(6);
        Console.WriteLine("List as many responses you can to the following prompt:");
        string thisPrompt = GetRandomPrompt();
        Console.WriteLine($"---{thisPrompt}---");
        Console.WriteLine("You may begin in:");
        base.ShowCountDown(1000);
        
        List <string>listFromTheUser =  GetListFromUser();
        Console.WriteLine($"You listed {_count} items!.");
        

    }

    public string GetRandomPrompt()
    {
        string filename = "listingPrompt.txt";
        string [] lines = System.IO.File.ReadAllLines(filename);
        Random rnd = new Random ();
        int num = rnd.Next(0,lines.Length);
        return lines [num];
       
    }


    
    
    public List<String> GetListFromUser()
    {   
        List <string> userList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        do
        {   
            
            string yourResponse = Console.ReadLine();
            userList.Add(yourResponse);
            _count = _count +1;
        }while(DateTime.Now <  futureTime);

        return userList;
    }
    

}