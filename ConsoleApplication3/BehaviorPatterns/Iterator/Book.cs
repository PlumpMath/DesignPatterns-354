namespace DesignPatterns.BehaviorPatterns.Iterator
{
    public class Book
    {
        public string Name { get; private set; }


        public Book(string name)
        {
            Name = name;
        }


        public override string ToString()
        {
            return "Name: " + Name;
        }
    }
}