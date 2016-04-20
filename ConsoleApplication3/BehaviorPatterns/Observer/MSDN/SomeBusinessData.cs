namespace DesignPatterns.BehaviorPatterns.Observer.MSDN
{
    public class SomeBusinessData
    {
        public string Name { get; private set; }

        public int Number { get; private set; }


        public SomeBusinessData(string name, int number)
        {
            Name = name;
            Number = number;
        }


        public override string ToString()
        {
            return "Name: " + Name + ", Number: " + Number;
        }
    }
}