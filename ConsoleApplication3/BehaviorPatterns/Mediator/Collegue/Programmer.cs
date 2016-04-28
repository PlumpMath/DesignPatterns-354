using System;
using DesignPatterns.BehaviorPatterns.Mediator.Mediator;

namespace DesignPatterns.BehaviorPatterns.Mediator.Collegue
{
    public class Programmer : Collegue
    {
        public Programmer(AbstractMediator mediator) : base(mediator)
        {
        }

        public override void Notify(string msg)
        {
            Console.WriteLine("Message for programmer: " + msg);
        }
    }
}