using DesignPatterns.StructuralPattern.Decorator.Object;

namespace DesignPatterns.StructuralPattern.Decorator.CustomDecorator
{
    public class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza pizza) : base(pizza.Name + " and cheese", pizza)
        {
        }

        public override int GetCost()
        {
            return Pizza.GetCost() + 5;
        }
    }
}