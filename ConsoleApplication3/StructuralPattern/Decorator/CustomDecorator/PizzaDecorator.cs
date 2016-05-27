using DesignPatterns.StructuralPattern.Decorator.Object;

namespace DesignPatterns.StructuralPattern.Decorator.CustomDecorator
{
    public abstract class PizzaDecorator : Pizza
    {
        public Pizza Pizza { get; private set; }


        protected PizzaDecorator(string name, Pizza pizza) : base(name)
        {
            Pizza = pizza;
        }
    }
}