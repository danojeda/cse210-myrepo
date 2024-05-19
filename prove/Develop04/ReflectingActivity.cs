
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity


{
    private List<String> _prompts = new List<String>();
    private List<String>_questions = new List<String> ();

    
    public  ReflectingActivity(List<String> prompts, List <String> questions,String name, String description, int duration) : base (name, description,duration)
    {
        _prompts = new List<string>(prompts);
        _questions = new List<string>(questions);
        
    }

    public void Run()
    {   
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

       
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
       
        Console.WriteLine();
        Console.WriteLine();    
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine();    
       
        
       
        while (DateTime.Now < futureTime)
        {
            String myQuestion = GetRandomQuestion();
            SetQuestion(myQuestion);
            DisplayQuestions();
            //base.ShowCountDown(1000);
            base.ShowSpinner(7);
        }



       

    }

    public string GetRandomPrompt()
    {
        string filename = "Prompts.txt";
        string [] lines = System.IO.File.ReadAllLines(filename);
        Random rnd = new Random();
        int num = rnd.Next(0,lines.Length);
        return lines [num];
    }

   

    public string GetRandomQuestion()
    {
        string filename = "questions.txt";
        string [] lines = System.IO.File.ReadAllLines(filename);
        Random rnd = new Random();
        int num = rnd.Next(0,lines.Length);
        return lines [num];
    }

    public void DisplayPrompt()
    {   
        Console.WriteLine("Consider the following prompt:");
        foreach (string prompt in _prompts)
        {
            Console.Write("---");
            Console.Write(prompt);
            Console.WriteLine("---");
        }
        
    }

    public void DisplayQuestions()
    {   
        base.ShowSpinner(5);
        int myLast = _questions.Count;
        myLast = myLast -1;
        Console.WriteLine(_questions[myLast]);

       

    }


    public void SetPrompt (string prompt)
    {
        _prompts.Add(prompt);
    }

    public void SetQuestion (string question)
    {
        _questions.Add(question);
    }
}