using System.IO; 
public class Quote
{
    
    public List<String> _quote = new List<String>();
    public int myLength = 0;
    public String filename="quotes.txt";

    public String getQuote()
    {
        string [] quotes = System.IO.File.ReadAllLines(filename);
        myLength = quotes.Length;
        Random rnd = new Random();
        int num = rnd.Next(0,myLength);
        
        return quotes [num];

    }

    public void showQuote(string quote)
    {
        String [] lineQuote = quote.Split("%");
        String theQuote = lineQuote[0];
        String theAuthor = lineQuote[1];
        Console.WriteLine($"{theAuthor} once said: \n\n{theQuote}.");
        Console.WriteLine(" ");
    }

    
}

