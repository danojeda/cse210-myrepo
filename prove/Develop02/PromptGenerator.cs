public class PromptGenerator
{
     public List <string> _prompts = new List<string> ();
     public int arrayLength = 0;

     
     public string GetRandomPrompt()
     {
        
        string filename = "myFile.txt";
        string [] lines = System.IO.File.ReadAllLines(filename);
        arrayLength = lines.Length;
        Random rnd = new Random();
        int num = rnd.Next(0,arrayLength);
        return lines [num];
        
     }
}


