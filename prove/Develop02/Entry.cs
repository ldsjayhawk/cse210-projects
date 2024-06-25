public class Entry
    {
        public string _entryDate;
        public string _promptText; 
        public string _entryText;

        public void Display()
        {
            Console.WriteLine($"{_entryDate} {_promptText} {_entryText}");
        }

    }