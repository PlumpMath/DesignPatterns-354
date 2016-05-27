using DesignPatterns.StructuralPattern.Decorator.Object;

namespace DesignPatterns.StructuralPattern.Decorator.CustomDecorator
{
    public class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza pizza) : base(pizza.Name + " and tomato", pizza)
        {
        }

        public override int GetCost()
        {
            return Pizza.GetCost() + 3;
        }
    }
}