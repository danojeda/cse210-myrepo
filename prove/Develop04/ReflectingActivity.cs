
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity


{
    private List<String> _prompts = new List<String>();
    private List<String>_questions = new List<String> ();

    //  public Activity(String name, String description, int duration)
    private ReflectingActivity(List<String> prompts, List <String> questions,String name, String description, int duration) : base (name, description,duration)
    {

    }

    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        return " ";
    }

    public string GetRandomQuestion()
    {
        return " ";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {

    }

}