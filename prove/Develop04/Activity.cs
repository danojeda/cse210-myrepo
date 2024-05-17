using System;
using System.Threading;
public class Activity
{
    private String _name;
    private String _description;
    private int _duration;


    public Activity(String name, String description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
        //_duration = duration;

    }

    public void DisplayStartingMessage()
    {

    }

    public void DisplayEndingMessage()
    {

    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int seconds)
    {

    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
}