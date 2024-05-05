using System.IO; 
public class Journal
{
    
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        //Put newEntry into Entries
        _entries.Add(newEntry);
        
    }

    public void DisplayAll()
    {
        
        foreach (Entry entryElement in _entries)
        {   
            
            entryElement.Display();
        
        }

        
    }

    public void SaveToFile(string file)
    {
        //loop through each item in _entries ans save it in a file 
        

        foreach (Entry entryElement in _entries)
        {
                using (StreamWriter outputFile = new StreamWriter (file,true))
            {
                outputFile.WriteLine($"{entryElement._date},{entryElement._promptText},{entryElement._entryText}");
                
            }

        }

        
       
    }

    public void LoadFromFile (string file)
    {
        // loop through each line  of the file and create Entry objects to put in the list
        
        string [] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Entry entryFromFile = new Entry();
            String [] lineSections = line.Split(",");
            entryFromFile._date = lineSections [0];
            entryFromFile._promptText = lineSections [1];
            entryFromFile._entryText = lineSections [2];
            entryFromFile.Display();
        }

        
    }
}