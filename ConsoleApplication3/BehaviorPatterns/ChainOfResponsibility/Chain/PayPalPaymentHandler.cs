using System;

namespace DesignPatterns.BehaviorPatterns.ChainOfResponsibility.Chain
{
    public class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver.Receiver receiver)
        {
            if (receiver.ViaPayPal)
            {
                Console.WriteLine("$" + receiver.Amount + " Handle via Pay Pal");
            }
            else if (Successor != null)
            {
                Successor.Handle(receiver);
            }
        }
    }
}