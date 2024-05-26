using System.ComponentModel.DataAnnotations;
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
        

        int option =0;
        

        do
        {   
            
            
            DisplayPlayerinfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
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
                
                ListGoalDetails();
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
        
        Console.WriteLine("");
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        
        int index =1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($" {index} {goal.GetName()}");
            index++;
        }
    }


    public void ListGoalDetails()
    {
        
        int myIndex=1;
        foreach (Goal goal in _goals)
        {
            string thisDetail = goal.GetDetailsString();
            Console.WriteLine($"{myIndex}{thisDetail}");
           
            myIndex++;
        }
    }

    public void CreateGoal()
    {
        
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
                    
                    _goals.Add(mySimpleGoal);


                }else if (goalOption == 2)
                {
                    Console.WriteLine("You hace chosen 1 >> 2");
                    
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
        
        ListGoalNames();
        
        Console.WriteLine("Please select a Goal from the list above.");
        int goalSelected = int.Parse(Console.ReadLine());
        goalSelected--;
        Console.WriteLine($"You have selected {_goals[goalSelected].GetName()}");
        _goals[goalSelected].RecordEvent();
        _score = _score + int.Parse(_goals[goalSelected].GetPoints());

       DisplayPlayerinfo();

        
    }

    public void  AddScore (int bonus)
    {
        _score += bonus;
    }
    public void SaveGoals()
    {
       
        Console.WriteLine("What is the name of the file you want to save to?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter (filename))
        {   
            outputFile.WriteLine(_score);
            for (int i=0;i< _goals.Count;i++)
            {
                outputFile.WriteLine(_goals[i].GetStringRepresentation());

            }
        }

      


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
            Console.WriteLine();
         
            if (parts[0] == "SimpleGoal")
            {
                
                SimpleGoal loadedSimpleGoal = new SimpleGoal(parts[1],parts[2],parts[3]);
                _goals.Add(loadedSimpleGoal);
            }else if (parts[0] == "EternalGoal")
            {
              
                EternalGoal loadedEternalGoal = new  EternalGoal (parts[1],parts[2],parts[3]);       
                _goals.Add(loadedEternalGoal);        

            }else if (parts[0]== "ChecklistGoal")
            {
                
                ChecklistGoal loadedChecklistGoal = new ChecklistGoal (parts[1],parts[2],parts[3],int.Parse(parts[5]),int.Parse(parts[6]));
                loadedChecklistGoal.SetAmmountCompleted(int.Parse(parts[4]));
                _goals.Add(loadedChecklistGoal);
            }else{
                _score = int.Parse(parts[0]);
            }
        }


    }
}