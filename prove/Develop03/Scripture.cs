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
        
        _words.Add(new Word(singleVerse));
        
       }
       

    }

  


    public void HideRandomWords (int numberToHide)
    {
        int verseLength = _words.Count();
        int i=0;
        
        Random r = new Random();
        List <int> indexToHide = new List<int>();
        

        while (i < numberToHide)
        {   
            indexToHide.Add(r.Next (0,verseLength));
            i = i+1;
        }
        
        
        foreach (int myIndex in indexToHide)
        {
            
            _words[myIndex].Hide();
        }


 
    }

    public String GetDisplayText()
    {
        String myReference = _reference.GetDisplayText();
        String myVerse = "";
        foreach (Word word in _words)
        {
            
            myVerse = myVerse + " " + word.GetDisplayText();
            
        }
        return myReference + " " + myVerse;
    }

    public bool IsCompletelyHidden()
    {   
        
        foreach (Word palabra in _words)
        {
            if (palabra._isHidden == false)
            {   
                
                return false;
                
            }
        }
        
        return true;
    }
}