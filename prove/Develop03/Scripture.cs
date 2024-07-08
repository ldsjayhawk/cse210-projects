using System.Data;
using System.Reflection.Metadata;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordary = text.Split();
        foreach (string wordstr in wordary)
        {
            Word wordobj = new Word(wordstr);
            _words.Add(wordobj);
        }
    }

    public bool IsCompletelyHidden()
    //Determines if all words are hidden
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void HideRandomWords(int numberToHide)
    // Hides words if all words are not hidden
    {
        //variable to determine number of words to hide
        int hiddenWords = 0;
        Random randomNumber = new Random();


        // Check if there are more words to hide.  
        while (hiddenWords < numberToHide)
        {
            int x;
            do
            {
                x = randomNumber.Next(_words.Count);
            }
            while (_words[x].IsHidden());

        // Hide words
            _words[x].Hide();

        // Stop loop if no additonal words to hide
            if (IsCompletelyHidden())
               break;
        
        // Increment variable
            hiddenWords ++;
        }
    }

    public void GetDisplayText()
    {
        // Loop through all words and display
        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText()+" ");
        }
        Console.WriteLine();
    }
}