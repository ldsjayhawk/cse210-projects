public class Entry
    {
        public string _entryDate;
        public string _promptText; 
        public string _entryText;
        public string _location;
        public void Display()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine($"{_entryDate} {_location}");
            Console.WriteLine($"{_promptText}");
            Console.WriteLine($"{_entryText}");
            Console.WriteLine();
        }
    }