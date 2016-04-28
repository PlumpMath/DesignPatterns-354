using DesignPatterns.BehaviorPatterns.Mediator.Collegue;
using DesignPatterns.BehaviorPatterns.Mediator.Mediator;

namespace DesignPatterns.BehaviorPatterns.Mediator
{
    public class MediatorTest : PatternTest
    {
        public MediatorTest() : base("Mediator")
        {
        }


        public override void Run()
        {
            var manager = new Manager();
            var programmer = new Programmer(manager);
            var tester = new Tester(manager);
            var customer = new Customer(manager);

            manager.Programmer = programmer;
            manager.Tester = tester;
            manager.Customer = customer;

            customer.Send("Start developing!");
            programmer.Send("The code deployed");
            tester.Send("The application tested");
        }
    }
}