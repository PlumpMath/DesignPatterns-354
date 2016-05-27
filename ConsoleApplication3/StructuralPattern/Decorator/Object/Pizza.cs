namespace DesignPatterns.StructuralPattern.Decorator.Object
{
    public abstract class Pizza
    {
        public string Name { get; private set; }


        protected Pizza(string name)
        {
            Name = name;
        }


        public abstract int GetCost();
    }
}