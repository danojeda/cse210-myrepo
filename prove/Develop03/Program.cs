using System;

class Program
{
    static void Main(string[] args)
    {   
        int option=0;
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
        //Console.WriteLine($"THIS IS THE PASSAGE: {myPassage}");

        String [] thisVerse2 = myPassage.Split('/');
        /*
        Console.WriteLine($"El index 0: {thisVerse2[0]}");
        Console.WriteLine($"El index 1: {thisVerse2[1]}");
        Console.WriteLine($"El index 2: {thisVerse2[2]}");
        Console.WriteLine($"El index 3: {thisVerse2[3]}");
        */
        //Console.WriteLine($"El largo del array es:  {thisVerse2.Length}");
        Reference myReference;
        
        if (thisVerse2.Length < 5) // The length is 4, which is just 1 verse
        {
            //Console.WriteLine($"El index 0: {thisVerse2[0]}");
            //Console.WriteLine($"El index 1: {thisVerse2[1]}");
            //Console.WriteLine($"El index 2: {thisVerse2[2]}");
            //Console.WriteLine($"El index 3: {thisVerse2[3]}");

            book = thisVerse2[0];
            chapter = int.Parse(thisVerse2[1]);
            verse = int.Parse(thisVerse2[2]);
            thisVerse = thisVerse2[3];

            myReference = new Reference(book, chapter,verse);


        } else  //  The length is 5, thus, a range of verses
        {
            //Console.WriteLine($"El index 0: {thisVerse2[0]}");
            //Console.WriteLine($"El index 1: {thisVerse2[1]}");
            //Console.WriteLine($"El index 2: {thisVerse2[2]}");
            //Console.WriteLine($"El index 3: {thisVerse2[3]}");
            //Console.WriteLine($"El index 4: {thisVerse2[4]}");

            book = thisVerse2[0];  
            chapter = int.Parse(thisVerse2[1]);  
            verse = int.Parse(thisVerse2[2]);
            verseEnd = int.Parse(thisVerse2[3]);
            thisVerse = thisVerse2[4];

            myReference = new Reference(book, chapter,verse,verseEnd);
        }

        //Console.WriteLine($"El index 4: {thisVerse2[4]}");

        //Reference myReference = new Reference("1st Nephi", 3,7);
        //Reference myReference = new Reference("Proverbs", 3,5,6);
        String thisReference = myReference.GetDisplayText();
        //Console.WriteLine($"{thisReference}");

        //String thisVerse = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them";
        //String thisVerse ="Trust in the Lord with all thine heart; and lean not unto thine own understanding.In all thy ways acknowledge him, and he shall direct thy paths.";
        
        Scripture myScripture = new Scripture (myReference, thisVerse);
        String fullVerse = myScripture.GetDisplayText();
        

        Console.WriteLine("Welcome to the scripture memorizer!:");
        Console.WriteLine();
        Console.WriteLine($"{fullVerse}");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press ENTER to continue iterating or any other key to quit.");
        int numberOfWords = 4;
       

        while (Console.ReadKey().Key == ConsoleKey.Enter)
        {   
            Console.Clear();
            Console.WriteLine("************************************************************************************");
            Console.WriteLine();
            //Console.WriteLine("Here goes my scripture.");
            
            
            myScripture.HideRandomWords(numberOfWords);
            fullVerse = myScripture.GetDisplayText();
            Console.WriteLine($"{fullVerse}");
            Console.WriteLine();
            if (myScripture.IsCompletelyHidden())
            {
                Console.WriteLine($"Now all the words from the passage are hidden!.");
            }
            
           

            numberOfWords = numberOfWords + 3;
        }

        
       
            
    }
}