
using System.Runtime.CompilerServices;

public class Word 
{
    public String _text ;
    public bool _isHidden = false;



    public  Word (String text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide ()
    {
        _isHidden=true;
    }

    public void Show()
    {
        Console.WriteLine($"{_text}");
    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        // this will display the text or underline 
        // getdisplaytext in the Word class deals with which word is hidden

        if (_isHidden)
        {
            return "_______";
        }else{
            return _text;
        }
     

    }    
}