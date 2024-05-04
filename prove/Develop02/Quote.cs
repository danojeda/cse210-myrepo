/*
This additional class is called Quote since it reads from the Quote.txt file and randomly selects a quote to show to the user.
*/
using System.IO; 
public class Quote
{
    
    public List<String> _quote = new List<String>();
    public int myLength = 0;
    public String filename="quotes.txt";

    // This method reads from the quotes.txt file and randomly return a quote
    public String getQuote()
    {
        string [] quotes = System.IO.File.ReadAllLines(filename);
        myLength = quotes.Length;
        Random rnd = new Random();
        int num = rnd.Next(0,myLength);
        
        return quotes [num];

    }

    //This method just shows the quote using the format "The <author> once said: <quote>"
    public void showQuote(string quote)
    {
        String [] lineQuote = quote.Split("%");
        String theQuote = lineQuote[0];
        String theAuthor = lineQuote[1];
        Console.WriteLine($"{theAuthor} once said: \n\n{theQuote}.");
        Console.WriteLine(" ");
    }

    
}

