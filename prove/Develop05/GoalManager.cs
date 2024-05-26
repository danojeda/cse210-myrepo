using System.IO; 
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score ;


    public GoalManager(List<Goal> goals, int score)
    {
        _score = score;
        _goals = goals;

    }

    public void Start()
    {
        //Display main menu and display player info
        //Call:
        //CreateGoal, ListGoalDetails, SaveGoals, LoadGoals, ReciordEvent, Exit

        int option =0;
        //int goalOption=0;
        int totalScore =0;


        do
        {   
            
            Console.WriteLine($"You have {totalScore} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Otions:");
            Console.WriteLine();
            Console.WriteLine("1. Create New Goal.");
            Console.WriteLine("2. List Goals.");
            Console.WriteLine("3. Save Goals.");
            Console.WriteLine("4. Load Goals.");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select an option from the menu.");
            Console.WriteLine();
            Console.WriteLine();
            option = int.Parse(Console.ReadLine());    



            if (option == 1)
            {
                CreateGoal();
            
            }else if (option == 2)
            {
                ListGoalNames();
            }else if (option ==3)
            {
                SaveGoals();
            }else if (option == 4)
            {
                LoadGoals();
            }else if (option == 5)
            {
                RecordEvent();
            }else if (option == 6)
            {
                break;
            }
            else{
                Console.WriteLine("Please enrter a valid number from 1 to 6");
            }

            
        }while (option !=6);

    }

    public void DisplayPlayerinfo()
    {
        // Display the points
    }

    public void ListGoalNames()
    {
        // Loop thropugh the list of Goals and display  the names(_shortName)
        // you may need another function in the Goal class
        int index =1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($" {index} [ ] {goal.GetName()}");
            index++;
        }
    }


    public void ListGoalDetails()
    {
        // Loop through the list of Goals and display the full details, usando la base getdetailsstring function
    }

    public void CreateGoal()
    {
        // Display a suib menu to display the goal type 
        // Then ask for name description and point
        // ask for more if applies
        // create the object and add to teh goal list
        int goalOption=0;
        Console.WriteLine("You have chosen option 1");
                Console.WriteLine();
                Console.WriteLine("The types of Goal are:");
                Console.WriteLine("1. Simple Goal.");
                Console.WriteLine("2. Eternal Goal.");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("Which type of goal would you desire to create?");
                Console.WriteLine();
                goalOption = int.Parse (Console.ReadLine());

                if (goalOption ==1)    
                {
                    Console.WriteLine("You hace chosen 1 >> 1");
                    Console.WriteLine("What is the name of your goal?");    
                    string simpleGoalName = Console.ReadLine();
                    Console.WriteLine("What is a short description of it?");
                    string simpleGoalDescription = Console.ReadLine();
                    Console.WriteLine("How many points are associated with this goal?");
                    string simpleGoalPoints = Console.ReadLine();
                    SimpleGoal mySimpleGoal = new SimpleGoal (simpleGoalName,simpleGoalDescription,simpleGoalPoints);
                    //  public SimpleGoal(string name, string description, string points ):base (name,description,points)
                    _goals.Add(mySimpleGoal);


                }else if (goalOption == 2)
                {
                    Console.WriteLine("You hace chosen 1 >> 2");
                    // public EternalGoal (string name, string description, string points):base (name,description,points)
                    Console.WriteLine("What is the name of your goal?");   
                    string eternalGoalName = Console.ReadLine();
                    Console.WriteLine("What is a short description of it?"); 
                    string eternalGoalDescription = Console.ReadLine();    
                    Console.WriteLine("How many points are associated with this goal?");
                    string eternalGoalPoints = Console.ReadLine();
                    EternalGoal myEternalGoal = new EternalGoal (eternalGoalName, eternalGoalDescription, eternalGoalPoints);
                    _goals.Add(myEternalGoal);


                }else if (goalOption ==3)
                {
                    Console.WriteLine("You hace chosen 1 >> 3");
                    // public  ChecklistGoal(string name, string description, string points, int target, int bonus):base (name,description,points)
                    Console.WriteLine("What is the name of your goal?");  
                    string checklistGoalName = Console.ReadLine();
                    Console.WriteLine("What is a short description of it?"); 
                    string checklistGoalDescription = Console.ReadLine();
                    Console.WriteLine("How many points are associated with this goal?");
                    string checkListGoalPoints = Console.ReadLine();
                    Console.WriteLine("How many times does this goal needs to be achieved?.");
                    int checkListGoalTarget = int.Parse(Console.ReadLine()) ;
                    Console.WriteLine("What is the bonus for achieve it that many times?.");
                    int checkListGoalBonus = int.Parse(Console.ReadLine()) ;
                    // = Console.ReadLine();
                    ChecklistGoal myChecklistGoal = new ChecklistGoal(checklistGoalName,checklistGoalDescription,checkListGoalPoints,checkListGoalTarget,checkListGoalBonus);
                    _goals.Add(myChecklistGoal); 

                }else{
                    Console.WriteLine("Please, enter a valid option, between 1 and 3");
                    
                }

                Console.WriteLine();
                Console.WriteLine();

    }

    public void RecordEvent()
    {
        // Dsiplay a list of all of the GoalNames
        ListGoalNames();
        // Becasue we are going to ask the user to select a goal
        Console.WriteLine("Please select a Goal from the list above.");
        int goalSelected = int.Parse(Console.ReadLine());
        goalSelected--;
        Console.WriteLine($"You have selected {_goals[goalSelected].GetName()}");

        // Then we are going to have to call the RecordEvent on the correct goal
        // then update teh score based on the points
        // Display current points
    }

    public void SaveGoals()
    {
        // ask user for a filename and loop through the goals and convert each goal to a string and then save the string
        // With GetStringRepresentation
        Console.WriteLine("What is the name of the file you want to save to?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter (filename))
        {
            for (int i=0;i< _goals.Count;i++)
            {
                outputFile.WriteLine(_goals[i].GetStringRepresentation());

            }
        }

        /*
        using (StreamWriter outputFile = new StreamWriter(filename))
{
    // You can add text to the file with the WriteLine method
    outputFile.WriteLine("This will be the first line in the file.");
    
    // You can use the $ and include variables just like with Console.WriteLine
    string color = "Blue";
    outputFile.WriteLine($"My favorite color is {color}");
}
        */


    }

    public void LoadGoals()
    {
        // ask teh user for filename, read each line of the file and split it up
        // use the parts to recreate teh goal parts to recreate the goal object 
         Console.WriteLine("What is the name of the file you want to load from?");
        string filename = Console.ReadLine();
        string [] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            
        }


        /*
        string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
    string[] parts = line.Split(",");

    string firstName = parts[0];
    string lastName = parts[1];
        }
        */
    }
}