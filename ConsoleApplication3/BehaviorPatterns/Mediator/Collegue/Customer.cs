using System;
using DesignPatterns.BehaviorPatterns.Mediator.Mediator;

namespace DesignPatterns.BehaviorPatterns.Mediator.Collegue
{
    public class Customer : Collegue
    {
        public Customer(AbstractMediator mediator) : base(mediator)
        {
        }

        public override void Notify(string msg)
        {
            Console.WriteLine("Message for customer: "+msg);
        }
    }
}