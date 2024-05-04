using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        int option=0;
        
        Journal myJournal = new Journal();

        do
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            //Here I'm showing creativity by giving the user the chance to read a random quote about keeping a journal
            Console.WriteLine("6. Read a random inspiring quote about keeping journals");
            Console.WriteLine("What would you like to do?");
            
            
            option = int.Parse(Console.ReadLine()) ;
            
             if (option ==1)
        {   
            //Console.WriteLine("You have selected 1, therefore to write Journal entry.");
            Entry myEntry = new Entry();
            myEntry._date = DateTime.Now.ToString("MM/dd/yyyy");
            PromptGenerator prompt = new PromptGenerator();
            
            myEntry._promptText = prompt.GetRandomPrompt();
            Console.WriteLine(myEntry._promptText);
            
            myEntry._entryText=Console.ReadLine();
            
            myJournal.AddEntry(myEntry);
            Console.WriteLine($"El largo de mi Journal es de: {myJournal._entries.Count}");
            

        }
        else if (option ==2)
        {   
            myJournal.DisplayAll();
            
        }
        else if (option ==3)
        {
            // Load:
            Console.WriteLine("Which file do you want to load?:");
            string file = Console.ReadLine();
            myJournal.LoadFromFile(file);
            myJournal.DisplayAll();
            
        }
        else if (option == 4)
        {
            // Save:
            Console.WriteLine("To which file do you want to save?:");
            string file = Console.ReadLine();
            myJournal.SaveToFile(file);
            
        }
        else if (option ==5)
        {

        }
        else if (option == 6)
        {
            Console.WriteLine(" ");
            Quote quote = new Quote();
            String myQuote = quote.getQuote();
            quote.showQuote(myQuote);
        }
        else 
        {
            Console.WriteLine("Invalid choice!");
        }

        }while (option !=5);
        
       

    }
}