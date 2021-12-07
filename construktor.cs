namespace guests
{
    // a construktor
    public class construktor
    {
        // we pass the two arguments with the global construktor it becomes global since it got the same name as the class
        public construktor(string name, string message)
        {
            Name = name;
            Message = message;
        }
        // we use get and set
        public string Name {get; set;}
        public string Message {get; set;}
    }
}