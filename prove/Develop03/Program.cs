using System;

class Program
{
    static void Main(string[] args)
    {   
        
        // I'm showing Creativity by having a set of scriptures in a file called "scripturerCatalog.txt", I randomly obtain some scripture and pass it to my Scripture object 
        Console.Clear();
        Console.WriteLine("Hello Develop03 World!");
        String thisVerse="";
        String book = "";
        int chapter ;
        int verse;
        int verseEnd;
        String filename = "scriptureCatalog.txt";
        String [] passageSections = System.IO.File.ReadAllLines(filename);
        int largo = passageSections.Length;
        Random rnd = new Random();
        int num = rnd.Next(0,largo);
        String myPassage =passageSections[num];
        

        String [] thisVerse2 = myPassage.Split('/');
        
        Reference myReference;
        
        if (thisVerse2.Length < 5) // The length is 4, which is just 1 verse
        {
            

            book = thisVerse2[0];
            chapter = int.Parse(thisVerse2[1]);
            verse = int.Parse(thisVerse2[2]);
            thisVerse = thisVerse2[3];

            myReference = new Reference(book, chapter,verse);


        } else  //  The length is 5, thus, a range of verses
        {
            

            book = thisVerse2[0];  
            chapter = int.Parse(thisVerse2[1]);  
            verse = int.Parse(thisVerse2[2]);
            verseEnd = int.Parse(thisVerse2[3]);
            thisVerse = thisVerse2[4];

            myReference = new Reference(book, chapter,verse,verseEnd);
        }

        
        String thisReference = myReference.GetDisplayText();
        

        
        
        Scripture myScripture = new Scripture (myReference, thisVerse);
        String fullVerse = myScripture.GetDisplayText();
        

        Console.WriteLine("Welcome to the scripture memorizer!:");
        Console.WriteLine();
        Console.WriteLine($"{fullVerse}");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press ENTER to continue iterating or type 'quit' to exit the memorizer:");
        int numberOfWords = 4;
       
        //while (Console.ReadKey().Key == ConsoleKey.Enter)
        while (Console.ReadLine() != "quit")
        {   
            Console.Clear();
            Console.WriteLine("************************************************************************************");
            Console.WriteLine();
            
            
            
            myScripture.HideRandomWords(numberOfWords);
            fullVerse = myScripture.GetDisplayText();
            Console.WriteLine($"{fullVerse}");
            Console.WriteLine();
            if (myScripture.IsCompletelyHidden())
            {
                
                break;
            }
            
           

            numberOfWords = numberOfWords + 3;
        }
        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Thanks for memorizing with us, see you soon!.");
        Console.WriteLine();
        Console.WriteLine();

        
       
            
    }
}