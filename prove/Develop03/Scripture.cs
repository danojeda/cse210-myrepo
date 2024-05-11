public class Scripture
{
    private Reference _reference;
    private List <Word> _words = new List<Word>();

    public  Scripture (Reference reference, String text)
    {
        _reference = reference;
        String [] arrayVerse = text.Split(" ");
        
       foreach (String singleVerse in arrayVerse)
       { 
        //Console.WriteLine($"This is the singleVerse: {singleVerse}");      
        _words.Add(new Word(singleVerse));
        //Console.WriteLine($"This is {}");
       }
       

    }

  


    public void HideRandomWords (int numberToHide)
    {
        int verseLength = _words.Count();
        int i=0;
        //Console.WriteLine($"{verseLength}");
        Random r = new Random();
        List <int> indexToHide = new List<int>();
        

        while (i < numberToHide)
        {   
            indexToHide.Add(r.Next (0,verseLength));
            i = i+1;
        }
        
        
        foreach (int myIndex in indexToHide)
        {
            //Console.WriteLine($"()()()(){myIndex}");
            _words[myIndex].Hide();
        }


        /*
        
            set the state of a randomly selected group of words to be hidden

            Need to find a set of visible words

            Need to randomly select 'numbertoHide' of those words

            How do you hide them?
            Use the hide function
        */
    }

    public String GetDisplayText()
    {
        String myReference = _reference.GetDisplayText();
        String myVerse = "";
        foreach (Word word in _words)
        {
            //Console.WriteLine($"El word element{word}");
            //myVerse = myVerse + word;
            myVerse = myVerse + " " + word.GetDisplayText();
            //Console.WriteLine($"El myVerse: {myVerse}");
        }
        return myReference + " " + myVerse;
    }

    public bool IsCompletelyHidden()
    {   
        //bool 
        foreach (Word palabra in _words)
        {
            if (palabra._isHidden == false)
            {   
                //Console.WriteLine("Encontré al menos 1  HIDDEN");
                return false;
                
            }
        }
        //Console.WriteLine("NO se encontró ninguno  HIDDEN");
        return true;
    }
}