using System;
using DesignPatterns.StructuralPattern.Decorator.CustomDecorator;
using DesignPatterns.StructuralPattern.Decorator.Object;

namespace DesignPatterns.StructuralPattern.Decorator
{
    public class DecoratorTest : PatternTest
    {
        public DecoratorTest() : base("Decorator")
        {
        }

        public override void Run()
        {
            var italianPizza = new ItalianPizza();
            Console.WriteLine(italianPizza.Name + " cost: " + italianPizza.GetCost());

            var italiantomatoPizza = new TomatoPizza(italianPizza);
            Console.WriteLine(italiantomatoPizza.Name + " cost: " + italiantomatoPizza.GetCost());

            var italianCheesePizza = new CheesePizza(italianPizza);
            Console.WriteLine(italianCheesePizza.Name + " cost: " + italianCheesePizza.GetCost());

            var italianTomatoCheesePizza = new TomatoPizza(new CheesePizza(italianPizza));
            Console.WriteLine(italianTomatoCheesePizza.Name + " cost: " + italianTomatoCheesePizza.GetCost());
        }
    }
}