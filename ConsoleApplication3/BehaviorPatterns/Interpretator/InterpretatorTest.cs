using System;
using DesignPatterns.BehaviorPatterns.Interpretator.AbstractExpression.Nonterminal;
using DesignPatterns.BehaviorPatterns.Interpretator.AbstractExpression.Terminal;

namespace DesignPatterns.BehaviorPatterns.Interpretator
{
    public class InterpretatorTest : PatternTest
    {
        public InterpretatorTest() : base("Interpretator")
        {
        }


        public override void Run()
        {
            var context = new Context();
            int x = 5, y = 6, z = 7;

            context.SetValue("x", x);
            context.SetValue("y", y);
            context.SetValue("z", z);

            var expression = new SubstractExpression(
                new AddExpression(new NumberExpression("x"), new NumberExpression("y")), new NumberExpression("z"));

            var result = expression.Interpret(context);
            Console.WriteLine("x+y-z = " + result);
        }
    }
}
