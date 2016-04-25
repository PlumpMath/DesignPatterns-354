using System;

namespace DesignPatterns.BehaviorPatterns.ChainOfResponsibility.Chain
{
    public class WesternUnionPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver.Receiver receiver)
        {
            if (receiver.ViaWesternUnion)
            {
                Console.WriteLine("$" + receiver.Amount + " Handle via Western union");
            }
            else if (Successor != null)
            {
                Successor.Handle(receiver);
            }
        }
    }
}