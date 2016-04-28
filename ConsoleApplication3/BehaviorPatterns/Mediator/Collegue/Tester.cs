using System;
using DesignPatterns.BehaviorPatterns.Mediator.Mediator;

namespace DesignPatterns.BehaviorPatterns.Mediator.Collegue
{
    public class Tester : Collegue
    {
        public Tester(AbstractMediator mediator) : base(mediator)
        {
        }

        public override void Notify(string msg)
        {
            Console.WriteLine("Message for testre: "+ msg);
        }
    }
}