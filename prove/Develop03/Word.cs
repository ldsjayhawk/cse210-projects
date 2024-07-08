using System.Runtime.CompilerServices;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    //Hides word
    {
        _isHidden = true;
    }

    public void Show()
    //Shows word
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    //Displays word or blank if word is hidden
    {
        if (_isHidden)
        {
            string text = "";
            foreach (char l in _text)
            {
                text+= "_";
            }
            return text;
        }
        else 
        {
            return _text;
        }
    }
}