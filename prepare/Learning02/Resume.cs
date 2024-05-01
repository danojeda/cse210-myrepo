
using System.ComponentModel;
using System.Linq.Expressions;

public class Resume
{
    public string _personName;
    // Create the member variable for the list of Jobs 
    //List<int> numbers = new List<int>();
    public List <Job> _jobList = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");
        foreach (Job chamba in _jobList)
        {
            Console.WriteLine($"{chamba._jobTitle} ({chamba._company}) {chamba._starYear} - {chamba._endYear}");
        }
        
    }
}

/*foreach (string word in words)
{
    Console.WriteLine(word);
}*/
/*In the method body, you should display the person's name and then iterate through each Job instance in the list of jobs and display them.*/