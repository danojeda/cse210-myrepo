using System;
using System.Threading;
public class ListingActivity : Activity
{
    private int _count;
    private List<String> _prompts = new List<String>();


    //  public Activity(String name, String description, int duration)
    public ListingActivity(int count , List<String> prompts, String name, String description, int duration) : base (name,description,duration)
    {
        _count = count;

    }

    public void Run()
    {

    }

    public void GetRandomPrompt()
    {

    }


    /*
    public List<String> GetListFromUser()
    {

    }*/

}